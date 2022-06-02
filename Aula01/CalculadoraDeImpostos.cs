using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
	public class CalculadoraDeImpostos
	{
		public CalculadoraDeImpostos(Orcamento orcamento, IImposto imposto)
		{
			Console.WriteLine($"Imposto: {imposto.Calcula(orcamento)}");
		}
	}
}
