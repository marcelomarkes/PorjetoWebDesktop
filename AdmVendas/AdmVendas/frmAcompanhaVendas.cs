using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DAO.VO;

namespace AdmVendas
{
    public partial class frmAcompanhaVendas : MetroFramework.Forms.MetroForm
    {
        public frmAcompanhaVendas()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmAcompanhaVendas_Load(object sender, EventArgs e)
        {
            CarreagarVendedor();
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                ConsultarAcompamento();
            }
        }
        #endregion
        #region Metodo
        private void CarreagarVendedor()
        {
            VendedorDAO dao = new VendedorDAO();
            cmbVendedor.DataSource = dao.ConsultarVendedor(Util.CodigoLogado);
        }
        private bool ValidarCampos()
        {
            bool ret = true;

            if(cmbVendedor.SelectedIndex == -1)
            {
                ret = false;
            }
            if(!ret)
            {
                Util.ExibirMsg(Util.TipoMsg.VendedorNaoSelecionado);
            }
            return ret;
        }
        private void ConsultarAcompamento()
        {
            AcompanhaVendaDAO dao = new AcompanhaVendaDAO();
            List<AcompanhaVendaVO> Lista = dao.AcompanhaVendas(Convert.ToInt32(cmbVendedor.SelectedValue), dtInicial.Value, dtFinal.Value);

            if(Lista.Count > 0)
            {
                dgvResultado.DataSource = Lista;
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.NaoEncontrado);
            }
        }
        private void LimparCampos()
        {
            cmbVendedor.SelectedIndex = -1;
        }

        #endregion

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
