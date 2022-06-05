using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3
{
	public abstract class TemplateRelatorio
	{
		public void Imprime(List<Conta> listaContas)
		{
			imprimeCabecalho();
			imprimeCorpo(listaContas);
			imprimeRodape();
		}

		public abstract void imprimeCabecalho();
		public abstract void imprimeCorpo(List<Conta> contas);
		public abstract void imprimeRodape();

	}
}
