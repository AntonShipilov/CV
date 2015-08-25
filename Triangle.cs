    public class Triangle
    {
        private int _kat1;
        private int _kat2;
        private int _gep;
        public Triangle(int kat1, int kat2, int gep)
        {
            _kat1 = kat1;
            _kat2 = kat2;
            _gep = gep;
        }
        public int GetSquare()
        {
            int _square;
            _square = ((_kat1 * _kat2) / 2);
            return _square;
        }
    }
