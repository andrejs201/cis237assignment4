using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Abstract class that implements the IDroid interface
    abstract class Droid : IDroid
    {
        //some protected variables for the class
        protected string material;
        protected string model;
        protected string color;

        protected decimal baseCost;
        protected decimal totalCost;

        //The public property for TotalCost
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        //Constructor that takes the main 3 parameters shared amongst all 4 types of droids
        public Droid(string Material, string Model, string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
        }

        public Droid()
        {
            //this.model = RandomModel();
            this.material = RandomMaterial();
            this.color = RandomColor();
        }

        //Virtual method that can be overridden in the derived classes if needed.
        //This implementation calculates the cost based on the material used for the droid
        protected virtual void CalculateBaseCost()
        {
            switch (this.material)
            {
                case "Carbonite":
                    this.baseCost = 100.00m;
                    break;

                case "Vanadium":
                    this.baseCost = 120.00m;
                    break;

                case "Quadranium":
                    this.baseCost = 150.00m;
                    break;

                default:
                    this.baseCost = 50.00m;
                    break;
            }
        }

        //Abstract method that MUST be overriden in the derived class to calculate the total cost
        public abstract void CalculateTotalCost();

        //Overriden toString method that will return a string representing the basic information for any droid
        public override string ToString()
        {
            return "Material: " + this.material + Environment.NewLine +
                    "Model: " + this.model + Environment.NewLine +
                    "Color: " + this.color + Environment.NewLine;
        }

        private string RandomModel()
        {
            Random rand = new Random();
            switch (rand.Next(0,4))
            {
                case 0:
                    return "Astromech";

                case 1:
                    return "Janitor";

                case 2:
                    return "Utility";

                case 3:
                    return "Protocol";
            }
            return "Model Error";
        }

        private string RandomMaterial()
        {
            Random rand = new Random();
            switch (rand.Next(0, 3))
            {
                case 0:
                    return "Carbonite";

                case 1:
                    return "Vanadium";

                case 2:
                    return "Quadranium";
            }
            return "Material Error";
        }

        private string RandomColor()
        {
            Random rand = new Random();
            switch (rand.Next(0, 3))
            {
                case 0:
                    return "Bronze";

                case 1:
                    return "Silver";

                case 2:
                    return "Gold";
            }
            return "Color Error";
        }

        public abstract int CompareTo(object obj);
        
    }
}
