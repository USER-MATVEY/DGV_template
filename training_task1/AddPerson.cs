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
            this.person = person ?? DataGenerator.CreatePerson(x => x.Name = "jira");
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                genderComboBox.Items.Add(item);
            }
            if (genderComboBox.Items.Count > 0)
            {
                genderComboBox.SelectedIndex = 0;
            }


            genderComboBox.AddBinding(this.person, x => x.SelectedItem, y => y.Gender);
            
            birthDatePicker.AddBinding(this.person, x => x.Value, y => y.BirthDate);

            avrMarkUpDown.AddBinding(this.person, x => x.Value, y => y.AvrMark);

            deptCheckBox.AddBinding(this.person, x => x.Checked, y => y.Dept);

            expellCheckBox.AddBinding(this.person, x => x.Checked, y => y.Expelled);
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
