//Andrejs Tomsons CIS 237 assignment 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Class that inherits from the Utility Droid
    class AstromechDroid : UtilityDroid
    {
        //class level variables unique to this class. Set as protected so children classes can access them.
        protected bool hasFireExtinguisher;
        protected int numberOfShips;

        //Protected constant for the cost per ship. Children can access this too.
        protected decimal COST_PER_SHIP = 45.00m;

        //Constructor that uses the Base Constuctor to do most of the work.
        public AstromechDroid(string Material, string Model, string Color,
            bool HasToolbox, bool HasComputerConnection, bool HasArm, bool HasFireExtinquisher, int NumberOfShips) :
            base(Material, Model, Color, HasToolbox, HasComputerConnection, HasArm)
        {
            //Assign the values for the constructor that are not handled by the base constructor
            this.hasFireExtinguisher = HasFireExtinquisher;
            this.numberOfShips = NumberOfShips;
        }

        //constructor to create a random Astromech droid
        public AstromechDroid() : base()
        {
            this.model = "Astromech";
            this.hasFireExtinguisher = RandomFireExtinguisher();
            this.numberOfShips = RandomNumberOfShips();
            this.CalculateTotalCost();
        }

        //Overridden method to calculate the cost of options. Uses the base class to do some of the calculations
        protected override decimal CalculateCostOfOptions()
        {
            decimal optionsCost = 0;

            optionsCost += base.CalculateCostOfOptions();

            if (hasFireExtinguisher)
            {
                optionsCost += COST_PER_OPTION;
            }

            return optionsCost;
        }

        //Protected virtual method that can be overriden in child classes.
        //Caclulates the cost of ships.
        protected virtual decimal CalculateCostOfShips()
        {
            return COST_PER_SHIP * numberOfShips;
        }

        //Overriden method to calculate the total cost. Uses work from the base class to achive the answer.
        public override void CalculateTotalCost()
        {
            this.CalculateBaseCost();

            this.totalCost = this.baseCost + this.CalculateCostOfOptions() + this.CalculateCostOfShips();
        }

        //Overriden ToString method to output the information for this droid. Uses work done in the base class
        public override string ToString()
        {
            return base.ToString() +
                "Has Fire Extinguisher: " + this.hasFireExtinguisher + Environment.NewLine +
                "Number Of Ships: " + this.numberOfShips + Environment.NewLine;
        }

        //Random fire extinguisher
        private bool RandomFireExtinguisher()
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(SLEEP_TIME);
            if (rand.Next(0, 2) == 0)
                return true;
            else
                return false;
        }

        //Random number of ships
        private int RandomNumberOfShips()
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(SLEEP_TIME);
            return rand.Next(50);
        }
    }
}
