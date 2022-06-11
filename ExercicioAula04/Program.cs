using System;
using System.Collections.Generic;

namespace ExercicioAula04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Cria lista de contas
			IList<Conta> listaContas = new List<Conta>();
			var contaAtual = new Conta();

			for (int i = 0; i < 20; i++)
			{
				listaContas.Add(new Conta());
				listaContas[i].Id = i + 1;
				listaContas[i].Mes = (short)new Random().Next(12);
				listaContas[i].Saldo = new Random().Next(700);
				if (listaContas[i].Saldo > 650) listaContas[i].Saldo *= 100000;
				Console.WriteLine(listaContas[i].Id + " " + listaContas[i].Mes + " " + listaContas[i].Saldo);
			}
			#endregion
			List<Conta> listaContasAlvo = new List<Conta>();
			
			var filtro = new SaldoMenor100(new SaldoMaior500K(new ContaDesteMes()));

			listaContasAlvo = (List<Conta>)filtro.Filtra(listaContas);

			Console.WriteLine("");

			foreach (var conta in listaContasAlvo)
			{
				Console.WriteLine(conta.Id + " " + conta.Mes + " " + conta.Saldo);

			}

		}
	}
}
