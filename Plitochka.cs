    class Plitochka
    {
        private int plHeight;
        private Point _Pos;
        public Plitochka(int x, int y, int height = 0)
        {
            plHeight = height;
            _Pos = new Point(x, y);           
        }
        public void SetHeight(int h)
        {
            plHeight = h;
        }
        public int GetHeight()
        {
            return plHeight;
        }
        public Point GetPoint()
        {
            return _Pos;
        }

    }
