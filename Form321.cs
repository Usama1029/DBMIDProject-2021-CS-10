using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DBLabProjectMID.Utility;


namespace DBLabProjectMID
{
    public partial class Form321 : MaterialForm
    {
        public Form321()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo900, Primary.Indigo500, Accent.LightBlue200, TextShade.WHITE);

            showgrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
            Menu f = new Menu();
            f.Show();
        }
        public void showgrid()
        {
            if(swchactive.Checked == true)
            {

                dataGridstudent.DataSource = Queries.queryforactivestudent();
            }
            else if(swchactive.Checked == false)
            {
                dataGridstudent.Refresh();
                dataGridstudent.DataSource = Queries.queryforallstudent();
            }
            dataGridstudent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridstudent.Columns[0].DisplayIndex = 8;
            dataGridstudent.Columns[1].DisplayIndex = 8;
        }
        private void dataGridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
          
            string colName = dataGridstudent.Columns[e.ColumnIndex].Name;
            DataGridViewRow rownumber = dataGridstudent.Rows[e.RowIndex];

            if (colName == "Edit")
            {
                editstudentform f = new editstudentform(rownumber);
                f.ShowDialog();
                showgrid();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Handle Delete action
                }
            }
        }

        private void swchactive_CheckedChanged(object sender, EventArgs e)
        {
            showgrid();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
       

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Addstudent f = new Addstudent();
            f.ShowDialog();
        }

        private void dataGridViewaddendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
