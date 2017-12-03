using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;
namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
                    db.createData(model);
                }
               
            }
            else
            {
                MessageBox.Show("Invalid Form");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            if (nameBox.Text.Length == 0) { output = false; }
            if (surnameBox.Text.Length == 0) { output = false; }
            return output;

        }
    }
}
