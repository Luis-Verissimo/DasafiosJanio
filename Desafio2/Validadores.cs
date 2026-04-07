using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace desafio2 
{ 

    public class Validadores
    {
	    public Validadores()
	    {
		    public static void ValidaNome()	
            if (string.IsNullOrEmpty(nome) || int.TryParse(nome, out verificaNumero))
            {
                Console.WriteLine("Nome invalido");
                Thread.Sleep(1000);
                Console.Clear();
                Program.Menu();
            }
        }
    }   
}
