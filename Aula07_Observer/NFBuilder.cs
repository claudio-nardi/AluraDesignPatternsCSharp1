using System;
using System.Collections.Generic;

namespace Aula07_Observer
{
	public class NFBuilder
	{
		public string RazaoSocial { get; private set; }
		public string Cnpj { get; private set; }
		public double ValorTotal { get; private set; }
		public double Impostos { get; private set; }
		public DateTime Data { get; private set; }
		public string Observacoes { get; private set; }

		public IList<ItemDaNota> todosItens = new List<ItemDaNota>();
		public IList<IAcoesAposEmissaoNf> acoes = new List<IAcoesAposEmissaoNf>();


		public NFBuilder ParaEmpresa(string razaoSocial)
		{
			RazaoSocial = razaoSocial;
			return this;
		}

		public NFBuilder ComCnpj(string cnpj)
		{
			Cnpj = cnpj;
			return this;
		}
		public NFBuilder ComItem(ItemDaNota item)
		{
			todosItens.Add(item);
			ValorTotal += item.Valor;
			Impostos += item.Valor * 0.05;
			return this;
		}

		public NFBuilder NaDataAtual()
		{
			this.Data = DateTime.Now;
			return this;
		}

		public NFBuilder ComObs(string observacoes)
		{
			this.Observacoes = observacoes;
			return this;
		}

		public NFBuilder setAcoes(IAcoesAposEmissaoNf acao)
		{
			this.acoes.Add(acao);
			return this;
		}



		public NotaFiscal constroiNF()
		{
			var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);

			foreach (IAcoesAposEmissaoNf item in this.acoes)
			{
				item.ExecutaAcao(nf);
			}

			return nf;


		}

	}
}