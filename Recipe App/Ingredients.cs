using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_App
{
    internal class Ingredient
    {
        //Properties for each ingredient
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double Factor { get; set; }

        //Array to hold ingredient details

        public string[] NameArray { get; set; }
        public double[] QuantityArray { get; set; }
        public string[] UnitArray { get; set; }

        public Ingredient() {}

        //Ingredient constructor
        public Ingredient(int numIngredients) 
        {
           NameArray= new string[numIngredients];
            QuantityArray= new double[numIngredients];
            UnitArray= new string[numIngredients];
            
        }

       

        //method used to add ingredients to array
        public void addIngredient(int i, string name, string unit, int quantity)
        {
            NameArray[i] = name;
            QuantityArray[i] = quantity;
            UnitArray[i] = unit;
        }

        //Method used to find ingredients in array
        public Boolean findIngredient(string name)
        {
           
            foreach(string Name in NameArray)
            {
                if (Name == name) { return true ; }
            }
            return false;
        }

        //method used to scale quantities
        public void scaleQuantities()
        {
            
            for (int i = 0; i < QuantityArray.Count(); i++)
            {
                QuantityArray[i] *= Factor;
            }
        }

        //method used to reset quantities
        public void resetQuantities() 
        {
            for ( int i =0; i<QuantityArray.Count(); i++)
            {
                QuantityArray[i] /= Factor;
            }
            Factor = 0;
        }

        //method used to clear array
        public void clearIngredients()
        {
            Array.Clear(NameArray, 0, NameArray.Length);
            Array.Clear(QuantityArray, 0, QuantityArray.Length);
            Array.Clear(UnitArray, 0, UnitArray.Length);
        }
        //method to display name of specific ingredient
        public string displayName(int index)
        {
            
            return NameArray[index];
        }
        //method to display unit of measurement of specific ingredient
        public string displayUnit(int index)
        {

            return UnitArray[index];
        }
        //method to display quantity of specific ingredient
        public double displayQuantity(int index)
        {

            return QuantityArray[index];
        }

    }
}
