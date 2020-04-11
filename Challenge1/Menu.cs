using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Ingredients { get; set; }


        public Menu() { }

        public Menu(int mealNumber, string name, string description, decimal price, string ingredients)
        {
            MealNumber = mealNumber;
            Name = name;
            Description = description;
            Price = price;
            Ingredients = Ingredients;

        }
    }
}



