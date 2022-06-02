using System;

namespace Aula02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var calculador = new CalculadorDeDescontos();

			Orcamento orcamento = new Orcamento();
			orcamento.AdicionaItem(new Item("Caneta", 522));
			orcamento.AdicionaItem(new Item("Bike", 3000));
			orcamento.AdicionaItem(new Item("Caneca", 100));
			orcamento.AdicionaItem(new Item("Caneta", 522));
			orcamento.AdicionaItem(new Item("Bike", 3000));
			orcamento.AdicionaItem(new Item("Caneca", 100));
			orcamento.AdicionaItem(new Item("Caneta", 522));
			orcamento.AdicionaItem(new Item("Caneta", 522));

			Console.WriteLine(orcamento.Valor);
			Console.WriteLine(calculador.Calcula(orcamento));
		}
	}
}
