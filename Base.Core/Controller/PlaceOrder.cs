using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Core.Models;

namespace Base.Core.Controller
{
    public class PlaceOrder
    {
        private Client Cli;
        private Product Prod;
        private DateTime Order_Date;
        private Random rand = new Random();



        public PlaceOrder(Client client, Product product, DateTime date)
        {
            this.Cli = client;
            this.Prod = product;
            this.Order_Date = date;
        }

        public void RegisterOrder()
        {
            System.Console.Out.WriteLine("\n Numero do pedido: {0} \n Cliente: {1} \n Endereço: {2} \n Telefone: {3} \n Produto: {4} \n Valor: {5} \n Data de Entrega: {6}", rand.Next(1, 500), Cli.Name, Cli.Address, Cli.Phone, Prod.Name, Prod.Hundred_Value, Order_Date.ToString("dd/MM/yyyy"));
        }
    }
}
