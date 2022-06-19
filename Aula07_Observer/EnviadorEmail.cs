using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Observer
{
	public class EnviadorEmail : IAcoesAposEmissaoNf
	{
		public void ExecutaAcao(NotaFiscal nf)
		{
			Console.WriteLine("Enviou por e-mail");
		}
	}
}
