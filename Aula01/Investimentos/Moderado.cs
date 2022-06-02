using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Investimentos
{
	public class Moderado : IInvestimento
	{
		public double calcula(Orcamento orcamento)
		{
			double rendimento = 1.007;
			var retornoMaximo = new Random().Next(10) > 4;
			
			if (retornoMaximo)
			{
				rendimento = 1.025;
			}
			return orcamento.Valor * rendimento;
		}
	}
}
