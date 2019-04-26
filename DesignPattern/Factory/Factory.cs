using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Factory
    {
        public Produit CreateProduct(string ProductCategory)
        {
            if (ProductCategory == "Toys")
                return new Toys();
            if (ProductCategory == "Dildo")
                return new Dildo();
            return null;
        }
    }

}
