// Class:	CSE 1321L
// Section: 	08         
// Term:		Fall 2018  
// Instructor:	
// Name:		Sasha Angermueller
// Lab#:	    2


using System;

namespace Daimnd
{
    class Diamnd
    {
        static void Main(string[] args)
        {
            string s = "*";
            //Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("   " + s);
            Console.WriteLine("  " + s + " " + s);
            Console.WriteLine(" " + s + " " + s + " " + s);
            Console.WriteLine(s + " " + s + " " + s + " " + s);
            Console.WriteLine(" " + s + " " + s + " " + s);
            Console.WriteLine("  " + s + " " + s);
            Console.WriteLine("   " + s);
            Console.ReadLine();
        }
    }
}
