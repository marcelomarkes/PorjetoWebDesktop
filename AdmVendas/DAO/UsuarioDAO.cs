using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {
        public tb_empresa ValidarLogin(string cnpj, string senha)
        {
            banco ObjBanco = new banco();

            tb_empresa ObjEmpresa = ObjBanco.tb_empresa
                .FirstOrDefault(p => p.cnpj_empresa == cnpj && p.senha_empresa == senha);

            return ObjEmpresa;
        }
    }
}
