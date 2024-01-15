namespace SquareProject.Client.Models
{
    public class Square
    {
        private double _side;
        public double Side
        {
            get => _side;
            set
            {
                if (value <= 0)
                    throw new SqueraSideCannotBeNagativOrZero(value + " méretre nem lehet megváltoztatni. A négyzetnek az oldala megmaradt " + _side + ".");
                else
                    _side = value;
            }
        }

        public Square(double side)
        {
            if (side <= 0)
                throw new SqueraSideCannotBeNagativOrZero(side + " oldalú négyzet nem létezik. A négyzet nem hozható létre.");
            else
                _side = side;


        }

        public double Perimeter
        {
            get => 4 * _side;
        }

        public double Area
        {
            get => _side * _side;
        }

        public override string ToString()
        {
            return $"{Side} méter a négyzetnek az oldala.\nKerülete {Area}.\nTerülete {Area}.";
        }

    }
}

