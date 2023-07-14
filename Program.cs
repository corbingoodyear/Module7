//Corbin Goodyear
//This program ask the user to enter in certain parameters for shapes and then returns what the user inputted using a interface
//July 12, 2023
using System;

namespace Module7
{
    interface Shapes
    {
        //initializes parameteres for shapes
        float length(); 
        float width();
        float area();
    }
    //Takes in input about the parameters of a square
    class Square : Shapes
    {
        float sl, sw, sa;
        public float length()
        {
            //asks user to enter length of Square and saves in sl...catches all bad data
            Console.Write("Enter the length of the square: ");
            try
            {
                sl = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number!");
            }
            return sl;
        }
        public float width()
        {
            //asks user to enter width of Square and saves in sw...catches all bad data
            Console.Write("Enter the width of the square: ");
            try
            {
                sw = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number!");
            }
            return sw;
        }
        public float area()
        {
            //asks user to enter area of Square and saves in sa...catches all bad data
            Console.Write("Enter the area of the square: ");
            try
            {
                sa = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number!");
            }
            return sa;
        }
    }
    //Takes in input about the parameters of a rectangle
    class Rectangle : Shapes
    {
        float rl, rw, ra;
        public float length()
        {
            //asks user to enter length of rectangle and saves in rl...catches all bad data
            Console.Write("Enter the length of the rectangle: ");
            try
            {
                rl = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number!");
            }
            return rl;
        }
        public float width()
        {
            //asks user to enter width of rectangtle and saves in rw...catches all bad data
            Console.Write("Enter the width of the rectangle: ");
            try
            {
                rw = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number!");
            }
            return rw;
        }
        public float area()
        {
            //asks user to enter area of rectangle and saves in ra...catches all bad data
            Console.Write("Enter the area of the rectangle: ");
            try
            {
                ra = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number!");
            }
            return ra;
        }
    }
    class ShapesResults
    {
        //creates objects of squares and rectangles and prints out all information that user entered
        static void Main(string[] args)
        {
            Square sq1 = new Square();
            Square sq2 = new Square();
            Square sq3 = new Square();
            float squareLength = sq1.length();
            float squareWidth = sq2.width();
            float squareArea = sq3.area();
            Rectangle rec4 = new Rectangle();
            Rectangle rec5 = new Rectangle();
            Rectangle rec6 = new Rectangle();
            float recLength = rec4.length();
            float recWidth = rec5.width();
            float recArea = rec6.area();
            Console.WriteLine("You said the length of the square was: " + squareLength);
            Console.WriteLine("You said the width of the square was: " + squareWidth);
            Console.WriteLine("Area of Square is: " + squareArea);
            Console.WriteLine("You said the length of the rectangle was: " + recLength);
            Console.WriteLine("You said the width of the rectangle was: " + recWidth);
            Console.WriteLine("Area of Rectangle is: " + recArea);
        }
    }
}
