using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CorDAO
    {
        public void InserirCor(tb_cor objcor)
        {
            banco objbanco = new banco();
            objbanco.AddTotb_cor(objcor);
            objbanco.SaveChanges();
        }
        public List<tb_cor> ConsultarCor(int CodLogado)
        {
            banco objbanco = new banco();
            List<tb_cor> lst = objbanco.tb_cor.Where(p => p.id_empresa == CodLogado).ToList();

            return lst;
        }
        public void AlterarCor(tb_cor objcor)
        {
            banco objbanco = new banco();
            tb_cor objresgate = objbanco.tb_cor.FirstOrDefault(p => p.id_cor == objcor.id_cor);

            objresgate.nome_cor = objcor.nome_cor;

            objbanco.SaveChanges();
        }
    }
}
