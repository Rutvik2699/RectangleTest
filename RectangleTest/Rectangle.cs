using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    public class Rectangle
    {
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

        public int GetLength()
        {
            return Rectanglelength;
        }

        public int SetLength(int Rectanglelength)
        {
            this.Rectanglelength=Rectanglelength;
            if (Rectanglelength < 1)
            {
                throw new Exception("Invalid Input by user");
            }
            return Rectanglelength;
        }

        public int GetWidth()
        {
            return Rectanglewidth;
        }


        public int SetWidth(int Rectanglewidth)
        {
            this.Rectanglewidth = Rectanglewidth;
            if (Rectanglewidth < 1)
            {
                throw new Exception("Invalid Input");
            }
            return Rectanglewidth;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * (Rectanglelength + Rectanglewidth);

            if(Rectanglelength == 0 || Rectanglewidth == 0)
            {
                throw new Exception("Incorrect Rectangle Length and Width");
            }
            return perimeter;
        }

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
