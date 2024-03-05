
namespace DBLabProjectMID
{
    partial class Form321
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form321));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridstudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.swchactive = new MaterialSkin.Controls.MaterialSwitch();
            this.addstudentButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.attendancelbl = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addnewattendancebtn = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewaddendance = new System.Windows.Forms.DataGridView();
            this.Edits = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletes = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.attnameLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.imageListhome = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstudent)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaddendance)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialRadioButton1);
            this.tabPage1.ImageKey = "icons8-home-page-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1295, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(11, 72);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(190, 37);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "materialRadioButton1";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage8);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageListhome;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1303, 633);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.ImageKey = "icons8-user-account-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1295, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.01299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.98701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridstudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.swchactive, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addstudentButton1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.4589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.5411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 584);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(8, 0);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 29);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Students";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel2.UseAccent = true;
            this.materialLabel2.UseMnemonic = false;
            // 
            // dataGridstudent
            // 
            this.dataGridstudent.AllowUserToAddRows = false;
            this.dataGridstudent.AllowUserToOrderColumns = true;
            this.dataGridstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridstudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridstudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridstudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridstudent, 3);
            this.dataGridstudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridstudent.Location = new System.Drawing.Point(3, 139);
            this.dataGridstudent.Name = "dataGridstudent";
            this.dataGridstudent.ReadOnly = true;
            this.dataGridstudent.RowHeadersWidth = 62;
            this.dataGridstudent.RowTemplate.Height = 28;
            this.dataGridstudent.Size = new System.Drawing.Size(1283, 442);
            this.dataGridstudent.TabIndex = 9;
            this.dataGridstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridstudent_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::DBLabProjectMID.Properties.Resources.icons8_edit_16;
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 43;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::DBLabProjectMID.Properties.Resources.icons8_delete_32;
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 62;
            // 
            // swchactive
            // 
            this.swchactive.AutoSize = true;
            this.swchactive.BackColor = System.Drawing.Color.White;
            this.swchactive.Depth = 0;
            this.swchactive.ForeColor = System.Drawing.Color.Transparent;
            this.swchactive.Location = new System.Drawing.Point(254, 0);
            this.swchactive.Margin = new System.Windows.Forms.Padding(0);
            this.swchactive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swchactive.MouseState = MaterialSkin.MouseState.HOVER;
            this.swchactive.Name = "swchactive";
            this.swchactive.Ripple = true;
            this.swchactive.Size = new System.Drawing.Size(137, 37);
            this.swchactive.TabIndex = 8;
            this.swchactive.Text = "Active Only";
            this.swchactive.UseVisualStyleBackColor = true;
            this.swchactive.CheckedChanged += new System.EventHandler(this.swchactive_CheckedChanged);
            // 
            // addstudentButton1
            // 
            this.addstudentButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addstudentButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addstudentButton1.Depth = 0;
            this.addstudentButton1.HighEmphasis = true;
            this.addstudentButton1.Icon = global::DBLabProjectMID.Properties.Resources.icons8_plus_32;
            this.addstudentButton1.Image = global::DBLabProjectMID.Properties.Resources.icons8_plus_32;
            this.addstudentButton1.Location = new System.Drawing.Point(945, 6);
            this.addstudentButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addstudentButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.addstudentButton1.Name = "addstudentButton1";
            this.addstudentButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addstudentButton1.Size = new System.Drawing.Size(147, 36);
            this.addstudentButton1.TabIndex = 10;
            this.addstudentButton1.Text = "Add Student";
            this.addstudentButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addstudentButton1.UseAccentColor = false;
            this.addstudentButton1.UseVisualStyleBackColor = true;
            this.addstudentButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.ImageKey = "icons8-attendance-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1295, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Attendance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.023758F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.37365F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.62162F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.023166F));
            this.tableLayoutPanel3.Controls.Add(this.attendancelbl, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.addnewattendancebtn, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewaddendance, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEdit, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.046036F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32566F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32566F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32566F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32566F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1295, 590);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // attendancelbl
            // 
            this.attendancelbl.AutoSize = true;
            this.attendancelbl.BackColor = System.Drawing.Color.White;
            this.attendancelbl.Depth = 0;
            this.attendancelbl.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.attendancelbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.attendancelbl.Location = new System.Drawing.Point(43, 17);
            this.attendancelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attendancelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.attendancelbl.Name = "attendancelbl";
            this.attendancelbl.Size = new System.Drawing.Size(104, 24);
            this.attendancelbl.TabIndex = 1;
            this.attendancelbl.Text = "Attendance";
            this.attendancelbl.UseAccent = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(358, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // addnewattendancebtn
            // 
            this.addnewattendancebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addnewattendancebtn.BackColor = System.Drawing.Color.White;
            this.addnewattendancebtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addnewattendancebtn.Depth = 0;
            this.addnewattendancebtn.HighEmphasis = true;
            this.addnewattendancebtn.Icon = global::DBLabProjectMID.Properties.Resources.icons8_plus_32;
            this.addnewattendancebtn.Location = new System.Drawing.Point(45, 312);
            this.addnewattendancebtn.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.addnewattendancebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addnewattendancebtn.Name = "addnewattendancebtn";
            this.addnewattendancebtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addnewattendancebtn.Size = new System.Drawing.Size(180, 36);
            this.addnewattendancebtn.TabIndex = 12;
            this.addnewattendancebtn.Text = "New Attendance";
            this.addnewattendancebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addnewattendancebtn.UseAccentColor = false;
            this.addnewattendancebtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewaddendance
            // 
            this.dataGridViewaddendance.AllowUserToAddRows = false;
            this.dataGridViewaddendance.AllowUserToOrderColumns = true;
            this.dataGridViewaddendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewaddendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewaddendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewaddendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridViewaddendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewaddendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edits,
            this.Deletes});
            this.dataGridViewaddendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewaddendance.Location = new System.Drawing.Point(422, 20);
            this.dataGridViewaddendance.Name = "dataGridViewaddendance";
            this.dataGridViewaddendance.RowHeadersWidth = 62;
            this.tableLayoutPanel3.SetRowSpan(this.dataGridViewaddendance, 4);
            this.dataGridViewaddendance.RowTemplate.Height = 28;
            this.dataGridViewaddendance.Size = new System.Drawing.Size(791, 567);
            this.dataGridViewaddendance.TabIndex = 14;
            this.dataGridViewaddendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewaddendance_CellContentClick);
            // 
            // Edits
            // 
            this.Edits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edits.HeaderText = "Edit";
            this.Edits.Image = global::DBLabProjectMID.Properties.Resources.icons8_edit_16;
            this.Edits.MinimumWidth = 8;
            this.Edits.Name = "Edits";
            this.Edits.Width = 43;
            // 
            // Deletes
            // 
            this.Deletes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Deletes.HeaderText = "Delete";
            this.Deletes.MinimumWidth = 8;
            this.Deletes.Name = "Deletes";
            this.Deletes.Width = 62;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(349, 455);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(64, 36);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "icons8-active-directory-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1295, 590);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CLOs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ImageKey = "icons8-edit-property-32.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1295, 590);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Rubric";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel2);
            this.tabPage6.ImageKey = "icons8-pass-fail-32.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1295, 590);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Assessment";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.586592F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.41341F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Controls.Add(this.attnameLabel1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.92929F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.07071F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1295, 590);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // attnameLabel1
            // 
            this.attnameLabel1.AutoSize = true;
            this.attnameLabel1.BackColor = System.Drawing.Color.White;
            this.attnameLabel1.Depth = 0;
            this.attnameLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.attnameLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.attnameLabel1.Location = new System.Drawing.Point(16, 4);
            this.attnameLabel1.Margin = new System.Windows.Forms.Padding(8, 4, 8, 0);
            this.attnameLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.attnameLabel1.Name = "attnameLabel1";
            this.attnameLabel1.Size = new System.Drawing.Size(104, 24);
            this.attnameLabel1.TabIndex = 0;
            this.attnameLabel1.Text = "Attendance";
            this.attnameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attnameLabel1.UseAccent = true;
            // 
            // tabPage7
            // 
            this.tabPage7.ImageKey = "icons8-no-connection-32.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1295, 590);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Assessment Component";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.ImageKey = "icons8-certificate-32.png";
            this.tabPage8.Location = new System.Drawing.Point(4, 39);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1295, 590);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Evaluation";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // imageListhome
            // 
            this.imageListhome.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListhome.ImageStream")));
            this.imageListhome.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListhome.Images.SetKeyName(0, "icons8-active-directory-32.png");
            this.imageListhome.Images.SetKeyName(1, "icons8-attendance-32.png");
            this.imageListhome.Images.SetKeyName(2, "icons8-certificate-32.png");
            this.imageListhome.Images.SetKeyName(3, "icons8-edit-property-32.png");
            this.imageListhome.Images.SetKeyName(4, "icons8-home-page-32.png");
            this.imageListhome.Images.SetKeyName(5, "icons8-no-connection-32.png");
            this.imageListhome.Images.SetKeyName(6, "icons8-pass-fail-32.png");
            this.imageListhome.Images.SetKeyName(7, "icons8-user-account-32.png");
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::DBLabProjectMID.Properties.Resources.icons8_edit_16;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::DBLabProjectMID.Properties.Resources.icons8_delete_32;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // Form321
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form321";
            this.Text = "Evaluation System";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstudent)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaddendance)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ImageList imageListhome;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch swchactive;
        private System.Windows.Forms.DataGridView dataGridstudent;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MaterialSkin.Controls.MaterialButton addstudentButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel attnameLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel attendancelbl;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton addnewattendancebtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewaddendance;
        private System.Windows.Forms.DataGridViewImageColumn Edits;
        private System.Windows.Forms.DataGridViewImageColumn Deletes;
    }
}