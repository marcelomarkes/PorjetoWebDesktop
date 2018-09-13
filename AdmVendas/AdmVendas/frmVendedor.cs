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
    public partial class FrmVendedor : MetroFramework.Forms.MetroForm
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                  LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                VendedorDAO dao = new VendedorDAO();
                tb_vendedor vendedor = new tb_vendedor();

                vendedor.id_empresa = Util.CodigoLogado;
                vendedor.nome_vendedor = txtNome.Text.Trim();
                vendedor.email_vendedor = txtEmail.Text.Trim();
                vendedor.data_vendedor = DateTime.Now;
                vendedor.endereco_vendedor = txtEndereco.Text.Trim();
                vendedor.tel_vendedor = txtCelular.Text.Trim();
                vendedor.senha_vendedor = txtSenha.Text.Trim();
                vendedor.status_vendedor = ckbSim.Checked;


                try
                {
                    if (txtCodigo.Text == "")
                    {
                        dao.InserirVendedor(vendedor);
                    }
                    else
                    {
                        vendedor.id_vendedor = Convert.ToInt32(txtCodigo.Text);
                        dao.AlterarVendedor(vendedor);
                    }
                    LimparCampos();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VendedorDAO dao = new VendedorDAO();
            List<tb_vendedor> ListaVendedor = dao.FiltrarVendedor(Util.CodigoLogado, txtNome.Text);

            if (ListaVendedor.Count > 0)
            {
                dgvConsultaResultado.DataSource = ListaVendedor;
                dgvConsultaResultado.Columns["id_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["email_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["tel_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["endereco_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["senha_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["status_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["data_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["id_empresa"].Visible = false;
                dgvConsultaResultado.Columns["tb_empresa"].Visible = false;
                dgvConsultaResultado.Columns["tb_venda"].Visible = false;
                dgvConsultaResultado.Columns["tb_cliente"].Visible = false;

                dgvConsultaResultado.Columns["nome_Vendedor"].HeaderText = "Nome da Vendedor";
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.NaoEncontrado);
            }

        }
        private void LimparCampos()
        {
            dgvConsultaResultado.DataSource = null;
            txtCodigo.Clear();
            txtNome.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtSenha.Clear();
            btnSalvar.Text = "Nova Vendedor";
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            String campos = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome";
            }
            if(txtEndereco.Text.Trim() == "")
            {
                ret = false;
                campos += "- Endereço\n";
            }
            if (txtCelular.Text.Trim() == "")
            {
                ret = false;
                campos += "- Celular\n";
            }
            if(txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos = "- E-mail\n";
            }
            if(txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += "- Senha\n";
            }
            if (!ret)
            {
                Util.ExibircamposObrig(campos);
            }
            return ret;
        }
        private void CarregarVendedor()
        {
            VendedorDAO dao = new VendedorDAO();
            List<tb_vendedor> lst = dao.ConsultarVendedor(Util.CodigoLogado);

            if (lst.Count > 0)
            {
                dgvConsultaResultado.DataSource = lst;

                dgvConsultaResultado.Columns["id_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["email_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["tel_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["endereco_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["senha_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["status_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["data_Vendedor"].Visible = false;
                dgvConsultaResultado.Columns["id_empresa"].Visible = false;
                dgvConsultaResultado.Columns["tb_empresa"].Visible = false;
                dgvConsultaResultado.Columns["tb_venda"].Visible = false;
                dgvConsultaResultado.Columns["tb_cliente"].Visible = false;


                dgvConsultaResultado.Columns["nome_Vendedor"].HeaderText = "Nome da Vendedor";
            }
        }

        
        private void dgvConsultaResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaResultado.RowCount > 0)
            {
                btnSalvar.Text = "Alterar Vendedor";

                tb_vendedor linhaobj = (tb_vendedor)dgvConsultaResultado.CurrentRow.DataBoundItem;

                txtCodigo.Text = Convert.ToString(linhaobj.id_vendedor);
                txtNome.Text = linhaobj.nome_vendedor;
                txtEmail.Text = linhaobj.email_vendedor;
                txtEndereco.Text = linhaobj.endereco_vendedor;
                txtCelular.Text = linhaobj.tel_vendedor;
                txtSenha.Text = linhaobj.senha_vendedor;
                ckbSim.Checked = linhaobj.status_vendedor;
            }
        }
    }

}
