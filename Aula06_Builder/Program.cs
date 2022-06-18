using System;
using System.Collections.Generic;

namespace Aula06_Builder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//IList<ItemDaNota> itens = new List<ItemDaNota>();
			//double valorTotal = 0;
			//foreach (ItemDaNota item in itens)
			//{
			//	valorTotal += item.Valor;
			//}
			//double impostos = valorTotal * 0.05;

			//NotaFiscal nf = new NotaFiscal("Razao Social", "123.456.789-0001/10", DateTime.Now, impostos, itens, "observacoes");
			//Console.WriteLine("Hello World!");

			//NFBuilder criador = new NFBuilder();
			//criador.ParaEmpresa("Caelum Ensino e Inovação");
			//criador.ComCnpj("123.456.789-0001/10");
			//criador.ComItem(new ItemDaNota("item 1", 100));
			//criador.ComItem(new ItemDaNota("item 2", 200));
			//criador.ComItem(new ItemDaNota("item 3", 300));
			//criador.NaDataAtual();
			//criador.ComObs("Entregar na rua pessoa");

			//NotaFiscal nf = new criador.ConstroiNF();

			
			NotaFiscal nf = new NFBuilder().ParaEmpresa("Caelum Ensino e Inovação").
					ComCnpj("123.456.789-0001/10").
					ComItem(new ItemDaNota("item 1", 100)).
					ComItem(new ItemDaNota("item 2", 200)).
					ComItem(new ItemDaNota("item 3", 300)).
					NaDataAtual().
					ComObs("Entregar na rua pessoa").constroiNF();
			Console.WriteLine(nf.Impostos);
			Console.WriteLine(nf.ValorTotal);
		}
	}
}
