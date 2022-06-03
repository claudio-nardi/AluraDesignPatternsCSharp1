using System;

namespace ExercicioAula02
{
	public enum Formato
	{
		XML,
		CSV,
		PORCENTO
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			var conta = new Conta("Claudio Nardi",111790.00);
			var requisicao = new Requisicao(Formato.XML);
			var textoFormato = new Formatar();
			Console.WriteLine(textoFormato.TextoFormatado(requisicao, conta));
			requisicao.Formato = Formato.CSV;
			Console.WriteLine(textoFormato.TextoFormatado(requisicao, conta));
			requisicao.Formato = Formato.PORCENTO;
			Console.WriteLine(textoFormato.TextoFormatado(requisicao, conta));
		}
	}
}
