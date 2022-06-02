using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	public class DescontoMaisDe5Itens : IDesconto
	{
		public IDesconto ProximoDesconto { get ; set; }

		public DescontoMaisDe5Itens(IDesconto proximoDesconto)
		{
			ProximoDesconto = proximoDesconto;
		}

		public DescontoMaisDe5Itens()
		{
		}

		public double Desconta(Orcamento orcamento)
		{
			if (orcamento.Itens.Count > 5)
			{
				return orcamento.Valor * 0.10;
			}
			return ProximoDesconto.Desconta(orcamento);
		}
	}
}
