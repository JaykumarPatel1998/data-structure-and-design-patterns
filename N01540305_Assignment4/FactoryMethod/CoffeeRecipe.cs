using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace N01540305_Assignment4.FactoryMethod
{
    public class CoffeeRecipe : Recipe
    {
        public override void AddIngredients()
        {
            GetIngredients().Add(new Coffee());
            GetIngredients().Add(new Water());
            GetIngredients().Add(new Sugar());
        }
    }
}
