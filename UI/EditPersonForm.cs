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
            this.Opacity = 0.1;
            FadeIn(this, 20);
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
            if (ValidateForm())
            {
                GlobalConfig.Connections.EditPerson(personToBeEdited, nameBox.Text, surnameBox.Text);
                FadeOut(this,60);
                             
            }
            else
            {
                MessageBox.Show("Please fill in both fields!");

            }

        }
        private bool ValidateForm()
        {
            bool output = true;
            if (nameBox.Text.Length == 0) { output = false; }
            if (surnameBox.Text.Length == 0) { output = false; }
            return output;

        }

        private async void FadeIn(Form o, int interval)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        private async void FadeOut(Form o, int interval)
        {
            //Object is fully invisible. Fade it out
            while (o.Opacity > 0.5)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0;
            o.Close(); //make fully invisible       
        }
    }
}
