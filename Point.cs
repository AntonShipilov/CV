    class Point
    {
        private int xPos;
        private int yPos;
        public Point(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
        public void Describe()
        {
            Console.WriteLine("Coordinates are: {0}, {1}", xPos, yPos);
        }
    }
