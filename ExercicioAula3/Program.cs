using System;
using System.Collections.Generic;

namespace ExercicioAula3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var listaContas = new List<Conta>();
			string titular;
			double centavos;
			var relatorioSimples = new ImprimeRelatorioSimples();
			var relatorioCompleto = new ImprimeRelatorioCompleto();

			for (int i = 0; i < 20; i++)
			{
				listaContas.Add(new Conta());
				titular = "";
				
				for (int x = 0; x < 15; x++)
				{
					titular += Convert.ToString(Convert.ToChar(i + 65));
					
				}

				listaContas[i].Titular = titular;
				listaContas[i].Numero = new Random().Next(10000);
				listaContas[i].Agencia = new Random().Next(1000);
				listaContas[i].Saldo = new Random().Next(100000);
				centavos = new Random().Next(100);
				centavos /= 100;
				listaContas[i].Saldo += centavos;

			}

			relatorioSimples.Imprime(listaContas);
			relatorioCompleto.Imprime(listaContas);

		}
	}
}
