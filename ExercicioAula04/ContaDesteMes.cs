using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04
{
	public class ContaDesteMes : Filtro
	{
		public ContaDesteMes()
		{
		}

		public ContaDesteMes(Filtro proximoFiltro) : base(proximoFiltro)
		{
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			IList<Conta> listaContasSelecionadas = new List<Conta>();

			var mesAtual = Convert.ToInt16(DateTime.Today.ToString("MM"));
			
			if (ProximoFiltro != null)
				listaContasSelecionadas = ProximoFiltro.Filtra(contas);


			foreach (var conta in contas)
			{
				if (conta.Mes == mesAtual  && !listaContasSelecionadas.Contains(conta))
				{
					listaContasSelecionadas.Add(conta);
				}
			}

			return listaContasSelecionadas;
		}
	}
}
