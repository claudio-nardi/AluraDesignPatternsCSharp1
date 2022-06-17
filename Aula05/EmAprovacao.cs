using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
	public class EmAprovacao : IEstadoDeUmOrcamento
	{
		private bool descontoJaConcedido = false;
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			if (!descontoJaConcedido)
			{
				orcamento.Valor *= 0.95;
				descontoJaConcedido = true;
			}
		}

		public void Aprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Aprovado();
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new NotImplementedException();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new NotImplementedException();
		}
	}
}
