﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	internal class SemDesconto : IDesconto
	{
		public IDesconto ProximoDesconto { get; set; }

		public double Desconta(Orcamento orcamento)
		{
			return 0;
		}
	}
}
