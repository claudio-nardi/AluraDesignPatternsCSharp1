using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04
{
	public abstract class Filtro
	{
		public Filtro ProximoFiltro { get; set; }

		protected Filtro(Filtro proximoFiltro)
		{
			ProximoFiltro = proximoFiltro;
		}

		protected Filtro()
		{
			ProximoFiltro = null;
		}

		public abstract IList<Conta> Filtra(IList<Conta> contas);
		//return contas;
		
	}
}
