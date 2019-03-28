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

        List<SinhVien> list = new List<SinhVien>();
        BindingSource bs = new BindingSource();

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

        private void btnShow_Click(object sender, EventArgs e)
        {
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

        public void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_Update frmAdd = new frmAdd_Update();
            frmAdd.Text = "Add Form";
            frmAdd.btnSave.Text = "Add";
            frmAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAdd_Update formEdit = new frmAdd_Update();
            formEdit.Text = "Update Form";
            formEdit.btnSave.Text = "Update";
            formEdit.btnCheckStudentExist.Hide();
            formEdit.txtMaSV.ReadOnly = true;

            // Get current index of cell
            int index = dgvManager.CurrentRow.Index;
            // Data Binding to frmAdd_Update
            formEdit.txtMaSV.Text = dgvManager.Rows[index].Cells[0].Value.ToString();
            formEdit.txtHo.Text = dgvManager.Rows[index].Cells[1].Value.ToString();
            formEdit.txtTen.Text = dgvManager.Rows[index].Cells[2].Value.ToString();
            formEdit.dtNgaySinh.Text = dgvManager.Rows[index].Cells[3].Value.ToString();
            if (dgvManager.Rows[index].Cells[4].Value.Equals(true))
            {
                formEdit.mrdMale.Checked = true;
                formEdit.mrdFemale.Checked = false;

            }
            else if (dgvManager.Rows[index].Cells[4].Value.Equals(false))
            {
                formEdit.mrdFemale.Checked = true;
                formEdit.mrdMale.Checked = false;
            }
            formEdit.txtMaKhoa.Text = dgvManager.Rows[index].Cells[5].Value.ToString();

            formEdit.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
