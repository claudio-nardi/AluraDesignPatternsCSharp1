using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
	public class Reprovado : IEstadoDeUmOrcamento

	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw(null);
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já reprovado anteriormente não pode ser aprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já foi reprovado anteriormente");
		}
	}
}
