using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Core.Models;
using Base.Core.Controller;

namespace Base.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var phNumber   = new Phone();
            var cli   = new Client("Bruno Martins", "Rua Canaã", "(11) 4451-0485", "Ativo");
            var prod  = new Product("nome prod","type prod", "desc prod", 1, 2);
            var order = new PlaceOrder(cli, prod, DateTime.ParseExact("30/08/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));

            System.Console.Out.WriteLine("\n Nome: {0} \n Endereço: {1} \n Telefone: {2} \n Status: {3}", cli.Name, cli.Address, cli.Phone, cli.Status);
            System.Console.Out.WriteLine("*************************************");
            System.Console.Out.WriteLine("\n Produto: {0} \n Tipo: {1} \n Descrição: {2} \n Valor Unitário: {3} \n Valor Cento: {4}", prod.Name, prod.Type, prod.Description, prod.Unit_Value, prod.Hundred_Value);
            System.Console.Out.WriteLine("*************************************");
            order.RegisterOrder();
            System.Console.Out.WriteLine("*************************************");
            

            System.Console.Read();
        }
    }
}
