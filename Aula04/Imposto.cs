using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	public abstract class Imposto
	{
		public Imposto OutroImposto { get; set; }
		public abstract double Calcula(Orcamento orcamento);
		protected Imposto(Imposto outroImposto)
		{
			OutroImposto = outroImposto;
		}

		protected Imposto()
		{
			OutroImposto = null;
		}

		protected double CalculaOutroImposto(Orcamento orcamento)
		{
			if (this.OutroImposto == null) return 0;
			return OutroImposto.Calcula(orcamento);
		}

	}
}
