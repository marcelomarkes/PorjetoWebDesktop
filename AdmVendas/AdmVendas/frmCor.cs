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
    public partial class frmCor : MetroFramework.Forms.MetroForm
    {
        public frmCor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                CorDAO dao = new CorDAO();
                tb_cor cor = new tb_cor();

                cor.id_empresa = Util.CodigoLogado;
                cor.nome_cor = txtNome.Text.Trim();

                try
                {
                    if(txtCodigo.Text == "")
                    {
                        dao.InserirCor(cor);
                    }
                    else
                    {
                        cor.id_cor = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarCor(cor);
                    }
                    LimparCampos();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarCor();
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

     
        private void frmCor_Load(object sender, EventArgs e)
        {
            CarregarCor();
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            btnSalvar.Text = "Nova Cor";
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            String campos = "";

            if(txtNome.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome";
            }
            if(!ret)
            {
                Util.ExibircamposObrig(campos);
            }
            return ret;
        }
        private void CarregarCor()
        {
            CorDAO dao = new CorDAO();
            List<tb_cor> lst = dao.ConsultarCor(Util.CodigoLogado);

            if(lst.Count > 0)
            {
                gdCor.DataSource = lst;

                gdCor.Columns["id_cor"].Visible = false;
                gdCor.Columns["id_empresa"].Visible = false;
                gdCor.Columns["tb_empresa"].Visible = false;
                gdCor.Columns["tb_veiculo"].Visible = false;

                gdCor.Columns["nome_cor"].HeaderText = "Nome da Cor";
            }
        }

        private void gdCor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdCor.RowCount > 0)
            {
                btnSalvar.Text = "Alterar Cor";

                tb_cor linhaobj = (tb_cor)gdCor.CurrentRow.DataBoundItem;

                txtCodigo.Text = Convert.ToString(linhaobj.id_cor);
                txtNome.Text = linhaobj.nome_cor;
            }

        }
    }
}
