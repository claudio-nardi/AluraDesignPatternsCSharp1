using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	public class DescontoVendaCasada : IDesconto
	{
		public IDesconto ProximoDesconto { get; set ; }

		public double Desconta(Orcamento orcamento)
		{
			bool contemItens;
			contemItens = orcamento.Itens.Exists(x => x.Nome.Equals("Caneta"));
			contemItens = orcamento.Itens.Exists(x => x.Nome.Equals("Lapis"));

			if (contemItens)
			{
				return orcamento.Valor * 0.05;
			}

			return ProximoDesconto.Desconta(orcamento);


		}
	}
}
