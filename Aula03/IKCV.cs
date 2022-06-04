using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
	public class IKCV : TemplateDeImpostoCondicional
	{
		public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
		{
			return orcamento.Valor > 500 && orcamento.Itens.Exists(x => x.Valor > 500);
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.10;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
	}
}
