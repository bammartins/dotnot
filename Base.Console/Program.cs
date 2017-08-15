using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Core.Models;

namespace Base.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cli      = new Client();
            Phone phNumber   = new Phone();

            System.Console.Out.WriteLine("Digite o nome do Cliente");
            cli.Name        = System.Console.ReadLine();

            System.Console.Out.WriteLine("Digite o endereço do Cliente");
            cli.Address     = System.Console.ReadLine();

            System.Console.Out.WriteLine("Digite o telefone do Cliente");
            phNumber.Number = System.Console.ReadLine();

            System.Console.Out.WriteLine("Digite o status do Cliente");
            cli.Status      = System.Console.ReadLine();
            cli.Phone = phNumber;


            System.Console.Out.WriteLine("\n Nome: {0} \n Endereço: {1} \n Telefone: {2} \n Status: {3}", cli.Name, cli.Address, cli.Phone.Number, cli.Status);
            System.Console.Read();
        }
    }
}
