using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("213123213");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("524523423");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("234342543");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("4566356345");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("98767676");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
