using System;
using System.Collections.Generic;

namespace ExercicioAula05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var conta1 = new Conta(1000);
			var deposita = new Conta.Positivo();
			Console.WriteLine("Saldo: " + conta1.Saldo);
			conta1.Saca(1100);
			Console.WriteLine("Após saque de 1100: " + conta1.Saldo);
			conta1.Deposita( 1000);
			Console.WriteLine("Após deposito de 1000: " + conta1.Saldo);
			conta1.Deposita(153.0612244898);
			Console.WriteLine("Após deposito de 153: " + conta1.Saldo);
			Console.WriteLine("Saldo: " + conta1.Saldo);
			conta1.Saca(999.99);
			Console.WriteLine("Saldo: " + conta1.Saldo);
			conta1.Deposita(1000);
			Console.WriteLine("Após deposito de 1000: " + conta1.Saldo);
			conta1.Saca(1100);
			Console.WriteLine("Após saque de 1100: " + conta1.Saldo);
			//conta1.Saca(1100);

			deposita.Deposita(conta1, 1000000);
			Console.WriteLine("Após saque de 1100: " + conta1.Saldo);

		}
	}
}
