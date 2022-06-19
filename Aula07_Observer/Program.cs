using System;
using System.Collections.Generic;

namespace Aula07_Observer
{
	internal class Program
	{
		static void Main(string[] args)
		{

			NotaFiscal nf = new NFBuilder().ParaEmpresa("Caelum Ensino e Inovação").
					ComCnpj("123.456.789-0001/10").
					ComItem(new ItemDaNota("item 1", 100)).
					ComItem(new ItemDaNota("item 2", 200)).
					ComItem(new ItemDaNota("item 3", 300)).
					NaDataAtual().
					ComObs("Entregar na rua pessoa").
					setAcoes(new EnviadorEmail()).setAcoes(new EnviadorSms()).setAcoes(new GravaDao()).setAcoes(new Multiplicador(100)).
					constroiNF();
					
			Console.WriteLine(nf.Impostos);
			Console.WriteLine(nf.ValorTotal);
		}
	}
}
