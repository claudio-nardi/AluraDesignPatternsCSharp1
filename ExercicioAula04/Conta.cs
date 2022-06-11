using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04
{
	public class Conta : IComparable<Conta>
	{
		public int Id { get; set; }
		public double Saldo { get; set; }
		public short Mes { get; set; }

		public int CompareTo(Conta other)
		{
			if (other == null) return 1;
			return this.Id.CompareTo(other.Id);

		}
	}
}
