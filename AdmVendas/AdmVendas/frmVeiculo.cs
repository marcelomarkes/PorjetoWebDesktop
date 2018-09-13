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
    public partial class frmVeiculo : MetroFramework.Forms.MetroForm
    {
        public frmVeiculo()
        {
            InitializeComponent();
        }

        bool primeiravez = true;

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            CarregarCor();
            CarregarMarca();
            LimparCampos();
            primeiravez = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                VeiculoDAO dao = new VeiculoDAO();
                tb_veiculo veiculo = new tb_veiculo();

                veiculo.abs_veiculo = ckbFreio.Checked;
                veiculo.airbag_veiculo = Convert.ToInt16(cmbAirBag.SelectedIndex);
                veiculo.anofab_veiculo = Convert.ToInt16(txtAnoFab.Text);
                veiculo.ano_veiculo = Convert.ToInt16(txtAnoCarro.Text);
                veiculo.ar_veiculo = ckbAr.Checked;
                veiculo.compra_veiculo = Convert.ToDecimal(txtValorCompra.Text);
                veiculo.data_veiculo = DateTime.Now;
                veiculo.direcao_veiculo = Convert.ToInt16(cmbDirecao.SelectedValue);
                veiculo.id_cor = Convert.ToInt32(cmbCor.SelectedValue);
                veiculo.id_empresa = Util.CodigoLogado;
                veiculo.id_modelo = Convert.ToInt32(cmbModelo.SelectedValue);
                veiculo.km_veiculo = txtKM.Text;
                veiculo.obs_veiculo = txtObservacao.Text.Trim();
                veiculo.placa_veiculo = txtPlaca.Text;
                veiculo.porta_veiculo = Convert.ToInt16(cmbNPorta.SelectedIndex);
                veiculo.situacao_veiculo = Convert.ToInt16(cmbSituacao.SelectedIndex);
                veiculo.venda_veiculo = Convert.ToDecimal(txtValorVenda.Text);

                try
                {
                    if (txtCodigo.Text == "")
                    {
                        dao.InserirVeiculo(veiculo);
                    }
                    else
                    {
                        veiculo.id_veiculo = Convert.ToInt16(txtCodigo.Text);
                        dao.AlterarVeiculo(veiculo);
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
            if(ValidarPesquisa())
            { 
            PesquisaVeiculo();
            }
        }
        private bool ValidarPesquisa()
        {
            bool ret = true;

            if(cmbStiPesquisa.SelectedIndex == -1)
            {
                Util.ExibircamposObrig("Situação do Veículo");
                ret = false;
            }
            return ret;
        }

        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVeiculos.RowCount > 0)
            {
                VeiculoVO veiculo = (VeiculoVO)dgvVeiculos.CurrentRow.DataBoundItem;

                txtPlaca.Text = veiculo.Placa;
                cmbMarca.SelectedValue = veiculo.CodigoMarca;
                cmbModelo.SelectedValue = veiculo.CodigoModelo;
                txtAnoFab.Text = veiculo.AnoFab.ToString();
                txtAnoCarro.Text = veiculo.AnoCarro.ToString();
                txtKM.Text = veiculo.KM;
                cmbCor.SelectedValue = veiculo.CodigoCor;
                cmbNPorta.SelectedIndex = veiculo.NPorta;
                cmbDirecao.SelectedIndex = veiculo.Direcao;
                cmbAirBag.SelectedIndex = veiculo.AirBag;
                cmbSituacao.SelectedIndex = veiculo.Situacao;
                ckbAr.Checked = veiculo.Ar;
                ckbFreio.Checked = veiculo.Freio;
                txtValorCompra.Text = veiculo.ValorCompra.ToString();
                txtValorVenda.Text = veiculo.ValorVenda.ToString();
                txtObservacao.Text = veiculo.Observacao;
                txtCodigo.Text = veiculo.CodigoVeiculo.ToString();
            }
        }

        private void PesquisaVeiculo()
        {
            VeiculoDAO dao = new VeiculoDAO();
            List<VeiculoVO> lst = dao.ConsultarVeiculo(Util.CodigoLogado, cmbStiPesquisa.SelectedIndex);

            if (lst.Count > 0)
            {
                dgvVeiculos.DataSource = lst;

                dgvVeiculos.Columns["CodigoVeiculo"].Visible = false;
                dgvVeiculos.Columns["CodigoModelo"].Visible = false;
                dgvVeiculos.Columns["CodigoCor"].Visible = false;
                dgvVeiculos.Columns["CodigoMarca"].Visible = false;
                dgvVeiculos.Columns["Cor"].Visible = false;
                dgvVeiculos.Columns["AnoFab"].Visible = false;
                dgvVeiculos.Columns["AnoCarro"].Visible = false;
                dgvVeiculos.Columns["KM"].Visible = false;
                dgvVeiculos.Columns["NPorta"].Visible = false;
                dgvVeiculos.Columns["Direcao"].Visible = false;
                dgvVeiculos.Columns["AirBag"].Visible = false;
                dgvVeiculos.Columns["Situacao"].Visible = false;
                dgvVeiculos.Columns["Ar"].Visible = false;
                dgvVeiculos.Columns["Freio"].Visible = false;
                dgvVeiculos.Columns["ValorCompra"].Visible = false;
                dgvVeiculos.Columns["ValorVenda"].Visible = false;
                dgvVeiculos.Columns["Observacao"].Visible = false;
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.NaoEncontrado);
            }
        }
        private void LimparCampos()
        {
            txtAnoCarro.Clear();
            txtAnoFab.Clear();
            txtCodigo.Clear();
            txtKM.Clear();
            txtObservacao.Clear();
            txtPlaca.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            cmbAirBag.SelectedIndex = -1;
            cmbCor.SelectedIndex = -1;
            cmbDirecao.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbModelo.DataSource = null;
            cmbModelo.DisplayMember = "nome_modelo";
            cmbModelo.ValueMember = "id_modelo";
            cmbNPorta.SelectedIndex = -1;
            cmbSituacao.SelectedIndex = -1;
            cmbSituacao.SelectedIndex = -1;
            ckbAr.Checked = false;
            ckbFreio.Checked = false;
            dgvVeiculos.DataSource = null;
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            String Campos = "";

            if (txtAnoCarro.Text.Trim() == "")
            {
                ret = false;
                Campos += "- Ano do Carro\n";
            }
            if (txtAnoFab.Text.Trim() == "")
            {
                ret = false;
                Campos += "- Ano de Fábricação\n";
            }
            if (txtKM.Text.Trim() == "")
            {
                ret = false;
                Campos += "- KM do Veículo\n";
            }
            if (txtPlaca.Text.Trim() == "")
            {
                ret = false;
                Campos += "- Placa do Veículo\n";
            }
            if (txtValorCompra.Text.Trim() == "")
            {
                ret = false;
                Campos += "- Valor de Compra\n";
            }
            if (txtValorVenda.Text.Trim() == "")
            {
                ret = false;
                Campos += "- Valor de Venda\n";
            }
            if (cmbCor.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- Cor do Veículo\n";
            }
            if (cmbDirecao.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- Tipo de Direção do Veículo\n";
            }
            if (cmbMarca.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- Marca do Veículo\n";
            }
            if (cmbModelo.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- Modelo do Veículo\n";
            }
            if (cmbNPorta.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- Número de Portas do Veículo\n";
            }
            if (cmbSituacao.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- Situação do Veículo\n";
            }
            if (cmbAirBag.SelectedIndex == -1)
            {
                ret = false;
                Campos += "- AirBag do Veículo\n";
            }
            if(!ret)
            {
                Util.ExibircamposObrig(Campos);
            }
            return ret;
        }
        private void CarregarCor()
        {
            CorDAO dao = new CorDAO();
            cmbCor.DataSource = dao.ConsultarCor(Util.CodigoLogado);
        }
        private void CarregarMarca()
        {
            MarcaDAO dao = new MarcaDAO();
            cmbMarca.DataSource = dao.ConsultarMarcas(Util.CodigoLogado);
        }
        private void CarregarModelo(int CodMarca)
        {
            ModeloDAO dao = new ModeloDAO();
            cmbModelo.DataSource = dao.FiltrarModelo(CodMarca);

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMarca.SelectedIndex > -1 && !primeiravez)
            {
                CarregarModelo(Convert.ToInt32(cmbMarca.SelectedValue));
            }
        }
    }
}
