using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Investimentos
{
	public class Arrojado : IInvestimento
	{
		public double calcula(Orcamento orcamento)
		{
			double rendimento = 1.006;
			var fatorRetorno = new Random().Next(10);

			if (fatorRetorno > 7)
			{
				rendimento = 1.05;
			} else if (fatorRetorno > 4)
			{
				rendimento = 1.03;
			}
			return orcamento.Valor * rendimento; ;
		}
	}
}
