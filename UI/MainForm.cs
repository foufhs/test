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

       

     
        public MainForm()
        {
            InitializeComponent();
            LoadingText.Show();
            this.Update();
            LoadListData();
            WireUpList();
            LoadingText.Hide();
        }

        private void WireUpList()
        {
            peopleListBox.DataSource = people;
            peopleListBox.DisplayMember = "Fullname";
        }

        private void LoadListData()
        {         
            people = GlobalConfig.Connections.GetPerson_All();         
        }
        
        /// <summary>
        /// Add Button Functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonData model = new PersonData();
                model.Name = nameBox.Text;
                model.Surname = surnameBox.Text;

            
                GlobalConfig.Connections.CreatePerson(model);

                LoadingText.Show();
                this.Update();
                nameBox.Text = "";
                surnameBox.Text = "";
                LoadListData();
                WireUpList();
                nameBox.Select();
                LoadingText.Hide();
            }
            

        }


        /// <summary>
        /// Delete Button Functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            PersonData model = (PersonData)peopleListBox.SelectedItem;
            if (model != null)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    selectedIndex = peopleListBox.SelectedIndex;
                        GlobalConfig.Connections.DeletePerson(model).ToString();
                }
                
                
            }
            
            LoadingText.Show();
            this.Update();
            LoadListData();
            WireUpList();
            peopleListBox.SetSelected(selectedIndex,true);
            LoadingText.Hide();            
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (nameBox.Text.Length == 0) { output = false; }
            if (surnameBox.Text.Length == 0) { output = false; }
            return output;

        }
        /// <summary>
        /// Edit Button Functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton(object sender, EventArgs e)
        {
            PersonData model = (PersonData)peopleListBox.SelectedItem;
            if (model != null)
            {
                EditPersonForm editForm = new EditPersonForm(model);
                editForm.ShowDialog();
                LoadingText.Show();
                this.Update();
                System.Threading.Thread.Sleep(3000);
                LoadListData();
                WireUpList();
                LoadingText.Hide();

            }



        }

     
    }
}
