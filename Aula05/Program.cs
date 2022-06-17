using System;

namespace Aula05
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

			Console.WriteLine(orcamento.Valor);
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			Console.WriteLine(orcamento.Valor);
			orcamento.Aprova();
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			orcamento.AplicaDescontoExtra();
			Console.WriteLine(orcamento.Valor);

		}
	}
}
