using System;

namespace Aula04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var orcamento = new Orcamento();
			orcamento.AdicionaItem(new Item("Caneta", 50));
			orcamento.AdicionaItem(new Item("Bike", 30));
			orcamento.AdicionaItem(new Item("Caneta1", 890));
			orcamento.AdicionaItem(new Item("Bike1", 30));

			Imposto iss = new ImpostoMuitoAlto(new Iss());

			Console.WriteLine(iss.Calcula(orcamento));


			//var orcamento = new Orcamento();
			//var icpp = new ICPP();
			//var ikcv = new IKCV();
			//var ihit = new IHIT();

			//orcamento.AdicionaItem(new Item("Caneta", 50));
			//orcamento.AdicionaItem(new Item("Bike", 30));
			//orcamento.AdicionaItem(new Item("Caneta1", 890));
			//orcamento.AdicionaItem(new Item("Bike1", 30));

			//Console.WriteLine(orcamento.Valor);

			//Console.Write("ICPP->");
			//new CalculadoraDeImpostos(orcamento, icpp);
			//Console.Write("IKCV->");
			//new CalculadoraDeImpostos(orcamento, ikcv);
			//Console.Write("IHIT->");
			//new CalculadoraDeImpostos(orcamento, ihit);
		}
	}
}
