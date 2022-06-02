using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	public class Orcamento
	{
		public double Valor { get; private set ; }
		public List<Item> Itens { get; private set; }

		public void AdicionaItem(Item item)
		{
			Itens.Add(item);
			Valor += item.Valor;
		}
		public Orcamento()
		{
			//this.Valor = valor;
			Itens = new List<Item>();

		}
	}
}
