using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace N01540305_Assignment4.FactoryMethod
{
    public class IcecreamRecipe : Recipe
    {
        public override void AddIngredients()
        {
            GetIngredients().Add(new Milk());
            GetIngredients().Add(new Flavor());
            GetIngredients().Add(new ChocolateChip());
        }
    }
}
