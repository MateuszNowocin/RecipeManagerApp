using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManagementApp.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, double amount, string unit)
        {
            Name = name;
            Amount = amount;
            Unit = unit;
        }
    }
}
