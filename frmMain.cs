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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            frmAdd_Update frmAdd = new frmAdd_Update();
            this.Hide();
            frmAdd.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            List<SinhVien> list = new List<SinhVien>();
            try
            {
                list = SinhVienDAO.ListAllStudent();
                if (list != null)
                {
                    // Show data 
                    dgvManager.DataSource = list;
                    // Thay đổi hiển thị cột giới tính

                }
                else if (list == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Source is empty.", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvManager.CurrentRow.Index;

            this.txtMaSV.Text = dgvManager.Rows[index].Cells[0].Value.ToString();
            this.txtHo.Text = dgvManager.Rows[index].Cells[1].Value.ToString();
            this.txtTen.Text = dgvManager.Rows[index].Cells[2].Value.ToString();
            this.txtNgaySinh.Text = dgvManager.Rows[index].Cells[3].Value.ToString();
            //this.txtGioiTinh.Text = (string)dgvManager.Rows[index].Cells[4].Value; // Hiển thị True/False
            if (dgvManager.Rows[index].Cells[4].Value.Equals(true))
            {
                this.txtGioiTinh.Text = "Male";
            }
            else if (dgvManager.Rows[index].Cells[4].Value.Equals(false))
            {
                this.txtGioiTinh.Text = "Female";
            }

            this.txtMaKhoa.Text = dgvManager.Rows[index].Cells[5].Value.ToString();
        }
    }
}
