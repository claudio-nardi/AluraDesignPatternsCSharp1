using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
	public class Aprovado : IEstadoDeUmOrcamento

	{
		public bool descontoJaConcedido = false;

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			if (!descontoJaConcedido)
			{
				orcamento.Valor *= 0.98;
				descontoJaConcedido = true;
			}
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já aprovado anteriormente");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já aprovado anteriormente não pode ser reprovado");
		}
	}
}
