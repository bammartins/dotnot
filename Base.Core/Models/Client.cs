using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core.Models
{
    public class Client
    {
        public String   Name { get; set; }
        public String   Address { get; set; }
        public String   Phone { get; set; }
        public String   Status { get; set; }
        

        public Client (string name, string address, string phone, string stats)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Status = stats;
        }
        
    }
}
