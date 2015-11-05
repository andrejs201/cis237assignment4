using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Interface that I added to declare what methods MUST be implemeted in any class that implements this interface.
    interface IDroidCollection
    {
        //Various overloaded Add methods to add a new droid to the collection
        void Add(int loop);
        bool Add(string Material, string Model, string Color, int NumberOfLanguages);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasTrashCompactor, bool HasVaccum);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasFireExtinguisher, int NumberOfShips);
        
        //Method to get the data for a droid into a nicely formated string that can be output.
        string GetPrintString();
    }
}
