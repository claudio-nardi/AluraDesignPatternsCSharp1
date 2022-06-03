using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
	public class RespostaXML : IResposta
	{
		public IResposta OutraResposta { get; set; }

		public RespostaXML(IResposta outraResposta)
		{
			OutraResposta = outraResposta;
		}

		public string Responde(Requisicao requisicao, Conta conta)
		{
			if (requisicao.Formato == Formato.XML)
			{
				return "{" + conta.Nome + " , " + conta.Saldo + "}";
			}

			return OutraResposta.Responde(requisicao, conta);	
		}
	}
}
