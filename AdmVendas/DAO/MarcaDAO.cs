using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MarcaDAO
    {
        public void InserirMarca(tb_marca objMarca)
        {
            banco objbanco = new banco();
            objbanco.AddTotb_marca(objMarca);
            objbanco.SaveChanges();
        }
        public List<tb_marca> ConsultarMarcas(int CodLogado)
        {
            banco objbanco = new banco();
            List<tb_marca> lst = objbanco.tb_marca.Where(p => p.id_empresa == CodLogado).ToList();

            return lst;
        }
        public void AlterarMarca(tb_marca objMarca)
        {
            banco objbanco = new banco();
            tb_marca objResgate = objbanco.tb_marca.FirstOrDefault(p => p.id_marca == objMarca.id_marca);

            objResgate.nome_marca = objMarca.nome_marca;

            objbanco.SaveChanges();
        }
    }
}
