using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula05
{
	public interface IEstadoDaConta
	{
		void Saca(Conta conta, double valor);
		void Deposita(Conta conta, double valor);
	}
}
