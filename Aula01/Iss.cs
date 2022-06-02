using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
	public class Iss : IImposto
	{
		private const double aliquota = 0.06;

		public double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * aliquota;
		}
	}
}
