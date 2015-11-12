//Andrejs Tomsons CIS 237 assignment 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Derived from the abstract class Droid. Can be instanciated
    class UtilityDroid : Droid
    {
        //Class level variables that can be used in this class, or any children of this class
        protected bool hasToolbox;
        protected bool hasComputerConnection;
        protected bool hasArm;

        //A constant that can be used in this class or any child classes
        protected const decimal COST_PER_OPTION = 35.00m;

        //Constructor that takes the standard parameters, and ones specific to this droid.
        //Calls the base constructor to do some of the work already written in the droid class.
        public UtilityDroid(string Material, string Model, string Color, bool HasToolbox, bool HasComputerConnection, bool HasArm) : base(Material, Model, Color)
        {
            this.hasToolbox = HasToolbox;
            this.hasComputerConnection = HasComputerConnection;
            this.hasArm = HasArm;
        }

        //constructor to create a random Utility droid
        public UtilityDroid() : base()
        {
            this.model = "Utility";
            this.hasToolbox = RandomToolBox();
            this.hasComputerConnection = RandomComputerConnection();
            this.hasArm = RandomArm();
            this.CalculateTotalCost();
        }

        //virtual method to calculate the cost of the options. This method can be overridden in child classes
        //to calculate the cost of options
        protected virtual decimal CalculateCostOfOptions()
        {
            decimal optionsCost = 0;

            if (hasToolbox)
            {
                optionsCost += COST_PER_OPTION;
            }

            if (hasComputerConnection)
            {
                optionsCost += COST_PER_OPTION;
            }

            if (hasArm)
            {
                optionsCost += COST_PER_OPTION;
            }

            return optionsCost;
        }

        //Overridden method to calculate the total cost. This method uses the base cost from the parent droid class,
        //and the cost of the options of this class to create the total cost.
        public override void CalculateTotalCost()
        {
            this.CalculateBaseCost();

            this.totalCost = this.baseCost + this.CalculateCostOfOptions();
        }

        //Overridden ToString method to output the information for this droid.
        //uses the base ToString method and appends more information to it.
        public override string ToString()
        {
            return base.ToString() +
                "Has Tool Box: " + this.hasToolbox + Environment.NewLine +
                "Has Computer Connection: " + this.hasComputerConnection + Environment.NewLine +
                "Has Arm: " + this.hasArm + Environment.NewLine;
        }

        //Random tool box
        private bool RandomToolBox()
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(SLEEP_TIME);
            if (rand.Next(0, 2) == 0)
                return true;
            else
                return false;
        }

        //random computer connection
        private bool RandomComputerConnection()
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(SLEEP_TIME);
            if (rand.Next(0, 2) == 0)
                return true;
            else
                return false;
        }

        //Random arm
        private bool RandomArm()
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(SLEEP_TIME);
            if (rand.Next(0, 2) == 0)
                return true;
            else
                return false;
        }
    }
}
