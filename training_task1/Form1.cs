using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using training_task1.Models;

namespace training_task1
{
    public partial class Journal : Form
    {
        private List<Person> people;
        private BindingSource bindingSource;

        public Journal()
        {
            bindingSource= new BindingSource();
            people = new List<Person>();
            bindingSource.DataSource = people;
            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = bindingSource;
            ShowStats();
        }

        private void AddNewButton_Click(object sender, System.EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            if (addPerson.ShowDialog(this) == DialogResult.OK)
            {
                people.Add(addPerson.Person);
                bindingSource.ResetBindings(false);
                ShowStats();
            };
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "ExpellColumn")
            {
                var data = (Person)dataGridView.Rows[e.ColumnIndex].DataBoundItem;
                e.Value = data.Expelled ? "Yes" : string.Empty;
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "DeptColumn")
            {
                var data = (Person)dataGridView.Rows[e.ColumnIndex].DataBoundItem;
                e.Value = data.Dept ? "Yes" : string.Empty;
            }
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0) 
            {
                var data = (Person)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show("Вы реально хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    people.Remove(data);
                    bindingSource.ResetBindings(false);
                    ShowStats();
                }
            }
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var data = (Person)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
                AddPerson editPerson = new AddPerson();
                if (editPerson.ShowDialog(this) == DialogResult.OK)
                {
                    data.Name = editPerson.Person.Name;
                    data.AvrMark = editPerson.Person.AvrMark;
                    data.Gender = editPerson.Person.Gender;
                    data.BirthDate = editPerson.Person.BirthDate;
                    data.Dept = editPerson.Person.Dept;
                    data.Expelled = editPerson.Person.Expelled;
                    bindingSource.ResetBindings(false);
                    ShowStats();
                }
            }
        }

        public void ShowStats()
        {
            toolStripStatusLabel1.Text = $"Всего: {people.Count}";
            toolStripStatusLabel2.Text = $"{people.Where(x => x.Gender == Gender.Female).Count()} Ж / {people.Where(x => x.Gender == Gender.Female).Count()} М";
            toolStripStatusLabel3.Text = $"Отчисленны: {people.Where(x => x.Expelled).Count()}";
            toolStripStatusLabel4.Text = $"Задолжники: {people.Where(x => x.Dept).Count()}";
            toolStripStatusLabel5.Text = $"Средняя отценка: {people.DefaultIfEmpty(new Person()).Average(x => x.AvrMark)}";
        }
    }
}
