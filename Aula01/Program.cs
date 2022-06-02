using Aula01.Investimentos;
using System;

namespace Aula01
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var orcamento = new Orcamento(1000);
			var icms = new Icms();
			var iss = new Iss();
			var iccc = new ICCC();

			Console.WriteLine($"Orcamento: {orcamento.Valor}");
			new CalculadoraDeImpostos(orcamento, icms);
			Console.WriteLine($"ICMS: {icms.Calcula(orcamento)}");
			new CalculadoraDeImpostos(orcamento, iss);
			Console.WriteLine($"ISS: {iss.Calcula(orcamento)}");
			new CalculadoraDeImpostos(orcamento, iccc);
			Console.WriteLine($"ICCC: {iccc.Calcula(orcamento)}");

			var conservador = new Conservador();
			var moderado = new Moderado();
			var arrojado = new Arrojado();

			Console.WriteLine("Conservador: " + conservador.calcula(orcamento));
			Console.WriteLine("Moderado: " + moderado.calcula(orcamento));
			Console.WriteLine("Arrojado: " + arrojado.calcula(orcamento));

		}
	}
}
