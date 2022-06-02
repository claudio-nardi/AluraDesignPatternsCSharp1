using System;

namespace Aula01
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var orcamento = new Orcamento(5000);
			var icms = new Icms();
			var iss = new Iss();

			Console.WriteLine($"Orcamento: {orcamento.Valor}");
			Console.WriteLine($"ICMS: {icms.Calcula(orcamento)}");
			Console.WriteLine($"ISS: {iss.Calcula(orcamento)}");

		}
	}
}
