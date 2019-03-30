namespace PRN292_Group1_QLSvien
{
    partial class frmAdd_Update
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
        public void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mrdFemale = new MetroFramework.Controls.MetroRadioButton();
            this.dtNgaySinh = new MetroFramework.Controls.MetroDateTime();
            this.mrdMale = new MetroFramework.Controls.MetroRadioButton();
            this.txtMaKhoa = new MetroFramework.Controls.MetroTextBox();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.txtHo = new MetroFramework.Controls.MetroTextBox();
            this.txtMaSV = new MetroFramework.Controls.MetroTextBox();
            this.lbGioiTinh = new MetroFramework.Controls.MetroLabel();
            this.lbMaKhoa = new MetroFramework.Controls.MetroLabel();
            this.lbTen = new MetroFramework.Controls.MetroLabel();
            this.lbNgaySinh = new MetroFramework.Controls.MetroLabel();
            this.lbMaSV = new MetroFramework.Controls.MetroLabel();
            this.lbHo = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnCheckStudentExist = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mrdFemale);
            this.metroPanel1.Controls.Add(this.dtNgaySinh);
            this.metroPanel1.Controls.Add(this.mrdMale);
            this.metroPanel1.Controls.Add(this.txtMaKhoa);
            this.metroPanel1.Controls.Add(this.txtTen);
            this.metroPanel1.Controls.Add(this.txtHo);
            this.metroPanel1.Controls.Add(this.txtMaSV);
            this.metroPanel1.Controls.Add(this.lbGioiTinh);
            this.metroPanel1.Controls.Add(this.lbMaKhoa);
            this.metroPanel1.Controls.Add(this.lbTen);
            this.metroPanel1.Controls.Add(this.lbNgaySinh);
            this.metroPanel1.Controls.Add(this.lbMaSV);
            this.metroPanel1.Controls.Add(this.lbHo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(21, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(338, 244);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mrdFemale
            // 
            this.mrdFemale.AutoSize = true;
            this.mrdFemale.Location = new System.Drawing.Point(228, 176);
            this.mrdFemale.Name = "mrdFemale";
            this.mrdFemale.Size = new System.Drawing.Size(61, 15);
            this.mrdFemale.TabIndex = 15;
            this.mrdFemale.Text = "Female";
            this.mrdFemale.UseSelectable = true;
            this.mrdFemale.CheckedChanged += new System.EventHandler(this.mrdFemale_CheckedChanged);
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(101, 135);
            this.dtNgaySinh.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(216, 29);
            this.dtNgaySinh.TabIndex = 12;
            // 
            // mrdMale
            // 
            this.mrdMale.AutoSize = true;
            this.mrdMale.Checked = true;
            this.mrdMale.Location = new System.Drawing.Point(112, 176);
            this.mrdMale.Name = "mrdMale";
            this.mrdMale.Size = new System.Drawing.Size(49, 15);
            this.mrdMale.TabIndex = 14;
            this.mrdMale.TabStop = true;
            this.mrdMale.Text = "Male";
            this.mrdMale.UseSelectable = true;
            this.mrdMale.CheckedChanged += new System.EventHandler(this.mrdMale_CheckedChanged);
            // 
            // txtMaKhoa
            // 
            // 
            // 
            // 
            this.txtMaKhoa.CustomButton.Image = null;
            this.txtMaKhoa.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtMaKhoa.CustomButton.Name = "";
            this.txtMaKhoa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaKhoa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaKhoa.CustomButton.TabIndex = 1;
            this.txtMaKhoa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaKhoa.CustomButton.UseSelectable = true;
            this.txtMaKhoa.CustomButton.Visible = false;
            this.txtMaKhoa.Lines = new string[0];
            this.txtMaKhoa.Location = new System.Drawing.Point(101, 209);
            this.txtMaKhoa.MaxLength = 32767;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.PasswordChar = '\0';
            this.txtMaKhoa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaKhoa.SelectedText = "";
            this.txtMaKhoa.SelectionLength = 0;
            this.txtMaKhoa.SelectionStart = 0;
            this.txtMaKhoa.ShortcutsEnabled = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(216, 23);
            this.txtMaKhoa.TabIndex = 11;
            this.txtMaKhoa.UseSelectable = true;
            this.txtMaKhoa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaKhoa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(101, 98);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(216, 23);
            this.txtTen.TabIndex = 8;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHo
            // 
            // 
            // 
            // 
            this.txtHo.CustomButton.Image = null;
            this.txtHo.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtHo.CustomButton.Name = "";
            this.txtHo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHo.CustomButton.TabIndex = 1;
            this.txtHo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHo.CustomButton.UseSelectable = true;
            this.txtHo.CustomButton.Visible = false;
            this.txtHo.Lines = new string[0];
            this.txtHo.Location = new System.Drawing.Point(101, 56);
            this.txtHo.MaxLength = 32767;
            this.txtHo.Name = "txtHo";
            this.txtHo.PasswordChar = '\0';
            this.txtHo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHo.SelectedText = "";
            this.txtHo.SelectionLength = 0;
            this.txtHo.SelectionStart = 0;
            this.txtHo.ShortcutsEnabled = true;
            this.txtHo.Size = new System.Drawing.Size(216, 23);
            this.txtHo.TabIndex = 7;
            this.txtHo.UseSelectable = true;
            this.txtHo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaSV
            // 
            // 
            // 
            // 
            this.txtMaSV.CustomButton.Image = null;
            this.txtMaSV.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtMaSV.CustomButton.Name = "";
            this.txtMaSV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaSV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaSV.CustomButton.TabIndex = 1;
            this.txtMaSV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaSV.CustomButton.UseSelectable = true;
            this.txtMaSV.CustomButton.Visible = false;
            this.txtMaSV.Lines = new string[0];
            this.txtMaSV.Location = new System.Drawing.Point(101, 14);
            this.txtMaSV.MaxLength = 32767;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.PasswordChar = '\0';
            this.txtMaSV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaSV.SelectedText = "";
            this.txtMaSV.SelectionLength = 0;
            this.txtMaSV.SelectionStart = 0;
            this.txtMaSV.ShortcutsEnabled = true;
            this.txtMaSV.Size = new System.Drawing.Size(216, 23);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.UseSelectable = true;
            this.txtMaSV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaSV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(13, 172);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(51, 19);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Genre: ";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Location = new System.Drawing.Point(11, 209);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(57, 19);
            this.lbMaKhoa.TabIndex = 5;
            this.lbMaKhoa.Text = "TermID: ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(11, 102);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(67, 19);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Lastname:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(11, 135);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(91, 19);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Date of birth: ";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(13, 16);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(68, 19);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "StudentID:";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(13, 56);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(69, 19);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "Firstname:";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(127, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "OK";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.Location = new System.Drawing.Point(254, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckStudentExist
            // 
            this.btnCheckStudentExist.ActiveControl = null;
            this.btnCheckStudentExist.Location = new System.Drawing.Point(21, 326);
            this.btnCheckStudentExist.Name = "btnCheckStudentExist";
            this.btnCheckStudentExist.Size = new System.Drawing.Size(105, 45);
            this.btnCheckStudentExist.TabIndex = 14;
            this.btnCheckStudentExist.Text = "Check";
            this.btnCheckStudentExist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckStudentExist.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCheckStudentExist.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCheckStudentExist.UseSelectable = true;
            this.btnCheckStudentExist.Click += new System.EventHandler(this.btnCheckStudentExist_Click);
            // 
            // frmAdd_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 382);
            this.Controls.Add(this.btnCheckStudentExist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd_Update";
            this.Text = "Update Form";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroTextBox txtMaKhoa;
        public MetroFramework.Controls.MetroTextBox txtTen;
        public MetroFramework.Controls.MetroTextBox txtHo;
        public MetroFramework.Controls.MetroTextBox txtMaSV;
        private MetroFramework.Controls.MetroLabel lbGioiTinh;
        private MetroFramework.Controls.MetroLabel lbMaKhoa;
        private MetroFramework.Controls.MetroLabel lbTen;
        private MetroFramework.Controls.MetroLabel lbNgaySinh;
        private MetroFramework.Controls.MetroLabel lbMaSV;
        private MetroFramework.Controls.MetroLabel lbHo;
        public MetroFramework.Controls.MetroRadioButton mrdMale;
        public MetroFramework.Controls.MetroDateTime dtNgaySinh;
        public MetroFramework.Controls.MetroRadioButton mrdFemale;
        public MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnCancel;
        public MetroFramework.Controls.MetroTile btnCheckStudentExist;
    }
}