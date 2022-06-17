using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula05
{
	public class Conta
	{

		public double Saldo { get; private set; }
		public IEstadoDaConta Estado { get; set; }
		public Conta(double saldo)
		{
			Saldo = saldo;
			if (saldo > 0)
			{
				this.Estado = new Positivo();
			}
			else
			{
				this.Estado = new Negativo();
			}
		}

		public void Saca(double valor)
		{
			this.Estado.Saca(this, valor);
		}

		public void Deposita(double valor)
		{
			this.Estado.Deposita(this, valor);
		}
		public class Negativo : IEstadoDaConta
		{
			public void Deposita(Conta conta, double valor)
			{
				conta.Saldo += valor * 0.95;
				if (conta.Saldo >= 0) conta.Estado = new Positivo();
			}

			public void Saca(Conta conta, double valor)
			{
				throw new Exception("Conta com saldo negativo, impossível sacar");
			}
		}

		public class Positivo : IEstadoDaConta
		{
			public void Deposita(Conta conta, double valor)
			{
				conta.Saldo += valor * 0.98;
			}

			public void Saca(Conta conta, double valor)
			{
				conta.Saldo -= valor;
				if (conta.Saldo < 0) conta.Estado = new Negativo();
			}
		}

	}
}
