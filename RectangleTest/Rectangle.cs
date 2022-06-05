using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    public class Rectangle
    {
        //Declaring Variable
        private int Rectanglelength;
        private int Rectanglewidth;

        public Rectangle()
        {
            Rectanglelength = 1;
            Rectanglewidth = 1;
        }

        public Rectangle(int Rectanglelength, int Rectanglewidth)
        {
            this.Rectanglelength = Math.Abs(Rectanglelength);
            this.Rectanglewidth = Math.Abs(Rectanglewidth);
        }
        //Function 1 to GetLength of rectangle
        public int GetLength()
        {
            return Rectanglelength;
        }
        //Function 2 to SetLength of rectangle
        public int SetLength(int Rectanglelength)
        {
            this.Rectanglelength=Rectanglelength;
            if (Rectanglelength < 1)
            {
                throw new Exception("Invalid Input by user");
            }
            return Rectanglelength;
        }
        //Function 3 to GetWidth of rectangle
        public int GetWidth()
        {
            return Rectanglewidth;
        }

        //Function 4 to SetWidth of rectangle
        public int SetWidth(int Rectanglewidth)
        {
            this.Rectanglewidth = Rectanglewidth;
            if (Rectanglewidth < 1)
            {
                throw new Exception("Invalid Input");
            }
            return Rectanglewidth;
        }
        //Function 5 to GetPerimeter of rectangle
        public int GetPerimeter()
        {
            int perimeter = 2 * (Rectanglelength + Rectanglewidth);

            if(Rectanglelength == 0 || Rectanglewidth == 0)
            {
                throw new Exception("Incorrect Rectangle Length and Width");
            }
            return perimeter;
        }
        //Function 6 to GetArea of rectangle
        public int GetArea()
        {
            int area = Rectanglelength * Rectanglewidth;
            if(Rectanglelength == 0 || Rectanglewidth == 0)
            {
                throw new Exception("Incorrect Rectangle Length and Width");
            }
            return area;
        }
    }
}
