# Assignment 4 - Interfaces, Stacks, Queues, Generics, and Merge Sort. Project uses Assignment 3 solution.
## Due: 11-10-2015

## Author
Andrejs Tomsons


## Description

The Jawas on Tatooine are pleased with the job you have done on the droid system so far. Since they started using it, they have decided that they would like to be able to sort their list of droids in two different ways. It is your job to create these sorts for them.

They would like to sort the droids by category. If the list is printed from this sort, the program will display the droids in the following order: (Astromech, Janitor, Utility, Protocol). There does not need to be any order to the droids within those categories.

They would also like to sort the droids by the Total Cost ranging from the cheapest droid to the most expensive droid.

You need to add menu options and methods to a finished assignment 3 to complete assignment 4, and add the above mentioned functionality.

You should fork, and clone my Assignment 4. This will give you my finished implementation of Assignment 3 as a starting place. If you would rather use your implementation of assignment 3, just delete all of my classes, and add your classes in it's place. (Or replace the code of my classes with the code from your classes). This way you can still make a pull request. You are not required to use your implementation of Assignment 3. In fact, it would be easier for me to grade if you used mine, but you are free to use your own if that is easier, or what you would like to do.

You should add some dummy data to the program to make testing easier. Once the droid collection is intanciated, you should hard code the insertion of some droids into the collection. Do enough so that you can test both sorts without having to use the UI to create droids. Personally I did 12, but any number that proves the sorts work is sufficent.

The method by which both of these sorts get done is described below:

### Categorize by model (Bucket sort)
In order to sort the list by category, you will do the following things:
* Add a method to your droid collection that will do this sort on the collection.
* Create a generic stack class that can be used to store any type the user specifies. The implementation should be in the style of a linked list. (This is just like the generics we did in class. The Algorithms book has an implementation.)
* Create a generic queue class that can be used to store any type the user specifies. The implementation should be in the style of a linked list. (The Algorithms book has an implementation.)
* Create a stack for each type of droid (4 in total)
* Create a queue of type high enough on the inheritance chain to store all of the droids (Just 1 of these)
* Loop through your list of droids, and for each one
* Determine what type of droid it is and Push the droid onto the appropriate stack.
* Once all of the droids are on the various stacks, start Popping the droids off of the stacks and enqueue them in the Generic Queue. (Make sure you process the stacks in the correct order so that the order of the queue is the order specified above for the sort)
* Once all of the droids are in the Queue, replace the original array / list of droids with the droids in the queue by dequeuing a droid one at a time, and placing it back into the array / list at the proper location.

### Sort by Total Cost using Merge Sort
In order to sort the list by the Total Cost, you will do the following things:
* Add a method to your droid collection that will do this sort on the collection.
* Make the IDroid Interface inherit from the built in interface called IComparable. This will require you to implement the CompareTo method in the Droid class.
* Implement CompareTo in the Droid class, which will aid in the merge sort class
* Create a MergeSort class that takes in an array by reference of type IComparabe[]. This wil allow the merge sort to sort any array that implements IComparable thanks to polymorphism. Any implementation is fine for this class, but it may be easier to do an array version (NOT linked list), and use an auxilary array to store temporary information. (The Algorithms book has a nice implementation that uses IComparable. I believe that they call it just Comparable in the Algorithms book, but it is the same thing.)

The menu options and methods that you add should only sort the droid collection. Printing it should still be delegated to the print menu option that already exists. This means that sorting it will overwrite the original order, and that's okay.

You are free to do anything above an beyond what is listed here. The only "Requirements" are listed below.

Solution Must:
* Add some hard coded droids to the droid collection.
* Create Generic Stack class.
* Create Generic Queue class.
* Stack and Queue class must be Generic.
* Update IDroid to inherit from IComparable.
* Create MergeSort class.
* Mergesort class must take an IComparable array as the input.
* Update Program to allow options to sort by model, or by Total Cost.
* Add methods to the Droid Collection class to do each of the sorts.
* Use the Stack, and Queue to perform a bucket sort categorizing by model.
* Use the MergeSort to perform a sort on the TotalCost.

Below is the original Assignment 3 description for reference.

### Notes

The code in the Algorithms book for Stack, Queue, and Merge Sort are in Java. It will take a little work to translate it to C#, but it should be VERY close. Also note that the implementations in the book might not contain ALL of the funtionality you need, but should be really close. Be aware that you might want to add more funtionality to the implementations.

Be sure to think about what the time complexity for the bucket sort will be. Think about how it compares to that of a normal sort such as Merge or Bubble. Also consider the space complexity compared to that of merge or bubble sort. You may see questions related to this on the next exam.

## Outside Resources Used
mergesort code found here:
http://www.softwareandfinance.com/CSharp/MergeSort_Recursive.html


