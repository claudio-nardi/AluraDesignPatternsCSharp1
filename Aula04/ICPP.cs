using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	internal class ICPP : TemplateDeImpostoCondicional
	{
		public ICPP()
		{
		}

		public ICPP(Imposto outroImposto) : base(outroImposto)
		{
		}

		protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
		{
			Console.WriteLine("Passou ICPP");
			return orcamento.Valor >= 500;
		}

		protected override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.07;
		}
		protected override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.05;
		}
	}
}
