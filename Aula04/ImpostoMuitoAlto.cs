using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	public class ImpostoMuitoAlto : Imposto
	{
		public ImpostoMuitoAlto()
		{
		}

		public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto)
		{
		}

		public override double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.20 + CalculaOutroImposto(orcamento);
		}
	}
}
