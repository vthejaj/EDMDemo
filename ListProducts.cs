using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMDemo
{
    public class ListProducts
    {
        static void Main(string[] args)
        {
            msdbEntities1 ctx = new msdbEntities1();
            ctx.Database.Log = Console.WriteLine;

            // Eager load - bring all from products and categories 
            foreach(product p in ctx.products.Include("category"))
            {
                Console.WriteLine( $"{p.ProdName}  - {p.category.CatDesc}");
            }
        }
    }
}
