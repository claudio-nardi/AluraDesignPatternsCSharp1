using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
	public interface IResposta
	{
		public IResposta OutraResposta { get; set; }	
		public string Responde(Requisicao requisicao, Conta conta);
	}
}
