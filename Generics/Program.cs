using System;
using System.IO;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T". Set a constraint to for the type so that T must conform to IStorable.
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Boxes". The second class called "Food". Both classes will conform to IStoreable interface.
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Boxes>". The second instance will hold "<food>".
        //TODO create some instanes of type Food and Equipment and Add them the correct storage bins.


  




        static void Main(string[] args)
        {

            //generics
            var food1 = new Food();
            var food2 = new Food();
            var food3 = new Food();
            var boxStorage = new Storage<Food>(food1,food2,food3);


            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            var foodStorage = new Storage<Box>(box1,box2,box3);


            //extension Methods
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            numbers = numbers.SortArray();

            string fruit = "berry";

            fruit = fruit.Pluralize();





        }
      

        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create a static extension method called "pluralize" this method should take a string and add an s to the end of it. (***BONUS*** if string ends in y you can replace y with ies to pluralize it)

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement to OrderBy.
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
