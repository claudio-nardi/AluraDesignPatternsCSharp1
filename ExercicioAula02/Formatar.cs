using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
	public class Formatar
	{

		public string TextoFormatado(Requisicao requisicao, Conta conta)
		{
			var r1 = new RespostaPontoEVirgula();
			//var r2 = ;
			//var r3 = ;
			//r1.OutraResposta = r2;
			//r2.OutraResposta = r3;

			return r1.Responde(requisicao, conta);
		}
	}

}
