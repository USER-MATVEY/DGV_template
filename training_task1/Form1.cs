using DataGrid.Standart.Contracts;
using DataGrid.Standart.Contracts.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_task1
{
    public partial class Journal : Form
    {
        private IPeopleManager peopleManager;
        private BindingSource bindingSource;

        public Journal(IPeopleManager peopleManager)
        {
            this.peopleManager = peopleManager;
            bindingSource = new BindingSource();
            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = bindingSource;
        }

        private async void AddNewButton_Click(object sender, System.EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            if (addPerson.ShowDialog(this) == DialogResult.OK)
            {
                await peopleManager.AddAsync(addPerson.Person);
                bindingSource.ResetBindings(false);
                await ShowStats();
            };
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "ExpellColumn")
            {
                var data = (Person)dataGridView.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.Expelled ? "Yes" : string.Empty;
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "DeptColumn")
            {
                var data = (Person)dataGridView.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.Dept ? "Yes" : string.Empty;
            }
        }

        private async void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var data = (Person)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show("Вы реально хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await peopleManager.deleteAsync(data.Id);
                    bindingSource.ResetBindings(false);
                    await ShowStats();
                }
            }
        }

        private async void UpdateButton_Click(object sender, System.EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var data = (Person)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
                AddPerson editPerson = new AddPerson();
                if (editPerson.ShowDialog(this) == DialogResult.OK)
                {
                    await peopleManager.EditAsync(editPerson.Person);
                    bindingSource.ResetBindings(false);
                    await ShowStats();
                }
            }
        }

        public async Task ShowStats()
        {
            var result = await peopleManager.GetAllStatsAsync();
            toolStripStatusLabel1.Text = $"Всего: {result.Count}";
            toolStripStatusLabel2.Text = $"{result.FemaleCount} Ж / {result.MaleCount} М";
            toolStripStatusLabel3.Text = $"Отчисленны: {result.ExpelledCount}";
            toolStripStatusLabel4.Text = $"Задолжники: {result.DeptCount}";
            toolStripStatusLabel5.Text = $"Средняя отценка: {result.AvrRate}";
        }

        private void Journal_Load(object sender, System.EventArgs e)
        {
            bindingSource.DataSource = peopleManager.GetAllAsync();
            bindingSource.ResetBindings(false);
        }
    }
}
