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

			Imposto icpp = new ICPP();
			Console.WriteLine("ICPP: "+icpp.Calcula(orcamento));
			Imposto ikcv = new IKCV();
			Console.WriteLine("IKCV: "+ikcv.Calcula(orcamento));

			Imposto iss = new Iss(new Icms());
			Console.WriteLine(iss.Calcula(orcamento));
			Imposto imposto2 = new ICPP(new IKCV());

			Console.WriteLine(imposto2.Calcula(orcamento));
						
		}
	}
}
