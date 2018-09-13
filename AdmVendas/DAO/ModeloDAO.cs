
using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ModeloDAO
    {
        public void InserirModelo(tb_modelo objmodelo)
        {
            banco objbanco = new banco();
            objbanco.AddTotb_modelo(objmodelo);
            objbanco.SaveChanges();

        }
        public void AlterarModelo(tb_modelo objmodelo)
        {
            banco objbanco = new banco();

            tb_modelo objResgate = objbanco.tb_modelo.FirstOrDefault(p => p.id_modelo == objmodelo.id_modelo);

            objResgate.nome_modelo = objmodelo.nome_modelo;
            objResgate.id_marca = objmodelo.id_marca;

            objbanco.SaveChanges();
        }
        public List<ModeloVO> ConsultarModelo(int codLogado)
        {
            banco objbanco = new banco();

            List<ModeloVO> ListaRetorno = new List<ModeloVO>();

            List<tb_modelo> ListaConsulta = objbanco.tb_modelo.Include("tb_marca").Where(p => p.id_empresa == codLogado).ToList();

            for (int i = 0; i < ListaConsulta.Count; i++)
            {
                ModeloVO vo = new ModeloVO();

                vo.CodigoMarca = ListaConsulta[i].id_marca;
                vo.CodigoModelo = ListaConsulta[i].id_modelo;
                vo.NomeModelo = ListaConsulta[i].nome_modelo;
                vo.NomeMarca = ListaConsulta[i].tb_marca.nome_marca;

                ListaRetorno.Add(vo);
            }

            return ListaRetorno;
        }
        public List<tb_modelo> FiltrarModelo(int CodMarca)
        {
            banco ObjBanco = new banco();
            List<tb_modelo> lst = ObjBanco.tb_modelo.Where(p => p.id_marca == CodMarca).ToList();
            return lst;
        }

    }
}
