using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05


{
	public class Orcamento 
	{
		public double Valor { get; set; }
		public List<Item> Itens { get; private set; }
		public IEstadoDeUmOrcamento EstadoAtual { get; set; }

		public void AdicionaItem(Item item)
		{
			Itens.Add(item);
			Valor += item.Valor;
		}
		public Orcamento()
		{
			//this.Valor = valor;
			Itens = new List<Item>();
			this.EstadoAtual = new EmAprovacao();
		}

		public void AplicaDescontoExtra()
		{
			this.EstadoAtual.AplicaDescontoExtra(this);
		}
		public void Aprova()
		{
			this.EstadoAtual.Aprova(this);
		}

		public void Finaliza(Orcamento orcamento)
		{
			EstadoAtual.Finaliza(this);
		}

		public void Reprova(Orcamento orcamento)
		{
			EstadoAtual.Reprova(this);
		}
	}
}
