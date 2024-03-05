using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using MaterialSkin;
using DBLabProjectMID.Properties;
using DBLabProjectMID.Utility;

namespace DBLabProjectMID
{
    public partial class editstudentform : MaterialForm
    {
        DataGridViewRow row;
        public editstudentform(DataGridViewRow row)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo900, Primary.Indigo500, Accent.LightBlue200, TextShade.WHITE);
            this.row = row;

            loadvalues(row);

        }
        public void loadvalues(DataGridViewRow row)
        {
            firstNametxt.Text = row.Cells[3].Value.ToString();
            lastNametxt.Text = row.Cells[4].Value.ToString();
            contacttxt.Text = row.Cells[5].Value.ToString();
            emailtxt.Text = row.Cells[6].Value.ToString();
            regNotxt.Text = row.Cells[7].Value.ToString();
            cbStatus.SelectedText = row.Cells[8].Value.ToString();
        }

        private void editstudentform_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(checkvalidinputs(firstNametxt.Text,lastNametxt.Text,contacttxt.Text,emailtxt.Text,regNotxt.Text))
            {
                if (MessageBox.Show("Confirm Edit! ", "Edit Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string id = row.Cells[2].Value.ToString();
                    Queries.queryforedit(firstNametxt.Text, lastNametxt.Text, contacttxt.Text, emailtxt.Text, regNotxt.Text, cbStatus.Text, id);
                        this.Close();
                }
            }
        }
        public bool checkvalidinputs(string fname, string lname, string contact, string email, string reg)
        {
            if (fname == "" || lname == "" || lname[0] == ' ' || fname[0] == ' ')
            {
                MessageBox.Show("Invalid Name ");
                return false;
            }
            if (contact.Length != 11 || contact[0] != '0' || contact[1] != '3' || contact == "")
            {
                MessageBox.Show("Invalid contact number");
                return false;
            }
            if (!email.EndsWith("@gmail.com") || email == "")
            {
                MessageBox.Show("Invalid email address");
                return false;
            }
            if (reg == "" || Queries.regnoexist(reg.ToUpper()))
            {
                MessageBox.Show("invalid Registration Number");
                return false;
            }
            return true;


        }
        public void clearfield()
        {
            firstNametxt.Text = "";
            lastNametxt.Text = "";
            contacttxt.Text = "";
            emailtxt.Text = "";
            regNotxt.Text = "";
            cbStatus.Text = "";
        }
    }
}
