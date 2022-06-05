using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    public class Program
    {
        //Decalring Variables
        int Rectanglelength;
        int Rectanglewidth;
        //Taking input from user
        public void getRectangleValues()
        {
            Console.WriteLine("Enter the length on Rectangle");
            Rectanglelength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width on Rectangle");
            Rectanglewidth = Convert.ToInt32(Console.ReadLine());
        }
        //Displaying Menu options
       public int displaySelectMenuOptions()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("ENter your selected choice");
            int answer = Convert.ToInt32(Console.ReadLine());   

            return answer;
        }
        //Main function
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Program program = new Program();

            int ans;

        runLoopAgain:
            program.getRectangleValues();

       

            try
            {
                if(program.Rectanglelength >0 && program.Rectanglewidth > 0)
                {
                    do
                    {
                       //program.displaySelectMenuOptions();
                       ans = program.displaySelectMenuOptions();
                       
                        //Using SwitchCase to switch between user inputs
                        switch (ans)
                        {
                            //To display the length of rectangle
                            case 1:Console.WriteLine("Length of Rectangle:{0}", rectangle.GetLength());
                                break;
                            //To enter ew length of rectangle
                            case 2:
                                Console.WriteLine("Enter new length for Rectangle");
                                int length = Convert.ToInt32(Console.ReadLine());
                                if (length < 1)
                                {
                                    Console.WriteLine("Invalid Input by user");
                                    break;
                                }
                                rectangle.SetLength(length);
                                break;
                            //To displaying the width of rectangle
                            case 3:
                                Console.WriteLine("Width of Rectangle: {0}", rectangle.GetWidth());
                                break;
                                //To set new width for rectangle
                            case 4:
                                Console.Write("Enter Width for this rectangle:");
                                int width = Convert.ToInt32(Console.ReadLine());
                                if (width < 1)
                                {
                                    Console.WriteLine("Invalid Input by user");
                                    break;
                                }
                                rectangle.SetWidth(width);
                                break;
                                //To calculate the perimeter of rectangle
                            case 5:
                                Console.WriteLine("Perimeter of this Rectangle: {0}", rectangle.GetPerimeter());
                                break;
                                //To calculate Area of rectangle
                            case 6:
                                Console.WriteLine("Area of this Rectangle: {0}", rectangle.GetArea());
                                break;
                                //To exit the program
                            case 7:
                                System.Environment.Exit(0);
                                break;
                                //Default switch case
                            default: Console.WriteLine("Please enter Correct option from the above given options");
                                break;
                        }


                    } while(ans != 7);
                    
                Console.ReadLine();
                    //Jumping back to the top to show user the Menu again
                goto runLoopAgain;
                }
                else
                {
                    throw new Exception("Invalid value entered by user");
                }
            }
            //Catching exceptions
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }
            
            

        }
    }
}
