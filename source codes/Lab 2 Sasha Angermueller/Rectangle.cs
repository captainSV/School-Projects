// Class:	CSE 1321L
// Section: 	08         
// Term:		Fall 2018  
// Instructor:	
// Name:		Sasha Angermueller
// Lab#:	    2

using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            int width,height,area, perimiter;
            width = 4;
            height = 8;
            area = width * height;
            perimiter = (width * 2) + (height * 2);
            Console.WriteLine("The width: " + width);
            Console.WriteLine("The height: " + height);
            Console.WriteLine("The area: " + area);
            Console.WriteLine("The perimeter: " + perimiter);
            Console.ReadLine();
        }
    }
}
