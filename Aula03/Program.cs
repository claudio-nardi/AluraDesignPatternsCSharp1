using System;

namespace Aula03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var orcamento = new Orcamento();
			var icpp = new ICPP();
			var ikcv = new IKCV();
			
			orcamento.AdicionaItem(new Item("Caneta", 50));
			orcamento.AdicionaItem(new Item("Bike", 30));
			orcamento.AdicionaItem(new Item("Caneta", 890));
			orcamento.AdicionaItem(new Item("Bike", 30));
			//orcamento.AdicionaItem(new Item("Lapis", 100));


			Console.WriteLine(orcamento.Valor);
			//Console.WriteLine(calculador.Calcula(orcamento)); 

			Console.Write("ICPP->");
			new CalculadoraDeImpostos(orcamento, icpp);
			Console.Write("IKCV->");
			new CalculadoraDeImpostos(orcamento, ikcv);
			//Console.WriteLine($"ICCC: {iccc.Calcula(orcamento)}");

			//var conservador = new Conservador();
			//var moderado = new Moderado();
			//var arrojado = new Arrojado();

			//Console.WriteLine("Conservador: " + conservador.calcula(orcamento));
			//Console.WriteLine("Moderado: " + moderado.calcula(orcamento));
			//Console.WriteLine("Arrojado: " + arrojado.calcula(orcamento));
		}
	}
}
