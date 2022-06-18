using System;
using System.Collections.Generic;

namespace ExercicioAula06

{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			var itemBuilder = new ItemBuilder();
			
			NotaFiscal nf = new NFBuilder().
					ParaEmpresa("Caelum Ensino e Inovação").
					ComCnpj("123.456.789-0001/10").
					ComItem(itemBuilder.
							SetDescricao("item 1").
							SetValor(100).
							ConstroiItem()).
					ComItem(itemBuilder.
							SetDescricao("item 2").
							SetValor(200).
							ConstroiItem()).
					ComItem(itemBuilder.
							SetDescricao("item 3").
							SetValor(300).
							ConstroiItem()).
					NaDataAtual().
					ComObs("Entregar na rua pessoa").
					constroiNF();
			Console.WriteLine(nf.ValorTotal);
			Console.WriteLine(nf.Impostos);
		}
	}
}
