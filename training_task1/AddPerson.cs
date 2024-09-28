using System;
using System.Windows.Forms;
using training_task1.Models;

namespace training_task1
{
    public partial class AddPerson : Form
    {
        private Person person;

        public AddPerson(Person person = null)
        {
            this.person = person ?? new Person {
                Id = Guid.NewGuid(),
                BirthDate = DateTime.Now.AddYears(-16),
                Name = "JOja",
                AvrMark = 3.0m,
                Dept = false,
                Expelled = true,
                Gender = Gender.Male,
            };
            InitializeComponent();

            genderComboBox.Items.Add(Gender.Male);
            genderComboBox.Items.Add(Gender.Female);

            fioTextBox.DataBindings.Add(new Binding(
                "Text",
                this.person,
                "Name",
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            genderComboBox.DataBindings.Add(new Binding(
                "SelectedItem",
                this.person,
                "Gender",
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            birthDatePicker.DataBindings.Add(new Binding(
                "Value",
                this.person,
                "BirthDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            avrMarkUpDown.DataBindings.Add(new Binding(
                "Value",
                this.person,
                "AvrMark",
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            deptCheckBox.DataBindings.Add(new Binding(
                "Checked",
                this.person,
                "Dept",
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            expellCheckBox.DataBindings.Add(new Binding(
                "Checked",
                this.person,
                "Expelled",
                false,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        public Person Person => person;
    }
}
