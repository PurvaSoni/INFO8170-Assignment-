using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            /// calling variables of rectangle class
            int rectlength = rectangle.Length;
            int rectwidth = rectangle.Width; 


           string length = string.Empty;
           string width = string.Empty;
       
           string enteredValue = string.Empty;

          bool validMenuSelection = false;
          while (validMenuSelection == false)
            {
                Console.WriteLine("1 Get Length of Rectangle");
                Console.WriteLine("2 Change Length of Rectangle");
                Console.WriteLine("3 Get Width of Rectangle");
                Console.WriteLine("4 Change Width of Rectangle");
                Console.WriteLine("5 to Get Rectangle Perimeter");
                Console.WriteLine("6 to Get Rectangle Area");
                Console.WriteLine("7 to Exit");

                enteredValue = Console.ReadLine();


                if (enteredValue == "1")
                {

                    Console.WriteLine("The Length of the rectangle is {0} ", rectangle.SetLength(rectlength));
                }

                else if (enteredValue == "2")
                {
                    Console.WriteLine("Please Enter new Length of the rectangle");
                    length = Console.ReadLine();
                    if ((rectlength <= 0) && (!int.TryParse(length, out rectlength)))
                    {
                        Console.WriteLine("Not a valid input.Please enter again");
                    }
                    else
                    {
                        Console.WriteLine("new length is {0} ", rectangle.SetLength(rectlength));

                    }
                }

                else if (enteredValue == "3")
                {
                    Console.WriteLine("The width of the rectagle is {0} ", rectangle.SetWidth(rectwidth));
                }

                else if (enteredValue == "4")
                {
                    Console.WriteLine("Please Enter new Width of the rectangle");
                    width = Console.ReadLine();

                    if ((rectwidth <= 0) && (!int.TryParse(width, out rectwidth)))
                    {
                        Console.WriteLine("Not a valid input.Please enter again");
                    }
                    else
                    {
                        Console.WriteLine("new width is {0} ", rectangle.SetWidth(rectwidth));
                    }
                }
                else if (enteredValue == "5")
                {
                    Console.WriteLine("Perimeter of the rectangle is {0} ", rectangle.GetParameter());
                }
                else if (enteredValue == "6")
                {
                    Console.WriteLine("Area of the rectangle is {0} ", rectangle.GetArea());
                }
                else if (enteredValue == "7")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Error! Input not valid. Please enter valid number");
                }
            }
        }
    }
}
 