using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamrinAttribute
{
    public partial class frmdgv : Form
    {
        DrManager _drmanager;
        public frmdgv()
        {
            InitializeComponent();
            _drmanager = new DrManager();
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            var frmadd= new frmAdd();
            this.Hide();
            frmadd.Show();
            frmadd.FormClosing += Frmadd_FormClosing;
            FillDgv();

        }

        private void Frmadd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        public void FillDgv()
        {
            dgvDoctor.DataSource = _drmanager.Select();
        }

        private void frmdgv_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
    }
}
