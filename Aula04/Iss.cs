using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	public class Iss : Imposto
	{
		private const double aliquota = 0.06;

		public Iss() : base() {}

		public Iss(Imposto outroImposto) : base(outroImposto) {}

		public override double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * aliquota + base.CalculaOutroImposto(orcamento);
		}

	}
}
