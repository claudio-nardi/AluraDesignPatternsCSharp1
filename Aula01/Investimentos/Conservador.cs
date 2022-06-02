using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Investimentos
{
	public class Conservador : IInvestimento
	{
		public double calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 1.008;
		}
	}
}
