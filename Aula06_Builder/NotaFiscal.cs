using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Builder
{
	public class NotaFiscal
	{

		public string RazaoSocial { get; private set; }
		public string Cnpj { get; private set; }
		public DateTime DataDeEmissao { get; private set; }
		public Double Impostos { get; private set; }
		public double ValorTotal { get; private set; }
		public IList<ItemDaNota> Itens { get; private set; }
		public string Observacoes { get; set; }

		public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao,double valorTotal, double impostos, IList<ItemDaNota> itens, string observacoes)
		{
			RazaoSocial = razaoSocial;
			Cnpj = cnpj;
			DataDeEmissao = dataDeEmissao;
			Impostos = impostos;
			ValorTotal = valorTotal;
			Itens = itens;
			Observacoes = observacoes;
		}
		
	}
}
