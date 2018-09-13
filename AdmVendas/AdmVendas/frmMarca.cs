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

namespace AdmVendas
{
    public partial class frmMarca : MetroFramework.Forms.MetroForm
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void CarregarMarcas()
        {
            MarcaDAO dao = new MarcaDAO();
            List<tb_marca> lst = dao.ConsultarMarcas(Util.CodigoLogado);
            if (lst.Count > 0)
            {
                gdMarcas.DataSource = lst;
                //Ocultar colunas desejadas
                gdMarcas.Columns["id_Marca"].Visible = false;
                gdMarcas.Columns["id_Empresa"].Visible = false;
                gdMarcas.Columns["tb_Empresa"].Visible = false;
                gdMarcas.Columns["tb_modelo"].Visible = false;

                //Altera o texto do cabeçaçho dda grid
                gdMarcas.Columns["nome_marca"].HeaderText = "Nome da Marca";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MarcaDAO dao = new MarcaDAO();
                tb_marca marca = new tb_marca();

                marca.id_empresa = Util.CodigoLogado;
                marca.nome_marca = txtNome.Text.Trim();

                try
                {
                    // Verifica se existe o codigo caso não haja inserir.
                    if (txtCodigo.Text == "")
                    {
                        dao.InserirMarca(marca);
                    }
                    else
                    {
                        marca.id_marca = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarMarca(marca);
                    }
                    LimparCampo();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarMarcas();
                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            CarregarMarcas();
            LimparCampo();
        }

        private void gdMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdMarcas.RowCount > 0)
            {
                btnSalvar.Text = "Alterar Marca";

                tb_marca linhaobj = (tb_marca)gdMarcas.CurrentRow.DataBoundItem;

                txtCodigo.Text = Convert.ToString(linhaobj.id_marca);
                txtNome.Text = linhaobj.nome_marca;
            }
        }

        private void LimparCampo ()
        {
            txtCodigo.Clear ();
            txtNome.Clear();
            btnSalvar.Text = "Nova Marca";
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos = "- Nome";
            }
            //Verifica se e falso
            if (!ret)
            {
                Util.ExibircamposObrig(campos);
            }

            return ret;
        }

    }
}
