using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3
{
	public class Banco
	{
		static int _ultimoId = 1;

		public Banco()
		{
			this.Id = _ultimoId++;
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public int Telefone { get; set; }
		public string Emai { get; set; }
	}
}
