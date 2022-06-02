using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
	public class Icms : IImposto
	{
		public double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.10;
		}
	}
}
