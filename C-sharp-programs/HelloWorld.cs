// Program to print 'Hello world' in c Sharp
using System;

namespace HelloWorld
{
    //name of the class is must to be similler to the name of the file.
    //every c sharp file is also the c sharp class. 
    class HelloWorld
    {
        // Main Method is an entry point for c# code is the Main() method. 
        // the main method is always present in a c# exe file.
        // Static keyword means that the main method can be called without an object.
        //The void keyword means that this method doesn't return of value.
        //main is name of the method.
        //args means argument. 
        static void Main(String[] args)
        {
            //this are two ways to print Hello World.
            System.Diagnostics.Debug.WriteLine("Hello World");
            Console.WriteLine("Hello World");
        }
    }
}