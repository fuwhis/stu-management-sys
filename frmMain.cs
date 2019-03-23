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
            frmAdd.Text = "Add Form";
            this.Close();
            frmAdd.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            List<SinhVien> list = new List<SinhVien>();
            BindingSource bs = new BindingSource();
            try
            {
                list = SinhVienDAO.ListAllStudent();
                if (list != null)
                {
                    // Show data 
                    bs.DataSource = list;
                    dgvManager.DataSource = bs;
                    dgvManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvManager.AllowUserToResizeColumns = false;

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
            frmAdd_Update frmAdd = new frmAdd_Update();
            frmAdd.Text = "Update Form";
            this.Close();
            frmAdd.ShowDialog();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection rows = dgvManager.SelectedRows;
                foreach (DataGridViewRow row in rows)
                {
                    SinhVienDAO.RemoveStudent(row.Cells[0].Value.ToString());
                }
                MetroFramework.MetroMessageBox.Show(this, "Remove Successed.", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Update datasource after remove
                dgvManager.DataSource = SinhVienDAO.ListAllStudent();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get current index of cell
                int index = dgvManager.CurrentRow.Index;

                txtMaSV.Text = dgvManager.Rows[index].Cells[0].Value.ToString();

                txtHo.Text = dgvManager.Rows[index].Cells[1].Value.ToString();
                txtTen.Text = dgvManager.Rows[index].Cells[2].Value.ToString();
                txtNgaySinh.Text = dgvManager.Rows[index].Cells[3].Value.ToString();
                if (dgvManager.Rows[index].Cells[4].Value.Equals(true))
                {
                    txtGioiTinh.Text = "Male";
                }
                else if (dgvManager.Rows[index].Cells[4].Value.Equals(false))
                {
                    txtGioiTinh.Text = "Female";
                }

                txtMaKhoa.Text = dgvManager.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void dgvManager_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DataGridViewRow dgvRow = new DataGridViewRow();
            ////Boolean boolValue = (Boolean)e.Value;
            //DataGridViewCheckBoxCell boolValue = dgvRow.Cells[4] as DataGridViewCheckBoxCell;

            //if (Convert.ToString(boolValue.Value).Equals(1))
            //{
            //    //e.Value.Equals("Male");
            //    e.CellStyle.Format = "Male";
            //}
            //else if(Convert.ToBoolean(boolValue.Value) == false)
            //{
            //    e.CellStyle.Format = "Female";
            //}
        }
    }
}
