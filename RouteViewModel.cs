namespace CarRacing
{
    internal class RouteViewModel : IMove, IChangeColors
    {
        private readonly Route _route;
        private readonly Random _random;

        public RouteViewModel()
        {
            this._route = new Route();
            this._random = new Random();

        }
        public int Mid { get; set; }
        public int Left { get; set; }

        public void Move()
        {
            Console.SetCursorPosition(_route.Top, _route.Left);

            _route.Left += 2;

            Console.WriteLine(this._route.RouteAppearance);

            Console.SetCursorPosition(_route.Top, _route.Mid++);
            Console.WriteLine(this._route.RouteMidAppearance);


            if (_route.Left == 27) _route.Left = 1;

            if (_route.Mid == 26) _route.Mid = 2;
        }

        public void ChangeColor(ref int tmp)
        {
            if (_route.Left == tmp + 1) Console.ForegroundColor = ConsoleColor.Green;
            else if (_route.Left == tmp + 2) Console.ForegroundColor = ConsoleColor.White;

            else if (_route.Left == tmp + 3) Console.ForegroundColor = ConsoleColor.Cyan;
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                tmp = _route.Left + _random.Next(0, 3);
            }
        }
    }
}