## Known Problems, Issues, And/Or Errors in the Program
none


## Assignment 3 Description for reference

The Jawas on Tatooine have recently opened a droid factory and they want to hire you to write a program to hold a list of the available droids, and the price of each droid. The price is based on the type: (protocol, utility, janitor, or astromech), the material used and the options selected by the Jawa creating the list.

The program will keep a list of Droids that are created. This list can be either an array or in the form of one of the C# List classes. The array or list should be of a type that is high enough on the inheritance chain that all droids no matter what type they are can be stored in it. (Think Polymorphism)

A Jawa will be presented with a user interface to add a new Droid, or print the current Droid list. Adding a new Driod will require input from the Jawa to create the new droid. Once all of the needed information is added for the droid, the new droid will be added to the list.

If a Jawa decides to print the list of droids in inventory, the program should loop through all of the droids in the list and print out the information from ToString, and the TotalCost for each droid. This should be accomplished using Polymorphism to reduce the amount of code needed.

All of the prices for the various aspects of a droid are left up to you to determine. If I was doing it though, I would proabably have a small set price for each of the following general options, and not get too specific to save time. ie, a price for: model(protocol, utility, etc.), material(Something Made up), option(One of the various option bools listed below. One price for all will work), numberOfLanguages, and numberOfShips, and that's it.

The program comes with an Interface IDroid that must be implemented by subclasses. It contains a public method called CalculateTotalCost, and a public Property called TotalCost that will get the total cost for a droid.

The program should have a base abstract class called Droid with the following variables, properties, constructors, methods, etc that implements the IDroid interface.

Droid:

* Variables: material (string), model (string), color (string), baseCost (decimal), totalCost (decimal)
* Constructors: 3 parameter constructor (string, string, string)
* Property: TotalCost to return the cost of the droid (Required by the interface)
* Methods:
	* ToString: return a formatted string containing the variables
	* CalculateBaseCost: Determines the baseCost based on material.
	* CalculateTotalCost: assigns baseCost to totalCost (Required by the interface)

There should be two derived classes from the abstract class Droid with appropriate variables, methods and properties.

Protocol:
* Variables: numberLanguages (int)
* Constant: costPerLanguage
* Constructors: 4 parameter constructor (string, string, string, int)
	* Uses the base class (Droid) constructor
* Methods:
	* ToString: return a formatted string containing the variables
	* CalculateTotalCost: Calculate the totalCost based on the number of languages and adds it to the base totalCost

Utility:
* Variables: toolbox (bool), computerConnection (bool), arm (bool)
* Constructors: 6 parameter constructor (string, string, string, bool, bool, bool)
	* Uses the base class (Droid) constructor
* Methods:
	* ToString: return a formatted string containing the variables
	* CalculateTotalCost: Calculates totalCost by calculating the cost of each selected option and add it to the base totalCost.

There should be two more derived classes from the class Utility with appropriate variables, methods and properties.

Janitor:
* Variables: trashCompactor (bool), vacuum (bool)
* Constructors: 8 parameter constructor (string, string, string, bool, bool, bool, bool, bool)
	* Uses the base class (Utility) constructor
* Methods:
	* ToString: return a formatted string containing the variables
	* CalculateTotalCost: Calculate totalCost by calculating the cost of each selected option and adds it to the base totalCost

Astromech:
* Variables: fireExtinquisher (bool), numberShips (int)
* Constant: costPerShip
* Constructors: 8 parameter constructor (string, string, string, bool, bool, bool, bool, int)
	* Uses the base class (Utility) constructor
* Methods:
	* ToString: return a formatted string containing the variables
	* CalculateTotalCost: Calculate totalCost by calculating the cost of each selected option and the cost based on the number of ships and adds both to the base CalculateTotalCost

You should put all of your UI into a UI class that will handle getting all of the necessary information from the Jawa, and display the feedback to the Jawa.

You should create a class for the collection of the Droids. It should have an add method that will do the work of determining which instance of a droid needs to be created and added to the array. The UI class will prompt for the needed information to add a droid, and then when it has all of the info, it will send it to the add method, which will then determine which type to add based on the 'model' that was entered. The add method might be a good place to do method overloading, though not required.

You should follow the concepts about inheritance talked about in class, and work hard at DRY (Don't Repeat Yourself) Principles.

Solution Must:
* Create abstract class Droid that implements IDroid
* Derive two classes (Protocol and Utility) from the class Droid
* Derive two classes (Janitorial and Astromech) from the class Utility
* Each derived class must either implement or override the ToString and CalculateTotalCost methods
* Create a UI class
* Create a DroidCollection class
* Use private, public and protected appropriately.
* Use abstract, virtual, and override appropriately.
* Have sufficient comments about what you are doing in the code.
