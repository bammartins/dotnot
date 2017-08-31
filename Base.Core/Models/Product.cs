using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core.Models
{
    public class Product
    {
        public String Name { get; set; }
        public decimal Unit_Value { get; set; }
        public decimal Hundred_Value { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }

        public Product (string name, string type, string desc, decimal u_value, decimal h_value)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Unit_Value = u_value;
            this.Hundred_Value = h_value;
        }



    }
}
