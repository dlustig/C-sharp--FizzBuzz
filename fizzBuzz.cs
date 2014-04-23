//Daniel Lustig
//4/22/2014

//Language: C#
//FizzBuzz example program 
//This program demonstrates a simple task of running through a list of numbers -
// - dividing by 3, 5, or both to find the remainder (modulus). Depending on -
// - the resulting answer either the number, Fizz, Buzz, or FizzBuzz will be displayed.

using System;
using System.Threading;

class FizzBuzz {
    static void Main() {


    	Console.WriteLine("1. Normal FizzBuzz");
    	Console.WriteLine("2. Dynamic loop FizzBuzz");
        Console.WriteLine("3. Recursive FizzBuzz");
    	Console.WriteLine("4. Multi-threaded FizzBuzz");
    	Console.WriteLine("\nPlease enter your choice of FizzBuzz options: (1-4)");

    	//user input
    	int answer = int.Parse(Console.ReadLine());

    	//switch statement
    	switch (answer){
    		//normal fizzbuzz function
    		case 1:
    			normalFizzBuzz();
    			break;
    		//dynamic fizzbuzz function
    		case 2:
    			Console.WriteLine("please enter a number greater than 1");
    			int fizzBuzzLength = int.Parse(Console.ReadLine());
    			dynamicFizzBuzz(fizzBuzzLength);
    			break;
    		//recursive fizzbuzz function
            case 3:
                recursiveFizzBuzz(1);
                break;
            //multithreaded fizzbuzz function - also extra class call
    		case 4:
    			threadedFizzBuzz();
    			break;
    		//default switch option
    		default:
    			Console.WriteLine("Not an option. Stop trying to break my program");
    			break;
    	}

    }
    //This is the normal fizzBuzz function. There is nothing special or abnormal here
    static void normalFizzBuzz() {
        for (int n = 1; n <= 100; n ++) {
            if (n % 15 == 0) {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0) {
                Console.WriteLine("Buzz");
            }
            else {
                Console.WriteLine(n);
            }
        }
    }

    //This function shows a dynamic looped fizzBuzz. Essentially the same as the normal
    //with the exception that the user can choose the length of the program
    //parameter: length: user inputed ending length of fizzBuzz
    static void dynamicFizzBuzz(int length) {
        for (int n = 1; n <= length; n ++) {
            if (n % 15 == 0) {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0) {
                Console.WriteLine("Buzz");
            }
            else {
                Console.WriteLine(n);
            }
        }
    }

    //this function displays a recursive version of FizzBuzz.
    //parameter: number: This value will be evaluated with modulus 3,5, and 15
    static void recursiveFizzBuzz(int number) {
            if (number <= 99) {
                recursiveFizzBuzz(number + 1);
            }
            {
                if (number % 15 == 0) {
                Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(number);
                }
            }

            
    }

    //this fucntion demonstrates multithreading in the fizzbuzz program
    //Two threads are statically created (a,b) and started essentially at the same time
    static void threadedFizzBuzz() {
    	Thread a = new Thread(new ThreadStart(MyThread.Thread1));
    	Thread b = new Thread(new ThreadStart(MyThread.Thread2));
    	a.Start();
    	b.Start();
	}
}
	//This class fills the functionality of FizzBuzz.
	public class MyThread {

		//The first thread runs from 1-50
        public static void Thread1() {
        	for (int n = 1; n <= 50; n ++) {
	            if (n % 15 == 0) {
	                Console.WriteLine("{0}: FizzBuzz", n);
	                
	            }
	            else if (n % 3 == 0) {
	                Console.WriteLine("{0}: Fizz", n);
	                
	            }
	            else if (n % 5 == 0) {
	                Console.WriteLine("{0}: Buzz", n);
	                
	            }
	            else {
	                Console.WriteLine(n);
	            }
	        }
	    }

	    //the second thread runs from 51-100
        public static void Thread2() {
        	for (int n = 51; n <= 100; n ++) {
	            if (n % 15 == 0) {
	                Console.WriteLine("({0}: FizzBuzz)", n);
	                
	            }
	            else if (n % 3 == 0) {
	                Console.WriteLine("({0}: Fizz)", n);
	                
	            }
	            else if (n % 5 == 0) {
	                Console.WriteLine("({0}: Buzz)", n);
	                
	            }
	            else {
	                Console.WriteLine("({0})", n);
	            }
	        }
        }
    }

