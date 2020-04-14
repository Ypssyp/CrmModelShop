using System.Collections.Generic;

namespace CrmBl.Model
{
   public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { set; get; }

        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; } 

        public override string ToString()
        {
            return Name;
        }


    }
}
