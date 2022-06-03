using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	public class CalculadorDeDescontos
	{
		public double Calcula(Orcamento orcamento)
		{
			var d1 = new DescontoMaisDe5Itens();
			var d2 = new DescontoAcimaDeQuinhentos();
			var d3 = new DescontoVendaCasada();
			//var d4 = new SemDesconto();

			d1.ProximoDesconto = d2;
			d2.ProximoDesconto = d3;
			//d3.ProximoDesconto = d4;

			return d1.Desconta(orcamento);
		}
	}
}
