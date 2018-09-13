using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeiculoDAO
    {
        public void InserirVeiculo(tb_veiculo ObjVeiculo)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_veiculo(ObjVeiculo);
            ObjBanco.SaveChanges();
        }
        public void AlterarVeiculo(tb_veiculo ObjVeiculo)
        {
            banco ObjBanco = new banco();
            tb_veiculo ObjResgate = ObjBanco.tb_veiculo.FirstOrDefault(p => p.id_veiculo == ObjVeiculo.id_veiculo);

            ObjResgate.placa_veiculo = ObjVeiculo.placa_veiculo;
            ObjResgate.anofab_veiculo = ObjVeiculo.anofab_veiculo;
            ObjResgate.ano_veiculo = ObjVeiculo.ano_veiculo;
            ObjResgate.km_veiculo = ObjVeiculo.km_veiculo;
            ObjResgate.porta_veiculo = ObjVeiculo.porta_veiculo;
            ObjResgate.airbag_veiculo = ObjVeiculo.airbag_veiculo;
            ObjResgate.direcao_veiculo = ObjVeiculo.direcao_veiculo;
            ObjResgate.situacao_veiculo = ObjVeiculo.situacao_veiculo;
            ObjResgate.ar_veiculo = ObjVeiculo.ar_veiculo;
            ObjResgate.abs_veiculo = ObjVeiculo.abs_veiculo;
            ObjResgate.venda_veiculo = ObjVeiculo.venda_veiculo;
            ObjResgate.compra_veiculo = ObjVeiculo.compra_veiculo;
            ObjResgate.obs_veiculo = ObjVeiculo.obs_veiculo;
            ObjResgate.id_modelo = ObjVeiculo.id_modelo;
            ObjResgate.id_cor = ObjVeiculo.id_cor;


            ObjBanco.SaveChanges();
        }
        public List<VeiculoVO> ConsultarVeiculo(int CodLogado, int Situacao)
        {
            banco ObjBanco = new banco();
            List<VeiculoVO> lstRetorno = new List<VeiculoVO>();
            List<tb_veiculo> lst = ObjBanco.tb_veiculo
                .Include("tb_cor")
                .Include("tb_modelo").Include("tb_modelo.tb_marca")
                .Where(p => p.id_empresa == CodLogado && p.situacao_veiculo == Situacao).ToList();

            for (int i = 0; i < lst.Count; i++)
            {
                VeiculoVO vo = new VeiculoVO();

                vo.AirBag = lst[i].airbag_veiculo;
                vo.AnoCarro = lst[i].airbag_veiculo;
                vo.AnoFab = lst[i].anofab_veiculo;
                vo.Ar = lst[i].ar_veiculo;
                vo.CodigoCor = lst[i].id_cor;
                vo.CodigoMarca = lst[i].tb_modelo.tb_marca.id_marca;
                vo.CodigoModelo = lst[i].id_modelo;
                vo.CodigoVeiculo = lst[i].id_veiculo;
                vo.Cor = lst[i].tb_cor.nome_cor;
                vo.Direcao = lst[i].direcao_veiculo;
                vo.Freio = lst[i].abs_veiculo;
                vo.KM = lst[i].km_veiculo;
                vo.Marca = lst[i].tb_modelo.tb_marca.nome_marca;
                vo.Modelo = lst[i].tb_modelo.nome_modelo;
                vo.NPorta = lst[i].porta_veiculo;
                vo.Observacao = lst[i].obs_veiculo;
                vo.Placa = lst[i].placa_veiculo;
                vo.Situacao = lst[i].situacao_veiculo;
                vo.ValorCompra = lst[i].compra_veiculo;
                vo.ValorVenda = lst[i].venda_veiculo;

                lstRetorno.Add(vo);
            }

            return lstRetorno;
        }
       
    }
}
