using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AcompanhaVendaDAO
    {
        public List<AcompanhaVendaVO> AcompanhaVendas(int codVendedor, DateTime dtIncial, DateTime dtFinal)
        {
            banco ObjBanco = new banco();
            List < AcompanhaVendaVO> ListaRetorno = new List<AcompanhaVendaVO>();

            List<tb_venda> ListaConsulta = ObjBanco.tb_venda.Include("tb_cliente")
                .Include("tb_cliente.tb_modelo.tb_marca").Where(p => p.id_vendedor == codVendedor &&
                p.data_venda >= dtIncial && p.data_venda >= dtFinal).ToList();

            for (int i = 0; i < ListaConsulta.Count; i++)
            {
                AcompanhaVendaVO vo = new AcompanhaVendaVO();

                vo.Cliente = ListaConsulta[i].tb_cliente.nome_cliente;
                vo.Data = ListaConsulta[i].data_venda.ToShortDateString();
                vo.Marca = ListaConsulta[i].tb_veiculo.tb_modelo.tb_marca.nome_marca;
                vo.Modelo = ListaConsulta[i].tb_veiculo.tb_modelo.nome_modelo;
                vo.Valor = ListaConsulta[i].tb_veiculo.venda_veiculo;

                ListaRetorno.Add(vo);

            }
            return ListaRetorno;
        }
    }
}
