using System.Collections.Generic;

namespace ExercicioAula04
{
	internal abstract class FiltroBase
	{
		public abstract IList<Conta> Filtra(IList<Conta> contas)
		{
			return contas;
		}
	}
}