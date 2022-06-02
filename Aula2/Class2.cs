using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
	internal class Class2 : IDesconto
	{
		public IDesconto ProximoDesconto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public double Desconta(Orcamento orcamento)
		{
			throw new NotImplementedException();
		}
	}
}
