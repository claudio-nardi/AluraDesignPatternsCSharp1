﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Observer
{
	public class ItemDaNota
	{
		public string Descricao { get; private set; }
		public double Valor { get; private set; }

		public ItemDaNota(string descricao, double valor)
		{
			Descricao = descricao;
			Valor = valor;
		}
	}
}
