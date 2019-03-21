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

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save updated data
        }
    }
}
