using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
	public class RespostaPorcento : IResposta
	{
		public IResposta OutraResposta { get; set; }

		public string Responde(Requisicao requisicao, Conta conta)
		{
			if (requisicao.Formato == Formato.PORCENTO)
			{
				return $"%{conta.Nome}%{conta.Saldo}";
			}
			return OutraResposta.Responde(requisicao, conta);
		}
	}
}
