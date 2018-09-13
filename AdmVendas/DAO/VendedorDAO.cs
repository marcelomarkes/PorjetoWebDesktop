using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VendedorDAO
    {
        public void InserirVendedor(tb_vendedor objvendedor)
        {
            banco objbanco = new banco();
            objbanco.AddTotb_vendedor(objvendedor);
            objbanco.SaveChanges();
        }
        public List<tb_vendedor> ConsultarVendedor(int CodLogado)
        {
            banco objbanco = new banco();
            List<tb_vendedor> lst = objbanco.tb_vendedor.Where(p => p.id_empresa == CodLogado).ToList();

            return lst;
        }
        public void AlterarVendedor(tb_vendedor objvendedor)
        {
            banco objbanco = new banco();
            tb_vendedor objresgate = objbanco.tb_vendedor.FirstOrDefault(p => p.id_vendedor == objvendedor.id_vendedor);

            objresgate.nome_vendedor = objvendedor.nome_vendedor;
            objresgate.email_vendedor = objvendedor.email_vendedor;
            objresgate.endereco_vendedor = objvendedor.endereco_vendedor;
            objresgate.tel_vendedor = objvendedor.tel_vendedor;
            objresgate.senha_vendedor = objvendedor.senha_vendedor;
            objresgate.status_vendedor = objvendedor.status_vendedor;

            objbanco.SaveChanges();
        }
        public List<tb_vendedor> FiltrarVendedor(int codLogado, string nome)
        {
            banco objbanco = new banco();
            List<tb_vendedor> ListaFiltro = new List<tb_vendedor>();

            if (nome.Trim() != "")
            {
                ListaFiltro = objbanco.tb_vendedor.Where(p => p.id_empresa == codLogado && p.nome_vendedor.Contains(nome)).ToList();
            }
            else
            {
                ListaFiltro = objbanco.tb_vendedor.Where(p => p.id_empresa == codLogado).ToList();
            }
            return ListaFiltro.OrderBy(p => p.nome_vendedor).ToList();
        }
    }
}
