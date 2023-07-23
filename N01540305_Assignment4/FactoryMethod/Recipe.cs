using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Assignment4.FactoryMethod
{
    public abstract class Recipe
    {

        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Recipe()
        {
            this.AddIngredients();
        }

        public List<Ingredient> GetIngredients() { return _ingredients; }

        public abstract void AddIngredients();
    }
}
