using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    public class Program
    {
        int Rectanglelength;
        int Rectanglewidth;

        public void getRectangleValues()
        {
            Console.WriteLine("Enter the length on Rectangle");
            Rectanglelength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width on Rectangle");
            Rectanglewidth = Convert.ToInt32(Console.ReadLine());
        }
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
                       

                        switch (ans)
                        {
                            case 1:Console.WriteLine("Length of Rectangle:{0}", rectangle.GetLength());
                                break;

                            case 2:
                                Console.WriteLine("Enter new length ");
                                int length = Convert.ToInt32(Console.ReadLine());
                                if (length < 1)
                                {
                                    Console.WriteLine("Invalid Input");
                                    break;
                                }
                                rectangle.SetLength(length);
                                break;

                            case 3:
                                Console.WriteLine("Width of the Rectangle: {0}", rectangle.GetWidth());
                                break;
                            case 4:
                                Console.Write("Enter Width:");
                                int width = Convert.ToInt32(Console.ReadLine());
                                if (width < 1)
                                {
                                    Console.WriteLine("Invalid Input");
                                    break;
                                }
                                rectangle.SetWidth(width);
                                break;

                            case 5:
                                Console.WriteLine("Perimeter of Rectangle: {0}", rectangle.GetPerimeter());
                                break;
                            case 6:
                                Console.WriteLine("Area of Rectangle: {0}", rectangle.GetArea());
                                break;
                            case 7:
                                System.Environment.Exit(0);
                                break;
                            default: Console.WriteLine("Please enter Correct option from the above given options");
                                break;
                        }


                    } while(ans != 7);
                    
                Console.ReadLine();
                goto runLoopAgain;
                }
                else
                {
                    throw new Exception("Invalid values");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }
            
            

        }
    }
}
