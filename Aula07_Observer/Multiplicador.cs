using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Observer
{
	public class Multiplicador : IAcoesAposEmissaoNf
	{
		public Multiplicador(double fator)
		{
			Fator = fator;
		}

		public double Fator { get; private set; }	

		public void ExecutaAcao(NotaFiscal nf)
		{
			Console.WriteLine("Multiplicado: " + nf.ValorTotal*Fator);
		}
	}
}
