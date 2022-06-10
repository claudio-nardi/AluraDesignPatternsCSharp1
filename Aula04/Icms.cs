using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	public class Icms : Imposto
	{
		public Icms() : base () {}

		public Icms(Imposto outroImposto) : base(outroImposto) {}


		public override double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.10 + CalculaOutroImposto(orcamento);
		}
	}
}
