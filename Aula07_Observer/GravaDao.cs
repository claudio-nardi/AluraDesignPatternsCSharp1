using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Observer
{
	public class GravaDao : IAcoesAposEmissaoNf
	{
		public void ExecutaAcao(NotaFiscal nf)
		{
			Console.WriteLine("Gravou no BD");
		}
	}
}
