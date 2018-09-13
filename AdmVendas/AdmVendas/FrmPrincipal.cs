using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmVendas
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.ShowDialog();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            frmModelo frm = new frmModelo();
            frm.ShowDialog();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            frmCor frm = new frmCor();
            frm.ShowDialog();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculo frm = new frmVeiculo();
            frm.ShowDialog();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMarcaModelo frm = new frmMarcaModelo();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
