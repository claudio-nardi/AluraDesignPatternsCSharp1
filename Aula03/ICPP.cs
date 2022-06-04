using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
	internal class ICPP : TemplateDeImpostoCondicional
	{
		public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
		{
			return orcamento.Valor >= 500;
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.07;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.05;
		}
	}
}
