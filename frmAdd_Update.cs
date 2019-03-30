using PRN292_Group1_QLSvien.Models.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Group1_QLSvien
{
    public partial class frmAdd_Update : MetroFramework.Forms.MetroForm
    {
        public frmAdd_Update()
        {
            InitializeComponent();
        }

        frmMain MainForm = new frmMain();
        Boolean GioiTinh;

        private void mrdFemale_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = false;
        }

        private void mrdMale_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check null
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter MaSV first!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            bool result = true;

            if (!SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                // ADD 
                
                try
                {
                    result = SinhVienDAO.InsertStudent(txtMaSV.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(),
                        dtNgaySinh.Value.Date, GioiTinh, txtMaKhoa.Text.Trim());

                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else if (SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                // UPDATE 
                try
                {
                    result = SinhVienDAO.UpdateInfo(txtMaSV.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(),
                    dtNgaySinh.Value.Date, GioiTinh, txtMaKhoa.Text.Trim());
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            if (result)
            {
                // update thành công
                MetroFramework.MetroMessageBox.Show(this, "Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.ShowDialog();
        }

        private void btnCheckStudentExist_Click(object sender, EventArgs e)
        {
            if (SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Student has already existed. Please input new Student!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Student has not already existed.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
