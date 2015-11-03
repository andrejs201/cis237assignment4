using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Class that inherits from the Utility class
    class JanitorDroid : UtilityDroid
    {
        //Some protected variables that can be accessed in derived classes
        protected bool hasTrashCompactor;
        protected bool hasVacuum;

        //Constuctor that takes lots of parameters to create the droid. The base constructor is used to do some of the work
        public JanitorDroid(string Material, string Model, string Color,
            bool HasToolbox, bool HasComputerConnection, bool HasArm, bool HasTrashCompactor, bool HasVacuum) :
            base(Material, Model, Color, HasToolbox, HasComputerConnection, HasArm)
        {
            //Assign the values that the base constructor is not taking care of.
            this.hasTrashCompactor = HasTrashCompactor;
            this.hasVacuum = HasVacuum;
        }

        public JanitorDroid() : base()
        {
            this.hasTrashCompactor = RandomTrashCompactor();
            this.hasVacuum = RandomVacuum();
        }

        //Override the CalculateCostOfOptions method.
        //Use the base class implementation of the method, and tack on the cost of the new options
        protected override decimal CalculateCostOfOptions()
        {
            decimal optionsCost = 0;

            optionsCost += base.CalculateCostOfOptions();

            if (hasTrashCompactor)
            {
                optionsCost += COST_PER_OPTION;
            }

            if (hasVacuum)
            {
                optionsCost += COST_PER_OPTION;
            }

            return optionsCost;
        }

        //Overridden ToString that uses the base ToString method, and appends the missing information.
        public override string ToString()
        {
            return base.ToString() +
                "Has Trash Compactor: " + this.hasTrashCompactor + Environment.NewLine +
                "Has Vacuum: " + this.hasVacuum + Environment.NewLine;
        }

        private bool RandomTrashCompactor()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
                return true;
            else
                return false;
        }

        private bool RandomVacuum()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
                return true;
            else
                return false;
        }
    }
}
