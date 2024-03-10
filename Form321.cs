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
        int cloid;
        public Form321()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo900, Primary.Indigo500, Accent.LightBlue200, TextShade.WHITE);

            showgrid();
            bind_attendancegrid();
            totalclo();
            bindclo();
            bindcloforcombobox();
            showrubric();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
            Menu f = new Menu();
            f.Show();
        }
        public void totalclo()
        {
            int count = Queries.totalclo();
            Labelcount.Text = "Total " + count + " CLOs Added.";
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
                    string id = rownumber.Cells[2].Value.ToString();
                   

                    if (Queries.isStdExistInResultAndAtd(int.Parse(id)))
                    {
                        
                        Queries.deletestudent(id);
                        showgrid();
                    }
                    else
                    {
                        MessageBox.Show("Sorry! You can not delete student.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        public void addcolomsname(DataTable dt)
        {
            DataTable name = dt;
            dataGridViewaddendance.ColumnCount = name.Rows.Count + 3;
            dataGridViewaddendance.Columns[2].Name = "Date";
            dataGridViewaddendance.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            int x = 3;
            
            for (int i = 0; i < name.Rows.Count; i++)
            {
                dataGridViewaddendance.Columns[x].Name = name.Rows[i][0].ToString();

                x++;
            }
            dataGridViewaddendance.Columns[0].DisplayIndex = 6;
            dataGridViewaddendance.Columns[1].DisplayIndex = 6;
        }
        public void bind_attendancegrid()
        {
            DataTable name = Queries.queryLookUpValues("ATTENDANCE_STATUS");
            DataTable date = Queries.queryfordate();
            addcolomsname(name);
            List<int> statusid = new List<int>();
            foreach(DataRow row in name.Rows)
            {
                string status = row[0].ToString();
                statusid.Add(Queries.findLookUpId(status));

            }
            dataGridViewaddendance.RowCount = date.Rows.Count;

            for (int i = 0; i < date.Rows.Count; i++)
            {
                DataRow da = date.Rows[i];
                DateTime dateTime = Convert.ToDateTime(da[0].ToString());

                // finding count of each status for specific date
                List<int> counts = new List<int>();
                foreach (int id in statusid)
                {
                    counts.Add(Queries.queryStudentAttendanceCountByStatus(id, dateTime));
                }
                dataGridViewaddendance.Rows[i].Cells[2].Value = dateTime;
                int x = 3;
                foreach (int count in counts)
                {
                    dataGridViewaddendance.Rows[i].Cells[x].Value = count;
                    x++;
                }

            }

        }
        private void dataGridViewaddendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            string colname = dataGridViewaddendance.Columns[e.ColumnIndex].Name;
            DataGridViewRow rownumber = dataGridViewaddendance.Rows[e.RowIndex];
            if(colname == "Edits")
            {
                MessageBox.Show("asdfasdf");
            }
            else if(colname == "Deletes")
            {
                if (MessageBox.Show("Are you sure you want to delete Attendance!", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                   
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cloadd_Click(object sender, EventArgs e)
        {
            string detail = materialTextBox1.Text;
            if(detail == "" || materialTextBox1.Text[0] == ' ')
            {
                MessageBox.Show("CLO cannot be empty!");
               
               
            }
            else
            {
                if(cloadd.Text == "Edit")
                {
                    if(MessageBox.Show("Are you sure you want to edit!", "Edit CLO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Queries.queryUpadateCLO(cloid, detail);
                      
                    }
                    cloadd.Text = "Add";
                    materialTextBox1.Text = "";

                }
                else
                {
                    DateTime time = DateTime.Now;
                    Queries.insertclo(time,detail);
                    materialTextBox1.Text = "";

                   
                }
                totalclo();
                bindclo();
            }
        }

        public void bindclo()
        {
            DataTable dt = Queries.queryforgetclo();
            dataGridViewclo.DataSource = dt;

            // Check if there are at least 2 columns
            if (dataGridViewclo.Columns.Count >= 2)
            {
                dataGridViewclo.Columns[0].DisplayIndex = 5;
                dataGridViewclo.Columns[1].DisplayIndex = 5;
            }
            // Set AutoSizeMode for the third column
            if (dataGridViewclo.Columns.Count >= 3)
            {
                dataGridViewclo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void cancelbtn_Click(object sender, EventArgs e)
        {
            materialTextBox1.Text = "";
            cloadd.Text = "Add";
        }

        private void dataGridViewclo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dataGridViewclo.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dataGridViewclo.Rows[e.RowIndex];
            cloid = (int)row.Cells[2].Value;

            if (colName == "Editclo")
            {
               cloadd.Text = "Edit";
                //materialTextBox1.Text = row.Cells[4].Value.ToString();

            }
        }
        public void bindcloforcombobox()
        {
            DataTable dt = Queries.queryforgetclo();
            comboclo.DataSource = dt;
            comboclo.DisplayMember = "Name";
            comboclo.ValueMember = "Id";
            comboclo.SelectedIndex = 0;
        }

        private void materialButton1abbrubric_Click(object sender, EventArgs e)
        {
            if(rubricTextBox2.Text == "" || rubricTextBox2.Text [0]== ' ')
            {
                MessageBox.Show("Rubric Details cannot be empty!", "Rubirc Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string detail = rubricTextBox2.Text;
                int cloid = (int)comboclo.SelectedValue;
                Queries.insertrubric(cloid, detail);
                bindclo();
                showrubric();
               
            }
        }
        public  void showrubric()
        {
            DataTable dt = Queries.queryforgetrubric();
            dgvrubric.DataSource = dt;

            // Check if there are at least 2 columns
            if (dgvrubric.Columns.Count >= 2)
            {
                dgvrubric.Columns[0].DisplayIndex = 5;
                dgvrubric.Columns[1].DisplayIndex = 5;
                dgvrubric.Columns[2].DisplayIndex = 5;

            }
            // Set AutoSizeMode for the third column
            if (dgvrubric.Columns.Count >= 4)
            {
                dgvrubric.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dataGridViewrubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addnewattendancebtn_Click(object sender, EventArgs e)
        {
            attendanceform ff = new attendanceform(dateTimePicker1.Value);
            ff.ShowDialog();
        }
    }
}
