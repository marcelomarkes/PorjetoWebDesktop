using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class VeiculoVO
    {
        public int CodigoVeiculo { get; set; }
        public int CodigoModelo { get; set; }
        public int CodigoCor { get; set; }
        public int CodigoMarca { get; set; }
        public String Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoFab { get; set; }
        public int AnoCarro { get; set; }
        public String KM { get; set; }
        public int NPorta { get; set; }
        public int Direcao { get; set; }
        public int AirBag { get; set; }
        public int Situacao { get; set; }
        public bool Ar { get; set; }
        public bool Freio { get; set; }
        public Decimal ValorCompra { get; set; }
        public Decimal ValorVenda { get; set; }
        public String Observacao { get; set; }
    }
}
