using System.IO;
using System.Threading;
using System;

namespace desafio2
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        public static void Menu() 
        {
            Console.WriteLine(@"
░██████╗░███████╗██████╗░███████╗███╗░░██╗░█████╗░██╗░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗
██╔════╝░██╔════╝██╔══██╗██╔════╝████╗░██║██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░██╗░█████╗░░██████╔╝█████╗░░██╔██╗██║██║░░╚═╝██║███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
██║░░╚██╗██╔══╝░░██╔══██╗██╔══╝░░██║╚████║██║░░██╗██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
╚██████╔╝███████╗██║░░██║███████╗██║░╚███║╚█████╔╝██║██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
░╚═════╝░╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝░╚════╝░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░███╗░░██╗████████╗░█████╗░████████╗░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗╚══██╔══╝██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░███████║░░░██║░░░██║░░██║╚█████╗░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██║░░░██║░░░██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║░░░██║░░░╚█████╔╝██████╔╝
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═════╝░");
            Console.WriteLine(" ");
            Console.WriteLine("1) - Adicionar contato");
            Console.WriteLine("2) - Listar contatos");
            Console.WriteLine("3) - Buscar contato");
            Console.WriteLine("4) - Atualizar contato");
            Console.WriteLine("5) - Deletar contato");
            Console.WriteLine("6) - Exportar contatos");
            Console.WriteLine("7) - Sair\n");

            string op = Console.ReadLine();
            Console.Clear();

            switch (op)
            {
                case "1":
                    Metodos.AdicionarContatos();
                    break;
                case "2":
                    Metodos.ListarContatos();
                    break;
                case "3":
                    Metodos.BuscarContatos();
                    break;
                case "4":
                    Metodos.EditarContatos();
                    break;
                case "5":
                    Metodos.ExcluirContatos();
                    break;
                case "6":
                    Metodos.ExportarContatos();
                    break;
                case "7":
                    return;
                default: 
                    Console.WriteLine("Opção invalida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Menu();
                    break;
            }
            
        }
    }
}