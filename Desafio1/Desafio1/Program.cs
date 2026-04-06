using System.IO;
using System.Threading;

namespace desafio1;

class Program
{
    public static void Main()
    {
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

███╗░░██╗░█████╗░███╗░░░███╗███████╗░██████╗
████╗░██║██╔══██╗████╗░████║██╔════╝██╔════╝
██╔██╗██║██║░░██║██╔████╔██║█████╗░░╚█████╗░
██║╚████║██║░░██║██║╚██╔╝██║██╔══╝░░░╚═══██╗
██║░╚███║╚█████╔╝██║░╚═╝░██║███████╗██████╔╝
╚═╝░░╚══╝░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═════╝░");
        Console.WriteLine("");
        Console.WriteLine("1) - Inserir primeiro nome");
        Console.WriteLine("2) - Inserir sobrenome");
        Console.WriteLine("3) - Deletar Nome/Sobrenome");
        Console.WriteLine("4) - Gerar nome completo aleatório");
        Console.WriteLine("5) - Sair\n");
        int op = int.Parse(Console.ReadLine());
        
        switch (op)
        {
           case 1: Console.Clear(); InserirNome(); break;
           case 2: Console.Clear(); InserirSobrenome(); break;
           case 3: Console.Clear(); DeletarNomeSobrenome(); break;
           case 4: Console.Clear(); GerarNomeAleatorio();  break;
           case 5: return; break;
        }
        
    }

    public static void InserirNome() 
    {
        Console.WriteLine("Qual o nome você deseja colocar no arquivo?");
        string nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("O sobrenome que você deu é invalido ou nullo!");
            Thread.Sleep(900);
            Console.Clear();
            InserirNome();
        }
        else
        {

            string nomeF = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();

            string caminhoArquivo = $@"E:\Desenvolvimento\Desafio1\nome.txt";
            File.AppendAllText(caminhoArquivo, $"{nomeF}" + Environment.NewLine);
        }
    }

    public static void InserirSobrenome() 
    {
        Console.WriteLine("Qual o sobrenome você deseja colocar no arquivo?");
        string sobrenome = Console.ReadLine();
        if (string.IsNullOrEmpty(sobrenome))
        {
            Console.WriteLine("O sobrenome que você deu é invalido ou nullo!");
            Thread.Sleep(900);
            Console.Clear();
            InserirSobrenome();
        }
        else
        {

            string sobrenomeF = char.ToUpper(sobrenome[0]) + sobrenome.Substring(1).ToLower();

            string caminhoArquivo = $@"E:\Desenvolvimento\Desafio1\sobrenome.txt";
            File.AppendAllText(caminhoArquivo, $"{sobrenomeF}" + Environment.NewLine);
        }
    }

    public static void DeletarNomeSobrenome()
    {
        Console.WriteLine("O que você quer deletar?");
        Console.WriteLine("1) - Nome");
        Console.WriteLine("2) - Sobrenome");
        string opNomeSobrenome = Console.ReadLine();

        //if (opNomeSobrenome == 1)
        //{

        //}
        //else if (opNomeSobrenome == 2)
        //{

        //}
        //else
        //{
        //    Console.WriteLine("Operação invalida");
        //    Thread.Sleep(800);
        //    Console.Clear();
        //    Thread.Sleep(800);
        //    DeletarNomeSobrenome();
        //}
    }
    public static void GerarNomeAleatorio() 
    {

    }
}