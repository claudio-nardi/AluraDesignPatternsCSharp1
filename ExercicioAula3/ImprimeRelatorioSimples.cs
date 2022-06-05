using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3
{
	public class ImprimeRelatorioSimples : TemplateRelatorio
	{
		public override void imprimeCabecalho()
		{
			Console.WriteLine("Banco Bradesco SA\n");
		}

		public override void imprimeCorpo(List<Conta> contas)
		{
			Console.WriteLine("Titular                   Saldo");
			foreach (var conta in contas)
			{
				Console.WriteLine(conta.Titular + "      " + conta.Saldo);
			};
		}

		public override void imprimeRodape()
		{
			Console.WriteLine("\nTelefone: 4544-4555");

		}
	}
}
