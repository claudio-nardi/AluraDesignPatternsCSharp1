using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
	public abstract class TemplateDeImpostoCondicional : IImposto
	{
		public double Calcula(Orcamento orcamento)
		{
			if (DeveUsarTaxacaoMaxima(orcamento))
			{
				return MaximaTaxacao(orcamento);
			}
			else
			{
				return MinimaTaxacao(orcamento);
			}
		}

		protected abstract double MinimaTaxacao(Orcamento orcamento);
		protected abstract double MaximaTaxacao(Orcamento orcamento);
		protected abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);

	}
}
