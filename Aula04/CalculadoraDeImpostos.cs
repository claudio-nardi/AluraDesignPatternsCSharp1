using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	public class CalculadoraDeImpostos
	{
		public CalculadoraDeImpostos(Orcamento orcamento, Imposto imposto)
		{
			Console.WriteLine($"Imposto: {imposto.Calcula(orcamento)}");
		}
	}
}
