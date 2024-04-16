using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp1
{

    internal class MyIngredient
    {
        // Properties
        public string Name { get; }        // Name of the ingredient (read-only)
        private double originalQuantity;   // Original quantity of the ingredient
        public double Quantity { get; set; }  // Current quantity of the ingredient
        public string Unit { get; }        // Unit of measurement for the ingredient (read-only)

        // Constructor
        public MyIngredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            originalQuantity = quantity;   // Store the original quantity
            Unit = unit;
        }

        // Method to reset the quantity of the ingredient to its original value
        public void ResetQuantity()
        {
            Quantity = originalQuantity;   // Reset the quantity
        }
    }
}
