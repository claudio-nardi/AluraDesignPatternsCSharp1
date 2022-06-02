using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Investimentos
{
	public interface IInvestimento
	{
		public double calcula(Orcamento orcamento);
	}
}
