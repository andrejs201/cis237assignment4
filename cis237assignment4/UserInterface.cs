//Andrejs Tomsons CIS 237 assignment 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Class to handle all of the User Interface operations
    class UserInterface
    {
        //Create a class level variable for the droid collection
        IDroidCollection droidCollection;

        //Constructor that will take in a droid collection to use
        public UserInterface(IDroidCollection DroidCollection)
        {
            this.droidCollection = DroidCollection;
        }

        //Method to display the welcome message of the program
        public void DisplayGreeting()
        {
            Console.WriteLine("Welcome to the Droid Inventory System");
            Console.WriteLine();
        }

        //Method to display the main menu
        public void DisplayMainMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new droid to the system");
            Console.WriteLine("2. Print the list of droids out");
            Console.WriteLine("3. Organize the list of droids by type");
            Console.WriteLine("4. Sort the list of droids by total cost");
            Console.WriteLine("5. Exit the program");
        }

        //Method to get a menu choice
        public int GetMenuChoice()
        {
            //Display prompt and get the input from the user
            Console.Write("> ");
            string choice = Console.ReadLine();

            //Set a variable for the menu choice to 0. Try to parse the input, if successful, return the menu choice.
            int menuChoice = 0;
            try
            {
                menuChoice = Int32.Parse(choice);
            }
            catch (Exception e)
            {
                menuChoice = 0;
            }

            return menuChoice;
        }

        //Method to do the work of creating a new droid
        public void CreateDroid()
        {
            //Prompt for color selection
            this.displayColorSelection();
            //Get the choice that the user makes
            int choice = this.GetMenuChoice();

            //If the choice is not valid, loop until it is valid, or the user cancels the operation
            while(choice < 1 || choice > 4)
            {
                //Prompt for a valid choice
                this.displayColorSelection();
                choice = this.GetMenuChoice();
            }

            //Check the choice against the possibilities
            //If there is one found, work on getting the next piece of information.
            switch(choice)
            {
                case 1:
                    this.chooseMaterial("Bronze");
                    break;

                case 2:
                    this.chooseMaterial("Silver");
                    break;

                case 3:
                    this.chooseMaterial("Gold");
                    break;
            }
        }

        //Method to print out the droid list
        public void PrintDroidList()
        {
            Console.WriteLine();
            Console.WriteLine(this.droidCollection.GetPrintString());
        }

        //Display the Model Selection
        private void displayModelSelection()
        {
            Console.WriteLine();
            Console.WriteLine("What type of droid is it?");
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitorial");
            Console.WriteLine("4. Astromech");
            Console.WriteLine("5. Cancel This Operation");
        }

        //Display the Material Selection
        private void displayMaterialSelection()
        {
            Console.WriteLine();
            Console.WriteLine("What material is the droid made out of?");
            Console.WriteLine("1. Carbonite");
            Console.WriteLine("2. Vanadium");
            Console.WriteLine("3. Quadranium");
            Console.WriteLine("4. Cancel This Operation");
        }

        //Display the Color Selection
        private void displayColorSelection()
        {
            Console.WriteLine();
            Console.WriteLine("What color is the droid?");
            Console.WriteLine("1. Bronze");
            Console.WriteLine("2. Silver");
            Console.WriteLine("3. Gold");
            Console.WriteLine("4. Cancel This Operation");
        }

        //Display the Number of Languages Selection
        private void displayNumberOfLanguageSelection()
        {
            Console.WriteLine();
            Console.WriteLine("How many languages does the droid know?");
        }

        //Display and get the utility options
        private bool[] displayAndGetUtilityOptions()
        {
            Console.WriteLine();
            bool option1 = this.displayAndGetOption("Does the droid have a toolbox?");
            Console.WriteLine();
            bool option2 = this.displayAndGetOption("Does the droid have a computer connection?");
            Console.WriteLine();
            bool option3 = this.displayAndGetOption("Does the droid have an arm?");

            bool[] returnArray = {option1, option2, option3};
            return returnArray;
        }

        //Display and get the Janatorial options
        private bool[] displayAndGetJanatorialOptions()
        {
            Console.WriteLine();
            bool option1 = this.displayAndGetOption("Does the droid have a trash compactor?");
            Console.WriteLine();
            bool option2 = this.displayAndGetOption("Does the droid have a vaccum?");

            bool[] returnArray = { option1, option2 };
            return returnArray;
        }

        //Display and get the astromech options
        private bool displayAndGetAstromechOption()
        {
            Console.WriteLine();
            return this.displayAndGetOption("Does the droid have a fire extinguisher?");
        }

        //Display and get the number of ships
        private int displayAndGetAstromechNumberOfShips()
        {
            Console.WriteLine();
            Console.WriteLine("How many ships has the droid worked on?");
            int choice = this.GetMenuChoice();

            while (choice <= 0)
            {
                Console.WriteLine("Not a valid number of ships");
                Console.WriteLine("How many ships as the droid worked on?");
                choice = this.GetMenuChoice();
            }
            return choice;
        }

        //Method to display and get a general option
        //It ensures that Y or N is the typed response
        private bool displayAndGetOption(string optionString)
        {
            Console.WriteLine(optionString + " (y/n)");
            string choice = Console.ReadLine();
            while (choice.ToUpper() != "Y" && choice.ToUpper() != "N")
            {
                Console.WriteLine(optionString);
                choice = Console.ReadLine();
            }
            if (choice.ToUpper() == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to choose the Material for the droid. It accepts Color as the parameter
        private void chooseMaterial(string Color)
        {
            //Display the material selection
            this.displayMaterialSelection();
            //get the users choice
            int choice = this.GetMenuChoice();

            //while the chioce is not valid, wait until there is a valid one
            while (choice < 0 || choice > 4)
            {
                this.displayMaterialSelection();
                choice = this.GetMenuChoice();
            }

            //Check to see which choice was chosen. Call choose model and pass the color an material over
            //to the method to get the model
            switch(choice)
            {
                case 1:
                    this.chooseModel(Color, "Carbonite");
                    break;
                        
                case 2:
                    this.chooseModel(Color, "Vanadium");
                    break;

                case 3:
                    this.chooseModel(Color, "Quadranium");
                    break;

            }
        }

        //Method to choose a model and decide what other input is needed based on the selected model
        private void chooseModel(string Color, string Material)
        {
            //Display the menu to choose which model
            this.displayModelSelection();
            //Get the model choice
            int choice = this.GetMenuChoice();

            //While the choice is not valid, keep prompting for a choice
            while (choice < 0 || choice > 5)
            {
                //Display the menu again, and ask for the option again.
                this.displayModelSelection();
                choice = this.GetMenuChoice();
            }

            //Based on the choice, call the next set of crieteria that needs to be determined
            switch (choice)
            {
                case 1:
                    this.chooseNumberOfLanguages(Color, Material, "Protocol");
                    break;

                case 2:
                    this.chooseOptions(Color, Material, "Utility");
                    break;

                case 3:
                    this.chooseOptions(Color, Material, "Janatorial");
                    break;

                case 4:
                    this.chooseOptions(Color, Material, "Astromech");
                    break;
            }
        }

        //Method to choose the number of langages that a droid knows. It accepts the values that were determined
        //in the past methods. This method will also add a droid based on the collected information.
        private void chooseNumberOfLanguages(string Color, string Material, string Model)
        {
            //Display the number of languages selection
            this.displayNumberOfLanguageSelection();
            //Get the users choice
            int choice = this.GetMenuChoice();

            //While the choice is not valid, keep prompting for a valid one.
            while (choice < 0)
            {
                Console.WriteLine("Not a valid number of languages");
                this.displayNumberOfLanguageSelection();
                choice = this.GetMenuChoice();
            }

            //The only droid that we can add with this criteria is a protocol droid, so add it to the droid collection
            this.droidCollection.Add(Material, Model, Color, choice);

        }

        //Method to figure out which of the utility droids the user is creating, and then work on collecting the rest
        //of the needed information to create the droid.
        private void chooseOptions(string Color, string Material, string Model)
        {
            //Display and get the utility options.
            bool[] standardOptions = this.displayAndGetUtilityOptions();

            //Based on the model chosen, figure out the remaining information needed.
            switch(Model)
            {
                //If it is a utility
                case "Utility":
                    this.droidCollection.Add(Material, Model, Color, standardOptions[0], standardOptions[1], standardOptions[2]);
                    break;

                //If it is a Janatorial
                case "Janatorial":
                    //Get the rest of the options for a Janatorial droid.
                    bool[] janatorialOptions = this.displayAndGetJanatorialOptions();
                    //Add it to the collection
                    this.droidCollection.Add(Material, Model, Color, standardOptions[0], standardOptions[1], standardOptions[2], janatorialOptions[0], janatorialOptions[1]);
                    break;

                //If it is a Astromech
                case "Astromech":
                    //Get the rest of the options for an astromech
                    bool astromechOption = this.displayAndGetAstromechOption();
                    int astromechNumberOfShips = this.displayAndGetAstromechNumberOfShips();
                    //Add it to the collection
                    this.droidCollection.Add(Material, Model, Color, standardOptions[0], standardOptions[1], standardOptions[2], astromechOption, astromechNumberOfShips);
                    break;
            }
        }

        //Method to organize droids by type
        public void Organize()
        {
            //Organize here
            droidCollection.Organize();

            Console.WriteLine();
            Console.WriteLine("The droids have been organised by type.(Astromech, Janitor, Utility, Protocol)");
            Console.WriteLine();
        }

        //method to sort droids by total cost
        public void Sort()
        {
            //Sort here
            droidCollection.Sort();

            Console.WriteLine();
            Console.WriteLine("The droids have been organised by total cost.(low to high)");
            Console.WriteLine();
        }

    }
}
