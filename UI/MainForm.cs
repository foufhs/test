using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.DataAccess;
using DataLibrary;

namespace UI
{
    public partial class MainForm : Form
    {
        private List<PersonData> people = new List<PersonData>();
        private PersonData selectedPerson = new PersonData();

        private void WireUpList()
        {
            peopleListBox.DataSource = people;
            peopleListBox.DisplayMember = "Fullname";
        }

     
        public MainForm()
        {
            InitializeComponent();
            LoadListData();
            WireUpList();
        }

        private void LoadListData()
        {
            
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                people = db.GetPerson_All();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonData model = new PersonData();
                model.Name = nameBox.Text;
                model.Surname = surnameBox.Text;

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePerson(model);
                }

                nameBox.Text = "";
                surnameBox.Text = "";
                LoadListData();
                WireUpList();

            }
            

        }

        private bool ValidateForm()
        {
            bool output = true;
            if (nameBox.Text.Length == 0) { output = false; }
            if (surnameBox.Text.Length == 0) { output = false; }
            return output;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            PersonData model = (PersonData)peopleListBox.SelectedItem;
            if (model != null)
            {
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.DeletePerson(model);
                }
            }
            LoadListData();
            WireUpList();
        }
    }
}
