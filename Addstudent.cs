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
    public partial class Addstudent : MaterialForm
    {
        public Addstudent()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo900, Primary.Indigo500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void Addstudent_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
            if(checkvalidinputs(firstnameTextBox1.Text,lastnameTextBox1.Text,contactTextBox2.Text,EmailTextBox3.Text,regnoTextBox1.Text))
            {
                Queries.addstudentquery(firstnameTextBox1.Text, lastnameTextBox1.Text, contactTextBox2.Text, EmailTextBox3.Text, regnoTextBox1.Text.ToUpper(), STATUSComboBox1.Text);
                MessageBox.Show("Successfully Added student :" + firstnameTextBox1.Text + " " + lastnameTextBox1.Text);
                clearfield();
            }
        }
        public bool checkvalidinputs(string fname,string lname,string contact,string email,string reg)
        {
            if(fname == "" ||lname == ""|| lname[0]==' '|| fname[0] == ' ')
            {
                MessageBox.Show("Invalid Name ");
                return false;
            }
            if(contact.Length != 11 || contact[0] != '0' || contact[1] != '3'|| contact == "")
            {
                MessageBox.Show("Invalid contact number");
                return false;
            }
            if(!email.EndsWith("@gmail.com") || email == "")
            {
                MessageBox.Show("Invalid email address");
                return false;
            }
            if(reg == "" || Queries.regnoexist(reg.ToUpper()))
            {
                MessageBox.Show("invalid Registration Number");
                return false;
            }
            return true;

          
        }
        public void clearfield()
        {
            firstnameTextBox1.Text = "";
            lastnameTextBox1.Text = "";
            contactTextBox2.Text = "";
            EmailTextBox3.Text = "";
            regnoTextBox1.Text = "";
            STATUSComboBox1.Text = "";
        }
    }
}
