using DAO;
using DAO.VO;
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
    public partial class frmModelo : MetroFramework.Forms.MetroForm
    {
        public frmModelo()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limparcampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ModeloDAO dao = new ModeloDAO();
                tb_modelo objModelo = new tb_modelo();

                objModelo.id_empresa = Util.CodigoLogado;
                objModelo.id_marca = Convert.ToInt32(cmbMarca.SelectedValue);
                objModelo.nome_modelo = txtNome.Text.Trim();

                try
                {
                    if(txtCodigo.Text == "")
                    {
                        dao.InserirModelo(objModelo);
                    }
                    else
                    {
                        objModelo.id_modelo = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarModelo(objModelo);
                    }
                    ConsultarModelo();
                    Limparcampos();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                }
                catch 
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }


            private void Limparcampos()
            {
                txtCodigo.Clear();
                txtNome.Clear();
                cmbMarca.SelectedIndex = -1;
            }
            private bool ValidarCampos()
            {
                bool ret = true;
                string campos = "";

                if (cmbMarca.SelectedIndex == -1)
                {
                    ret = false;
                    campos += "- Marca\n";
                }
                if (txtNome.Text.Trim() == "")
                {
                    ret = false;
                    campos += "- Modelo\n";
                }
                if (!ret)
                {
                    Util.ExibircamposObrig(campos);
                }
                return ret;
            }

            private void frmModelo_Load(object sender, EventArgs e)
            {
                
                CarregarMarcas();
                Limparcampos();
            }
            private void ConsultarModelo()
        {
            ModeloDAO dao = new ModeloDAO();
            List<ModeloVO> ListaModelo = dao.ConsultarModelo(Util.CodigoLogado);
            if(ListaModelo.Count > 0)
            {
                grdModelos.DataSource = ListaModelo;

                grdModelos.Columns["CodigoMarca"].Visible = false;
                grdModelos.Columns["CodigoModelo"].Visible = false;

                grdModelos.Columns["NomeMarca"].HeaderText = "Marca";
                grdModelos.Columns["NomeModelo"].HeaderText = "Modelo";
            }

        }
            private void CarregarMarcas()
            {
                MarcaDAO dao = new MarcaDAO();
                List<tb_marca> ListaMarca = dao.ConsultarMarcas(Util.CodigoLogado);
                cmbMarca.DataSource = ListaMarca;

               
        }



            private void grdModelos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (grdModelos.RowCount > 0)
                {
                    btnSalvar.Text = "Alterar Modelo";

                    ModeloVO objtlinha = (ModeloVO)grdModelos.CurrentRow.DataBoundItem;
                    txtCodigo.Text = Convert.ToString(objtlinha.CodigoModelo);
                    txtNome.Text = objtlinha.NomeModelo;
                    cmbMarca.SelectedValue = objtlinha.CodigoMarca;
                }
            }
        }
    }
