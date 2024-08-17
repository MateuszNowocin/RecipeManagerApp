using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManagementApp.Models
{
    public class Macronutrients
    {
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Sugar { get; set; }
        public double Fat { get; set; }
        public double SaturatedFat { get; set; }
        public double Fiber { get; set; }

        public Macronutrients(double protein, double carbs, double sugar, double fat, double saturatedFat, double fiber)
        {
            Protein = protein;
            Carbohydrates = carbs;
            Sugar = sugar;
            Fat = fat;
            SaturatedFat = saturatedFat;
            Fiber = fiber;
        }

        public double TotalCarbohydrates => Carbohydrates + Sugar;
        public double TotalFat => Fat + SaturatedFat;
    }
}
