using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula06
{
	public class ItemBuilder
	{
		public string Descricao { get; set; }
		public double Valor { get; set; }

		public ItemBuilder SetDescricao(string descricao)
		{
			this.Descricao = descricao;
			return this;
		}

		public ItemBuilder SetValor(double valor)
		{ 
			this.Valor = valor;
			return this;
		}

		public ItemDaNota ConstroiItem()
		{
			return new ItemDaNota(this.Descricao, this.Valor);

		}

	}


}
