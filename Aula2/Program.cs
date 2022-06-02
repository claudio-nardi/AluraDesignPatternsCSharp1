using System;

namespace Aula02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var calculador = new CalculadorDeDescontos();

			Orcamento orcamento = new Orcamento(1000);
			orcamento.Itens.Add(new Item("Caneta", 522));
			orcamento.Itens.Add(new Item("Bike", 3000));
			orcamento.Itens.Add(new Item("Caneca", 100));
			orcamento.Itens.Add(new Item("Caneta", 522));
			orcamento.Itens.Add(new Item("Bike", 3000));
			orcamento.Itens.Add(new Item("Caneca", 100));
			orcamento.Itens.Add(new Item("Caneta", 522));
			orcamento.Itens.Add(new Item("Caneta", 522));

			Console.WriteLine(calculador.Calcula(orcamento));
		}
	}
}
