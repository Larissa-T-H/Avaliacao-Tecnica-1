using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Funcionario
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public double QtdVendas { get; set; }
        public double VendasTotal { get; set; }

        public Funcionario(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return "Id: " + Id.ToString("000") + "- Funcionario: " + Nome.ToString() ;
        }
        public double Comissao()
        {

            if (QtdVendas >0 && QtdVendas <= 5) {

                return VendasTotal * 0.004;
            }
            else if (QtdVendas >5 && QtdVendas <= 10) {

                return VendasTotal * 0.013;
            }
            else if (QtdVendas >10 && QtdVendas <= 15) {

                return VendasTotal * 0.3;
            }
            else {
                return VendasTotal * 0.5;
            }
        }
        public static List<Funcionario> InitializeFuncionario()
        {
            List<Funcionario> lista = new List<Funcionario>();

            lista.Add(new Funcionario(01, "Larissa"));
            lista.Add(new Funcionario(02, "Leticia"));

            return lista;
        }
    }
    
}

