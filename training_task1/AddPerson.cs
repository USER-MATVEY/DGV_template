using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using training_task1.Models;

namespace training_task1
{
    public partial class AddPerson : Form
    {
        private Person person;

        public AddPerson(Person person = null)
        {
            this.person = person ?? DataGenerator.CreatePerson(x => x.Name = "Жожа");
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                genderComboBox.Items.Add(item);
            }
            if (genderComboBox.Items.Count > 0)
            {
                genderComboBox.SelectedIndex = 0;
            }

            fioTextBox.DataBindings.Add(new Binding(
                nameof(TextBox.Text),
                this.person,
                nameof(Person.Name),
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            genderComboBox.DataBindings.Add(new Binding(
                nameof(ComboBox.SelectedItem),
                this.person,
                nameof(Person.Gender),
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            birthDatePicker.DataBindings.Add(new Binding(
                nameof(DateTimePicker.Value),
                this.person,
                nameof(Person.BirthDate),
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            avrMarkUpDown.DataBindings.Add(new Binding(
                nameof(NumericUpDown.Value),
                this.person,
                nameof(Person.AvrMark),
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            deptCheckBox.DataBindings.Add(new Binding(
                nameof(CheckBox.Checked),
                this.person,
                nameof(Person.Dept),
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            expellCheckBox.DataBindings.Add(new Binding(
                nameof(CheckBox.Checked),
                this.person,
                nameof(Person.Expelled),
                false,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        public Person Person => person;

        private void genderComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.FillEllipse(Brushes.Red,
                new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4));
            if (e.Index > -1)
            {
                e.Graphics.DrawString(
                    GetDisplayValue((Gender)(sender as ComboBox).Items[e.Index]), 
                    e.Font, new SolidBrush(e.ForeColor), 
                    e.Bounds.X + 20, e.Bounds.Y);
            }
        }

        private string GetDisplayValue(Gender value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes<DescriptionAttribute>(false);
            return attributes.FirstOrDefault()?.Description;
        }
    }
}
