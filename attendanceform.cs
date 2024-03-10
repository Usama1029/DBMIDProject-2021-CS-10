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
    public partial class attendanceform : MaterialForm
    {
        DateTime datetime;
        DataGridViewRow attendance;
        
        public attendanceform(DateTime datetime)
        {
           
            getlookupidforattendance();
            showallstudent();
            this.datetime = datetime;
            DateTimePicker date_time = new DateTimePicker();
            date_time.Value = datetime;

            
            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo900, Primary.Indigo500, Accent.LightBlue200, TextShade.WHITE);

        }
        public attendanceform(DataGridViewRow attendance)
        {
            showallstudent();
            getlookupidforattendance();
            this.attendance = attendance;
            DateTime dt = Convert.ToDateTime(attendance.Cells[1].Value.ToString());
            dateTimePicker.Value = dt;

        }
        public void loadPrevAttd()
        {
            int attdId = Queries.queryGetAttdId(dateTimePicker.Value);
            DataTable stdData = Queries.queryGetStddIdsStatus(attdId);

            for (int idx = 0; idx < dgvAttendance.Rows.Count; idx++)
            {
                DataGridViewRow row = dgvAttendance.Rows[idx];
                for (int i = 0; i < stdData.Rows.Count; i++)
                {
                    string stdID = row.Cells[1].Value.ToString();
                    string dbstdID = stdData.Rows[i][0].ToString();

                    if (stdID == dbstdID)
                    {
                        int ID = Convert.ToInt32(stdData.Rows[i][1]);
                        row.Cells[0].Value = Queries.queryGetStatusName(ID); /// -------------------------- here
                        break;
                    }
                }
            }
        }

        private void attendanceform_Load(object sender, EventArgs e)
        {
           
        }

        public void showallstudent()
        {
            dgvAttendance.DataSource = Queries.queryActiveStudentsForAttendance();

        }
        public void getlookupidforattendance()
        {
            DataTable dt = Queries.queryActiveStudentsForAttendance("Active");
            
            cbStatus.DataSource = dt;
            cbStatus.DisplayMember = "Name";
            cbStatus.ValueMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                saveAttd();
            }
            else if (btnSave.Text == "Edit")
            {
                editAttd();
            }
        }
        public void saveAttd()
        {
            if (MessageBox.Show("Confirm Attendance!\nAny unmarked attendance will be consider as Absent", "Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var datetime = dateTimePicker.Value;
                bool isAdded = Queries.queryAddAttendanceDate(datetime);
                int id = Queries.queryGetAttendanceID(datetime);

                if (!isAdded)
                {
                    Queries.queryDeletePrevAttd(id);

                }
                attdendance(id);
            }
        }
        public void editAttd()
        {
            if (MessageBox.Show("Confirm Edit Attendance", "Edit Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime datetime = dateTimePicker.Value;
                Queries.queryAddAttendanceDate(datetime);
                int id = Queries.queryGetAttendanceID(datetime);
                Queries.queryDeletePrevAttd(id);

                attdendance(id);
            }
        }
        public void attdendance(int id)
        {
            for (int i = 0; i < dgvAttendance.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgvAttendance.Rows[i];

                int statusID;
                if (row.Cells[0].Value == null)
                {
                    statusID = Queries.findLookUpId("Absent");
                }
                else
                {
                    string status = row.Cells[0].Value.ToString();
                    statusID = Queries.findLookUpId(status);
                }
                string st = row.Cells[1].Value.ToString();
                int stID = Convert.ToInt32(st);
                Queries.queryMarkAttendance(id, stID, statusID);

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }
    }
}
