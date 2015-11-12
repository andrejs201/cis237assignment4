//Andrejs Tomsons CIS 237 assignment 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Class that is instantiable. It inherits from the abstract droid class
    class ProtocolDroid : Droid
    {
        //Private variables unique to this class
        protected int numberOfLanguages;
        protected const decimal COST_PER_LANGUAGE = 25.00m;
        
        //Constructor that takes in the standard parameters, and the number of languages it knows.
        //The base constructor is called to do the work of assigning the standard parameters
        public ProtocolDroid(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            this.numberOfLanguages = NumberOfLanguages;
        }

        //constructor to create a random Protocol droid
        public ProtocolDroid() : base()
        {
            this.model = "Protocol";
            this.numberOfLanguages = RandomNumberOfLanguages();
            this.CalculateTotalCost();
        }

        //Overriden abstract method from the droid class.
        //It calculates the total cost using the baseCost method.
        public override void CalculateTotalCost()
        {
            //Calculate the base cost
            this.CalculateBaseCost();
            //Calculate the total cost using the result of the base cost
            this.totalCost = this.baseCost + (numberOfLanguages * COST_PER_LANGUAGE);
        }

        //Override the ToString method to use the base ToString, and append new information to it.
        public override string ToString()
        {
            return base.ToString() +
                "Number Of Languages: " + this.numberOfLanguages + Environment.NewLine;
        }

        //Random number of languages
        private int RandomNumberOfLanguages()
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(SLEEP_TIME);
            return rand.Next(50);
        }
    }
}
