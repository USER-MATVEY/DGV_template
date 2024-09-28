using System.Collections.Generic;
using System.Windows.Forms;
using training_task1.Models;

namespace training_task1
{
    public partial class Journal : Form
    {
        private List<Person> people;

        public Journal()
        {
            people = new List<Person>();
            InitializeComponent();
        }

        private void AddNewButton_Click(object sender, System.EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            if (addPerson.ShowDialog(this) == DialogResult.OK)
            {
                people.Add(addPerson.Person);
            };
        }
    }
}
