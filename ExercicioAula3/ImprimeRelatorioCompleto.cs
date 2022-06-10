using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3
{
	public class ImprimeRelatorioCompleto : TemplateRelatorio
	{
		public override void imprimeCabecalho()
		{
			Console.WriteLine("Banco Bradesco SA");
			Console.WriteLine("Cidade de Deus s/n - Osasco - SP");
			Console.WriteLine("Telefone: 4545-4545\n");
		}

		public override void imprimeCorpo(List<Conta> contas)
		{
			Console.WriteLine("Titular         Ag  Num  Saldo");
			foreach (var conta in contas)
			{
				Console.WriteLine(conta.Titular + " " + conta.Agencia + " " + conta.Numero +  " " + conta.Saldo);
			};
		}

		public override void imprimeRodape()
		{
			Console.WriteLine("\ne-mail: atendimento@bradesco.com.br");
			Console.WriteLine();
			Console.WriteLine(DateTime.Now);
		}
	}
}
