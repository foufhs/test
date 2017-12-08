using DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EditPersonForm : Form
    {
        private PersonData personToBeEdited = new PersonData();
        public EditPersonForm()
        {
            InitializeComponent();
        }

        public EditPersonForm(PersonData person)
        {
            InitializeComponent();
            this.Text = "Editing :" + person.FullName;
            nameBox.Text = person.Name.ToString();
            surnameBox.Text = person.Surname.ToString();
            personToBeEdited = person;
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okEditButton_Click(object sender, EventArgs e)
        { 
            GlobalConfig.Connections.EditPerson(personToBeEdited, nameBox.Text, surnameBox.Text);
            this.Close();

        }
    }
}
