using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmVendas
{
    public static class Util
    {
            public static int CodigoLogado;
            public enum TipoMsg
            {
                Sucesso,
                Erro,
                CampoObrigatorio,
                NaoEncontrado,
                VendedorNaoSelecionado,
                UsuarioNaoEncontrado
            }
            public static void ExibirMsg(TipoMsg tipo)
            {
                if (tipo.ToString() == TipoMsg.Sucesso.ToString())
                {
                    MessageBox.Show(Mensagens.MsgSucesso, Mensagens.TitleSucesso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tipo.ToString() == TipoMsg.Erro.ToString())
                {
                    MessageBox.Show(Mensagens.MsgErro, Mensagens.TitleErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(tipo.ToString() == TipoMsg.NaoEncontrado.ToString())
                {
                    MessageBox.Show(Mensagens.MsgNaoEncontrado, Mensagens.TitleResultado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tipo.ToString() == TipoMsg.VendedorNaoSelecionado.ToString())
                {
                    MessageBox.Show(Mensagens.MsgSelecaoVendedor, Mensagens.TitleAtencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tipo.ToString() == TipoMsg.UsuarioNaoEncontrado.ToString())
                {
                    MessageBox.Show(Mensagens.MsgUsuarioNaoEncontrado, Mensagens.TitleAtencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            public static void ExibircamposObrig(String campos)
            {
                MessageBox.Show(Mensagens.MsgCampoObrigatorio + campos, Mensagens.TitleAtencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    }
}
