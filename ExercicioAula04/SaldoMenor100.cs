using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04
{
	public class SaldoMenor100 : Filtro
	{
		public SaldoMenor100()
		{
		}

		public SaldoMenor100(Filtro proximoFiltro) : base(proximoFiltro)
		{
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			IList<Conta> listaContasSelecionadas = new List<Conta>();

			if (ProximoFiltro != null)
				listaContasSelecionadas = ProximoFiltro.Filtra(contas);

			foreach (var conta in contas)
			{
				if (conta.Saldo < 100 && !listaContasSelecionadas.Contains(conta))	
				{
					listaContasSelecionadas.Add(conta);
				}
			}

			return listaContasSelecionadas;
		}

	}
}
