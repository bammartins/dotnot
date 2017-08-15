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
            List<Client> listCli = new List<Client>(); 
            bool flag = true;

            while (flag == true)
            {
                System.Console.Out.WriteLine("Digite o nome do Cliente");
                cli.Name = System.Console.ReadLine();

                System.Console.Out.WriteLine("Digite o endereço do Cliente");
                cli.Address = System.Console.ReadLine();

                System.Console.Out.WriteLine("Digite o telefone do Cliente");
                phNumber.Number = System.Console.ReadLine();

                System.Console.Out.WriteLine("Digite o status do Cliente");
                cli.Status = System.Console.ReadLine();
                cli.Phone = phNumber;

                listCli.Add(cli);

                System.Console.Out.WriteLine("Adicionar um novo Cliente?");
                var answer = System.Console.ReadLine().ToUpper();

                if (answer == "NAO" || answer == "N" || answer == "NO") {
                    flag = false;
                }
                else if (answer == "SIM" || answer == "S" || answer == "YES" || answer == "Y")                {
                    flag = true;
                }

            }


            foreach (var i in listCli)
            {
              System.Console.Out.WriteLine("\n Nome: {0} \n Endereço: {1} \n Telefone: {2} \n Status: {3}", i.Name, i.Address, i.Phone.Number, i.Status);
              System.Console.Out.WriteLine("*************************************");
            }

            System.Console.Read();
        }
    }
}
