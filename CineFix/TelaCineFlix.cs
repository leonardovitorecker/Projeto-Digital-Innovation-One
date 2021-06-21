using System;
using 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFix
{

	
	class TelaCineFlix
	{

		public add.reference.DioFilmes Filmes { get; set; }
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						TelaFilmes();
						break;
					case "2":
						TelaSeries();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();

		}

		private int TelaFilmes()
        {
			AppDomainManagerInitializa
        }



		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("CineFlix  a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Tela de filmes");
			Console.WriteLine("2- Tela de series ");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}

