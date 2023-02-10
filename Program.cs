/*
 * Author: Jan Gomez
 * Course: Comp 003A L01
 * Purpose: Running different loops statemetns for 
 * assignment 4
 * 
 */
namespace Comp003A.Assignment4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("".PadRight(50, '*'));
        Console.WriteLine("for-loop statement");
        Console.WriteLine("Output a right trianle based on user input");
        Console.WriteLine("".PadRight(50, '*'));

        Console.WriteLine("Enter a positive whole number:");

        // count psoitive integers and have output be increments of # for each
        // Users choice of integer.
        int limit = int.Parse(Console.ReadLine());

        string output = "#";
        // the output of # will be displayed by increments
        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine($" {output} ");
            output += "#";
        }

        Console.WriteLine("".PadRight(50, '*'));
        Console.WriteLine("foreach Section");
        Console.WriteLine("Output all of the friends in an array");
        Console.WriteLine("".PadRight(50, '*'));

        string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
        // making an array for the foreach code allows to list all names.

        foreach (var names in friends)
        {
            Console.WriteLine($"\t{names}");
        }
        Console.WriteLine("\n");
        Console.WriteLine("".PadRight(50, '*'));
        Console.WriteLine("do-while statement");
        Console.WriteLine("".PadRight(50, '*'));

        int counter = 0;
         // making a do while code with an increment of 5
         // looping stops once reached to 50
        do
        {
            Console.WriteLine($"\tCurrent counter: {counter}");
            counter += 5;
        } while (counter <= 50);

        Console.WriteLine("".PadRight(50, '*'));
        Console.WriteLine("foreach Section");
        Console.WriteLine("Whole loop Foo Bar assignment");
        Console.WriteLine("".PadRight(50, '*'));

        int counter2 = 1;

        // will be adding a nested if else staement to a while loop
        // the first if condition is priority and will ignore everything else
        // so had to do the latest option of divisible of 2 and 5 to not be ignored
        // if i made the first if ocding my last else if it would have only read the
        // first coding being divisible by 2
        while (counter2 <= 20)
        {
            if (counter2 % 2 == 0 && counter2 % 5 == 0)
            {
                Console.WriteLine($"\t(counter2): FooBar");
            }
            else if (counter2 % 5 == 0)
            {
                Console.WriteLine($"\t(counter2): Bar");
            }
            else if (counter2 % 2 == 0)
            {
                Console.WriteLine($"\t(counter2): Foo");
            }
            else
            {
                Console.WriteLine($"\t{counter2} ");
            }

            counter2++;
        }

        Console.WriteLine("Hello, World!");
    }
}

