    class Square
    {
        private Random rnd;
        private int xSide;
        private int ySide;
        private int pS;
        private List<Plitochka> plArr;
        public Square(int x, int y, int plSize)
        {
            xSide = x;
            ySide = y;
            plArr = new List<Plitochka>();
            PlitochkaPopulate(xSide, ySide, plSize);
            rnd = new Random();
            pS = plSize;
        }
        private void PlitochkaPopulate(int x, int y, int plSize)
        {
            for (int i = 0; i < x/plSize; i++)
            {
                for (int j = 0; j < y/plSize; j++)
                {
                    plArr.Add(new Plitochka(i, j));
                }
            }
        }
        public void RandomHeight()
        {            
            foreach (Plitochka p in plArr)
            {
                if (rnd.Next(10) > 2)
                {
                    p.SetHeight(rnd.Next(-10, 10));
                }
            }
        }
        public string WheresWater()
        {
            int ans = plArr.Count(h => h.GetHeight() <= 0);
            return string.Format("Всего плиток: {0}\nПлиток под водой: {1}\nПлощадь плиток под водой: {2}", plArr.Count, ans, ans*(pS*pS));            
        }
    }
