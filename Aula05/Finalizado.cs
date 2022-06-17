using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
	public class Finalizado : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new NotImplementedException();
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já finalizado, impossível mudança de estado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("Orçamento já finalizado, impossível mudança de estado");
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já finalizado, impossível mudança de estado");
		}
	}
}
