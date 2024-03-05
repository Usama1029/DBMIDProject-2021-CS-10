
namespace DBLabProjectMID
{
    partial class Addstudent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.firstnameLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.firstnameTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.lastnameLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lastnameTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.regnoTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.contactTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.STATUSComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.regnoLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.contactLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.statusLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton2 = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.33735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.66265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.firstnameLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstnameTextBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastnameLabel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastnameTextBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.regnoTextBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.contactTextBox2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmailTextBox3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.STATUSComboBox1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.regnoLabel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.contactLabel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.saveButton1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton2, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.56962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.43038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // firstnameLabel1
            // 
            this.firstnameLabel1.AutoSize = true;
            this.firstnameLabel1.Depth = 0;
            this.firstnameLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstnameLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.firstnameLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.firstnameLabel1.Location = new System.Drawing.Point(76, 5);
            this.firstnameLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstnameLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstnameLabel1.Name = "firstnameLabel1";
            this.firstnameLabel1.Size = new System.Drawing.Size(217, 47);
            this.firstnameLabel1.TabIndex = 0;
            this.firstnameLabel1.Text = "First Name:";
            this.firstnameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstnameTextBox1
            // 
            this.firstnameTextBox1.AnimateReadOnly = true;
            this.firstnameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTextBox1.Depth = 0;
            this.firstnameTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstnameTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstnameTextBox1.Hint = "First Name";
            this.firstnameTextBox1.LeadingIcon = null;
            this.firstnameTextBox1.Location = new System.Drawing.Point(301, 5);
            this.firstnameTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 6);
            this.firstnameTextBox1.MaxLength = 50;
            this.firstnameTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.firstnameTextBox1.Multiline = false;
            this.firstnameTextBox1.Name = "firstnameTextBox1";
            this.firstnameTextBox1.Size = new System.Drawing.Size(455, 50);
            this.firstnameTextBox1.TabIndex = 1;
            this.firstnameTextBox1.Text = "";
            this.firstnameTextBox1.TrailingIcon = null;
            // 
            // lastnameLabel1
            // 
            this.lastnameLabel1.AutoSize = true;
            this.lastnameLabel1.Depth = 0;
            this.lastnameLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastnameLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lastnameLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lastnameLabel1.Location = new System.Drawing.Point(75, 57);
            this.lastnameLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastnameLabel1.Name = "lastnameLabel1";
            this.lastnameLabel1.Size = new System.Drawing.Size(219, 69);
            this.lastnameLabel1.TabIndex = 2;
            this.lastnameLabel1.Text = "Last Name:";
            this.lastnameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastnameTextBox1
            // 
            this.lastnameTextBox1.AnimateReadOnly = false;
            this.lastnameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTextBox1.Depth = 0;
            this.lastnameTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastnameTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastnameTextBox1.Hint = "Last Name";
            this.lastnameTextBox1.LeadingIcon = null;
            this.lastnameTextBox1.Location = new System.Drawing.Point(301, 62);
            this.lastnameTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 6);
            this.lastnameTextBox1.MaxLength = 50;
            this.lastnameTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.lastnameTextBox1.Multiline = false;
            this.lastnameTextBox1.Name = "lastnameTextBox1";
            this.lastnameTextBox1.Size = new System.Drawing.Size(455, 50);
            this.lastnameTextBox1.TabIndex = 3;
            this.lastnameTextBox1.Text = "";
            this.lastnameTextBox1.TrailingIcon = null;
            // 
            // regnoTextBox1
            // 
            this.regnoTextBox1.AnimateReadOnly = false;
            this.regnoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regnoTextBox1.Depth = 0;
            this.regnoTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regnoTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regnoTextBox1.Hint = "Registration Number";
            this.regnoTextBox1.LeadingIcon = null;
            this.regnoTextBox1.Location = new System.Drawing.Point(301, 131);
            this.regnoTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 6);
            this.regnoTextBox1.MaxLength = 50;
            this.regnoTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.regnoTextBox1.Multiline = false;
            this.regnoTextBox1.Name = "regnoTextBox1";
            this.regnoTextBox1.Size = new System.Drawing.Size(455, 50);
            this.regnoTextBox1.TabIndex = 4;
            this.regnoTextBox1.Text = "";
            this.regnoTextBox1.TrailingIcon = null;
            // 
            // contactTextBox2
            // 
            this.contactTextBox2.AnimateReadOnly = false;
            this.contactTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactTextBox2.Depth = 0;
            this.contactTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contactTextBox2.Hint = "Contact Number";
            this.contactTextBox2.LeadingIcon = null;
            this.contactTextBox2.Location = new System.Drawing.Point(302, 195);
            this.contactTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.contactTextBox2.MaxLength = 50;
            this.contactTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.contactTextBox2.Multiline = false;
            this.contactTextBox2.Name = "contactTextBox2";
            this.contactTextBox2.Size = new System.Drawing.Size(453, 50);
            this.contactTextBox2.TabIndex = 5;
            this.contactTextBox2.Text = "";
            this.contactTextBox2.TrailingIcon = null;
            // 
            // EmailTextBox3
            // 
            this.EmailTextBox3.AnimateReadOnly = false;
            this.EmailTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox3.Depth = 0;
            this.EmailTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailTextBox3.Hint = "Email";
            this.EmailTextBox3.LeadingIcon = null;
            this.EmailTextBox3.Location = new System.Drawing.Point(302, 259);
            this.EmailTextBox3.Margin = new System.Windows.Forms.Padding(5);
            this.EmailTextBox3.MaxLength = 50;
            this.EmailTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox3.Multiline = false;
            this.EmailTextBox3.Name = "EmailTextBox3";
            this.EmailTextBox3.Size = new System.Drawing.Size(453, 50);
            this.EmailTextBox3.TabIndex = 6;
            this.EmailTextBox3.Text = "";
            this.EmailTextBox3.TrailingIcon = null;
            // 
            // STATUSComboBox1
            // 
            this.STATUSComboBox1.AutoResize = false;
            this.STATUSComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.STATUSComboBox1.Depth = 0;
            this.STATUSComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STATUSComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.STATUSComboBox1.DropDownHeight = 174;
            this.STATUSComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STATUSComboBox1.DropDownWidth = 121;
            this.STATUSComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.STATUSComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.STATUSComboBox1.FormattingEnabled = true;
            this.STATUSComboBox1.IntegralHeight = false;
            this.STATUSComboBox1.ItemHeight = 43;
            this.STATUSComboBox1.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.STATUSComboBox1.Location = new System.Drawing.Point(300, 330);
            this.STATUSComboBox1.MaxDropDownItems = 4;
            this.STATUSComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.STATUSComboBox1.Name = "STATUSComboBox1";
            this.STATUSComboBox1.Size = new System.Drawing.Size(457, 49);
            this.STATUSComboBox1.StartIndex = 0;
            this.STATUSComboBox1.TabIndex = 7;
            // 
            // regnoLabel1
            // 
            this.regnoLabel1.AutoSize = true;
            this.regnoLabel1.Depth = 0;
            this.regnoLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regnoLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.regnoLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.regnoLabel1.Location = new System.Drawing.Point(75, 126);
            this.regnoLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.regnoLabel1.Name = "regnoLabel1";
            this.regnoLabel1.Size = new System.Drawing.Size(219, 64);
            this.regnoLabel1.TabIndex = 8;
            this.regnoLabel1.Text = "Registration Number:";
            this.regnoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contactLabel2
            // 
            this.contactLabel2.AutoSize = true;
            this.contactLabel2.Depth = 0;
            this.contactLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.contactLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.contactLabel2.Location = new System.Drawing.Point(75, 190);
            this.contactLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactLabel2.Name = "contactLabel2";
            this.contactLabel2.Size = new System.Drawing.Size(219, 64);
            this.contactLabel2.TabIndex = 9;
            this.contactLabel2.Text = "Contact Number:";
            // 
            // emailLabel3
            // 
            this.emailLabel3.AutoSize = true;
            this.emailLabel3.Depth = 0;
            this.emailLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.emailLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.emailLabel3.Location = new System.Drawing.Point(75, 254);
            this.emailLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel3.Name = "emailLabel3";
            this.emailLabel3.Size = new System.Drawing.Size(219, 73);
            this.emailLabel3.TabIndex = 10;
            this.emailLabel3.Text = "Email:";
            this.emailLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel4
            // 
            this.statusLabel4.AutoSize = true;
            this.statusLabel4.Depth = 0;
            this.statusLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.statusLabel4.Location = new System.Drawing.Point(75, 327);
            this.statusLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel4.Name = "statusLabel4";
            this.statusLabel4.Size = new System.Drawing.Size(219, 85);
            this.statusLabel4.TabIndex = 11;
            this.statusLabel4.Text = "Status:";
            this.statusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton1
            // 
            this.saveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton1.Depth = 0;
            this.saveButton1.HighEmphasis = true;
            this.saveButton1.Icon = null;
            this.saveButton1.Location = new System.Drawing.Point(692, 418);
            this.saveButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton1.Size = new System.Drawing.Size(64, 36);
            this.saveButton1.TabIndex = 12;
            this.saveButton1.Text = "Save";
            this.saveButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton1.UseAccentColor = false;
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // cancelButton2
            // 
            this.cancelButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton2.Depth = 0;
            this.cancelButton2.HighEmphasis = true;
            this.cancelButton2.Icon = null;
            this.cancelButton2.Location = new System.Drawing.Point(216, 418);
            this.cancelButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton2.Size = new System.Drawing.Size(77, 36);
            this.cancelButton2.TabIndex = 13;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.cancelButton2.UseAccentColor = false;
            this.cancelButton2.UseVisualStyleBackColor = true;
            this.cancelButton2.Click += new System.EventHandler(this.cancelButton2_Click);
            // 
            // Addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 657);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DrawerShowIconsWhenHidden = true;
            this.Name = "Addstudent";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.Addstudent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel firstnameLabel1;
        private MaterialSkin.Controls.MaterialTextBox firstnameTextBox1;
        private MaterialSkin.Controls.MaterialLabel lastnameLabel1;
        private MaterialSkin.Controls.MaterialTextBox lastnameTextBox1;
        private MaterialSkin.Controls.MaterialTextBox regnoTextBox1;
        private MaterialSkin.Controls.MaterialTextBox contactTextBox2;
        private MaterialSkin.Controls.MaterialTextBox EmailTextBox3;
        private MaterialSkin.Controls.MaterialComboBox STATUSComboBox1;
        private MaterialSkin.Controls.MaterialLabel regnoLabel1;
        private MaterialSkin.Controls.MaterialLabel contactLabel2;
        private MaterialSkin.Controls.MaterialLabel emailLabel3;
        private MaterialSkin.Controls.MaterialLabel statusLabel4;
        private MaterialSkin.Controls.MaterialButton saveButton1;
        private MaterialSkin.Controls.MaterialButton cancelButton2;
    }
}