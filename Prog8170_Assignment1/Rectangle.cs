using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment1
{
    public class Rectangle
    {
      
        private int length;
        private int width;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public Rectangle()
        {
        }
        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int GetLength()
        {
            return Length;
        }
        public int SetLength(int length)
        {
            this.Length = length;
            return this.Length;

        }
        public int GetWidth()
        {
            return Width;
        }
        public int SetWidth(int width)
        {
            this.Width = width;
            return this.Width;
        }
        public int GetParameter()
        {
            return (length+width) * 2;
        }
        public int GetArea()
        {
            return Length * Width;
        }
    }
}
