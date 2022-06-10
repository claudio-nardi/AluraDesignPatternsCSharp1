using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	public abstract class TemplateDeImpostoCondicional : Imposto
	{
		protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
		{
		}

		protected TemplateDeImpostoCondicional()
		{
		}

		public override double Calcula(Orcamento orcamento)
		{
			if (DeveUsarTaxacaoMaxima(orcamento))
			{
				return MaximaTaxacao(orcamento) + CalculaOutroImposto(orcamento);
			}
			else
			{
				return MinimaTaxacao(orcamento) + CalculaOutroImposto(orcamento);
			}
		}

		protected abstract double MinimaTaxacao(Orcamento orcamento);
		protected abstract double MaximaTaxacao(Orcamento orcamento);
		protected abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);

	}
}
