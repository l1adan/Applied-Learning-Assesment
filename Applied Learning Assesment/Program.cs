using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applied_Learning_Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that asks the user to enter an integer.
            //If the integer is less than 10, print the message
            //"This number is too small". If the integer is greater than or equal to 10,
            //print "This number is big enough". 


             Console.WriteLine("Please neter a number.");    //Asking user for input.
             int userNumber = int.Parse(Console.ReadLine()); //Collecting and converting user input.

             if(userNumber < 10)                             //creating if statements to find whether the user's number is less than  or greater to 10.
             {
                 Console.WriteLine("This number is too small.");
             } 
             else if(userNumber >= 10)
             {
                 Console.WriteLine("This number is big enough.");
             }



            //2. Create a program that creates an array 
            //of five hard-coded floating-point values, then prints out
            //just the second value.

            float[] floats = { 3.1f, 5.3f, 6.3f, 4.2f, 5.5f };
            Console.WriteLine(floats[1]);



            //3. Modify the above program so that it uses a foreach loop
            //to display all the values in the array, all on one line.

             float[] floats1 = { 3.1f, 5.3f, 6.3f, 4.2f, 5.5f };      //Creating an array called [floats].

             int floatsTotal = floats1.Length;        //Finding total length of the  Array using .Length

             for (int i = 0; i < floatsTotal; i++)    //For loop.
             {
                 Console.Write(floats1[i] + " ");    //Printing i at the indice of floats to find the  contents of our Array.
             }




            // 4.Write a program that asks the user to enter an integer.
            //If the user enters '1', print "Only one?".If the user enters
            //'100', print "100? That's a lot!".If the user enters something
            //other than these two numbers, print "Input not recognized.".
            //The program should use a switch statement.

            Console.WriteLine("Please enter a number.");     //Asking user for input
            int userNum = int.Parse(Console.ReadLine());    // setting a variable for users entry

            switch (userNum)                                //creating a switch case
            {
                case 1:
                    Console.WriteLine("Only one?");
                    break;
                case 100:
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:
                    Console.WriteLine("Input not recognized.");
                    break;

            }











        }
        }
}
