using System;

namespace Aula02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var calculador = new CalculadorDeDescontos();

			Orcamento orcamento = new Orcamento();
			orcamento.AdicionaItem(new Item("Caneta", 50));
			orcamento.AdicionaItem(new Item("Bike", 30));
			orcamento.AdicionaItem(new Item("Caneta", 10));
			orcamento.AdicionaItem(new Item("Bike", 30));
			orcamento.AdicionaItem(new Item("Lapis", 100));


			Console.WriteLine(orcamento.Valor);
			Console.WriteLine(calculador.Calcula(orcamento));
		}
	}
}
