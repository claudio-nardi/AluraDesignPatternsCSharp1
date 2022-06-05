using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3
{
	public class Conta
	{
	    static int _proximoNumeroConta = 1;

		public Conta()
		{
			this.Numero = _proximoNumeroConta++;
		}

		public int Numero { get; set; }
		public int Agencia { get; set; }
		public string Titular { get; set; }
		public double Saldo { get; set; }

	}
}
