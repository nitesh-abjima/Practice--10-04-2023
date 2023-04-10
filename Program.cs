using System;
using System.Collections;
using System.Xml.Linq;

namespace ArrayCollection
{
    class Program
    {
        public static void Main()
        {

            // declares an Array of integers.
            int[] intArray;

            // allocating memory for 5 integers.
            intArray = new int[5];

            // initialize the first elements
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements
            // using for loop
            Console.Write("For loop :");
            for (int i = 0; i < intArray.Length; i++)
                Console.Write(" " + intArray[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop
            foreach (int i in intArray)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop
            int j = 0;
            while (j < intArray.Length)
            {
                Console.Write(" " + intArray[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop
            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);

            Console.WriteLine("");

            // List

            List<string> languages = new List<string>() { "Python", "Java" };

            // access the first and second elements of languages list
            Console.WriteLine("The first element of the list is " + languages[0]);
            Console.WriteLine("The second element of the list is " + languages[1]);

            //Insert element in a list
            languages.Insert(2, "JavaScript");

            // display element at index 2
            Console.WriteLine("The inserted element of the list is " + languages[2]);

            // Add Elements to List

            List<string> country = new List<string>() { "Russia" };

            country.Add("USA");

            country.Add("Japan");

            // iterate through the country list  
            for (int i = 0; i < country.Count; i++)
                Console.WriteLine(country[i]);

            //Remove element from the list

            var car = new List<string>() { "BMW", "Tesla", "Suzuki", "Tesla", "Hyundai", "Thar", "Mustang" };

            car.Remove("Tesla");

            car.Remove("Suzuki");

            car.RemoveAt(4);

            // print the updated list after removing   
            for (int i = 0; i < car.Count; i++)
            {
                Console.WriteLine(car[i]);
            }

            // ArrayList 
            ArrayList myList = new ArrayList();

            myList.Add("Jimmy");                     //Adding elements
            myList.Add("Blake");
            myList.Add("Taylor");
            myList.Add(25);

            Console.WriteLine("Before Inserting: " + myList[1]);

            // Insert in arraylist
            myList.Insert(1, "Tim");

            Console.WriteLine("After Inserting: " + myList[1]);

            // access elements

            Console.WriteLine("First element: " + myList[3]);

            Console.WriteLine("Second element: " + myList[4]);

            // Iterate ArrayList 
            ArrayList myList1 = new ArrayList();

            myList1.Add("Science");
            myList1.Add(true);
            myList1.Add(5);

            // display every element of myList 
            for (int i = 0; i < myList1.Count; i++)
            {
                Console.WriteLine(myList1[i]);
            }
            
            //Remove arraylist element

            ArrayList myList2 = new ArrayList();
            myList2.Add("Jack");
            myList2.Add(4);
            myList2.Add("Jimmy");

            // remove "Jack" from myList
            myList2.Remove("Jack");

            // iterate through myList after removing "Jack"
            for (int i = 0; i < myList2.Count; i++)
            {
                Console.WriteLine(myList2[i]);
            }

            //Dictionary

            Dictionary<string, string> car1 = new Dictionary<string, string>();

            // add items to dictionary
            car1.Add("Model", "Hyundai");
            car1.Add("Price", "36K");
            car1.Add("Color", "White");
            car1.Add("Engine", "4951cc");

            // iterate through the car dictionary 
            foreach (KeyValuePair<string, string> items in car1)
            {
                Console.WriteLine("{0} : {1}", items.Key, items.Value);
            }

            // Change dictionary elements

            Console.WriteLine("Value of Model before changing: " + car1["Model"]);

            car1["Model"] = "Maruti";

            Console.WriteLine("Value of Model after changing: " + car1["Model"]);

            //Remove elements from dictionary

            car1.Remove("Color");

            Console.WriteLine("\nModified Dictionary :");

            // iterate through the modified dictionary 
            foreach (KeyValuePair<string, string> items in car1)
            {
                Console.WriteLine("{0} : {1}", items.Key, items.Value);
            }

        }

    }
}