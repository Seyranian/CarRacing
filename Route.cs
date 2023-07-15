namespace CarRacing
{
    internal class Route : IDrow
    {
        private readonly int _routeLenght;
        private string _routeAppearance;
        private string _routeMidAppearance;
        public int Left { get; set; } = 1;
        public int Mid { get; set; } = 2;
        public int Top { get; set; } = 1;


        public Route()
        {
            _routeLenght = 48;
            ((IDrow)this).Drow();

        }
        public int RouteLenght => _routeLenght;
        public string RouteAppearance => _routeAppearance;
        public string RouteMidAppearance => _routeMidAppearance;
        void IDrow.Drow()
        {
            this._routeAppearance = $"|{new string(' ', 46)}|";
            this._routeMidAppearance = $"{new string(' ', 23)}|{new string(' ', 24)}";
        }
    }
}
