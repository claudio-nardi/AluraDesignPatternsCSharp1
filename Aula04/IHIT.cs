using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
	//public class IHIT : TemplateDeImpostoCondicional 
	//{
	//	//protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
		//{
		//	var listaItensJaLidos = new List<string>();
		//	bool temDuplicidade; 

		//	foreach (Item item in orcamento.Itens)
		//	{
		//		if (listaItensJaLidos.Exists(x => x ==item.Nome))
		//		{
		//			return true;
		//		}
		//		listaItensJaLidos.Add(item.Nome);
		//	}

		//	return false;
		//}

		//protected override double MaximaTaxacao(Orcamento orcamento)
		//{
		//	return orcamento.Valor * 0.13 + 100;
		//}

		//protected override double MinimaTaxacao(Orcamento orcamento)
		//{
		//	return orcamento.Valor * (orcamento.Itens.Count * 0.01);
		//}
//	}
}
