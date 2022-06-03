using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	public class DescontoAcimaDeQuinhentos : IDesconto
	{
		public IDesconto ProximoDesconto { get; set; }

		public DescontoAcimaDeQuinhentos(IDesconto proximoDesconto)
		{
			ProximoDesconto = proximoDesconto;
		}

		public DescontoAcimaDeQuinhentos()
		{
		}

		public double Desconta(Orcamento orcamento)
		{
			if (orcamento.Valor > 500)
			{
				return orcamento.Valor * 0.07;
			}

			// Interrompe cadeia não havendo mais descontos
			if (ProximoDesconto == null)
			{
				return 0;
			}

			return ProximoDesconto.Desconta(orcamento);
		}
	}
}
