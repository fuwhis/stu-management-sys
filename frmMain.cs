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
            frmAdd.Show();
        }
    }
}
