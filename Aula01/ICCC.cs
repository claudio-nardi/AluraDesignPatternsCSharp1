using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
	public class ICCC : IImposto
	{
		public double Calcula(Orcamento orcamento)
		{
			if (orcamento.Valor > 3000)
			{
				return orcamento.Valor * 0.08 + 30;
			}
			else if (orcamento.Valor < 1000)
			{
				return orcamento.Valor * 0.05;
			}
			
			return orcamento.Valor * 0.07;
		}
	}
}
