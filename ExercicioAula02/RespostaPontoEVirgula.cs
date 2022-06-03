using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
	public class RespostaPontoEVirgula : IResposta
	{
		public IResposta OutraResposta { get; set; }

		public RespostaPontoEVirgula(IResposta outraResposta)
		{
			OutraResposta = outraResposta;
		}

		public RespostaPontoEVirgula()
		{
//			OutraResposta = null;
		}

		public string Responde(Requisicao requisicao, Conta conta)
		{
			if (requisicao.Formato == Formato.CSV)
			{
				return conta.Nome + ";" + conta.Saldo;
			}
			if (OutraResposta != null)
			{
				return OutraResposta.Responde(requisicao, conta);
			}
			else
			{
				throw new Exception("Formato de resposta inválido");
			}
		}
	}
}
