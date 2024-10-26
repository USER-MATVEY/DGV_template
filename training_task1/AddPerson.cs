using DataGrid.Standart.Contracts.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace training_task1
{
    public partial class AddPerson : Form
    {
        private Person person;

        public AddPerson(Person person = null)
        {
            this.person = person == null
                ?
                DataGenerator.CreatePerson(
                x =>
                {
                    x.Id = Guid.NewGuid();
                    x.Name = "jira";
                    x.BirthDate = DateTime.Now.AddYears(-13);
                })
                :
                new Person
                {
                    Id = person.Id,
                    Name = person.Name,
                    BirthDate = person.BirthDate,
                    Gender = person.Gender,
                    AvrMark = person.AvrMark,
                    Dept = person.Dept,
                    Expelled = person.Expelled,
                };
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                genderComboBox.Items.Add(item);
            }
            if (genderComboBox.Items.Count > 0)
            {
                genderComboBox.SelectedIndex = 0;
            }

            fioTextBox.AddBinding(this.person, x => x.Text, y => y.Name, errorProvider);

            genderComboBox.AddBinding(this.person, x => x.SelectedItem, y => y.Gender, errorProvider);

            birthDatePicker.AddBinding(this.person, x => x.Value, y => y.BirthDate, errorProvider);

            avrMarkUpDown.AddBinding(this.person, x => x.Value, y => y.AvrMark, errorProvider);

            deptCheckBox.AddBinding(this.person, x => x.Checked, y => y.Dept, errorProvider);

            expellCheckBox.AddBinding(this.person, x => x.Checked, y => y.Expelled, errorProvider);
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
