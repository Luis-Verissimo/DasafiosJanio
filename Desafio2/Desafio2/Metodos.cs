using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace desafio2;

public static class Metodos
{
	public static void AdicionarContatos()
	{

		int verificaNumero;
		string[] arroba = new string[]
		{
			"@"
		};

		string[] DDD = new string[]
		{
			"11","12","13","14","15","16","17","18","19","21","22","24","27","28",
			"31","32","33","34","35","37","38","41","42","43","44","45","46",
			"47","48","49","51","53","54","55","61","62","64","63","65","66",
			"67","68","69","71","73","74","75","77","79","81","87","82","83",
			"84","85","88","86","89","91","93","94","92","97","95","96","98","99"
		};

		Console.WriteLine("Diga o nome do contato:");
		string nome = Console.ReadLine();

		if (string.IsNullOrEmpty(nome) || int.TryParse(nome, out verificaNumero))
		{
			Console.WriteLine("Nome invalido");
			Thread.Sleep(1000);
			Console.Clear();
			Program.Menu();
		}
		else
		{
			Console.WriteLine("Diga o email do contato:");
			string email = Console.ReadLine();
			string emailF = email.ToLower();

			if (string.IsNullOrEmpty(emailF) || !emailF.Contains(arroba[0]))
			{
				Console.WriteLine("Email invalido");
				Thread.Sleep(2000);
				Console.Clear();
				Program.Menu();
			}
			else
			{
				Console.WriteLine("Diga o telefone do contato com o DDD do estado, Exemplo: 839642148631:");
				string telefone = (Console.ReadLine());
				string telefoneDDD = (telefone[0] + "" + telefone[1]).ToString();
				if (telefone.Length < 3)
				{
					Console.WriteLine("Digite um telefone valido com 10 numeros e um DDD valido ");
					Thread.Sleep(2000);
					Console.Clear();
					Program.Menu();
				}
				else if (telefone.Length <= 10 || !DDD.Contains(telefoneDDD))
				{

					Console.WriteLine("Digite um telefone valido com 10 numeros e um DDD valido ");
					Thread.Sleep(2000);
					Console.Clear();
					Program.Menu();
				}
				else
				{
					string nomeF = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
					string caminho = "E:\\Desenvolvimento\\DasafiosJanio\\Desafio2\\Contatos.txt";
					File.AppendAllText(caminho, nomeF + ";" + telefone + ";" + emailF + ";" + Environment.NewLine);
					Console.WriteLine("Contato salvo com sucesso!");
					Thread.Sleep(2000);
					Console.Clear();
					Program.Menu();
				}
			}
		}
	}

	public static void ListarContatos()
	{
        string caminho = "E:\\Desenvolvimento\\DasafiosJanio\\Desafio2\\Contatos.txt";
		string[] Contatos = File.ReadAllLines(caminho); 
        foreach (var item in Contatos) 
		{
            Console.WriteLine(item); 
		}
    }

	public static void BuscarContatos()
	{

	}

	public static void EditarContatos()
	{

	}

	public static void ExcluirContatos()
	{

	}

	public static void ExportarContatos()
	{

    }	
}