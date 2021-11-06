using System;

namespace OpdrachtRectangle
{
    class Rectangle
    {
        private int x, y, width, height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rectangle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = this.height = size;
        }

        public Rectangle(int width, int height)
        {
            this.x = this.y = 0;
            this.width = width;
            this.height = height;
        }

        public Rectangle(int size)
        {
            this.x = this.y = 0;
            this.width = this.height = size;
        }

        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsSquare()
        {
            if (this.width == this.height) return true;
            return false;
        }

        public void Set(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetPosX()
        {
            return this.x;
        }

        public int GetPosY()
        {
            return this.y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 60);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.Set(100, 100, rechthoek.GetWidth(), rechthoek.GetHeight());
        }
    }
}
