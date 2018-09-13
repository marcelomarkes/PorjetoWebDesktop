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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private bool ValidarCampos()
        {
            bool ret = true;
            String Campos = "";

            if(txtCnpj.Text.Trim() == "")
            {
                ret = false;
                Campos += "- CNPJ\n";
            }
            if(txtSenha.Text.Trim() == "")
            {
                ret = false;
                Campos += "- Senha\n";
            }
            if(!ret)
            {
                Util.ExibircamposObrig(Campos);
            }
            return ret;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                UsuarioDAO dao = new UsuarioDAO();

                tb_empresa ObjEmpresa = dao.ValidarLogin(txtCnpj.Text.Trim(), txtSenha.Text.Trim());

                if(ObjEmpresa != null)
                {
                    Util.CodigoLogado = ObjEmpresa.id_empresa;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Util.ExibirMsg(Util.TipoMsg.UsuarioNaoEncontrado);
                }
            }
        }
    }
}
