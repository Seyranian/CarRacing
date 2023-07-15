namespace CarRacing
{
    internal class CarViewModel : IMove
    {
        private bool _gameOver;
        private readonly Car _car;

        public bool GameOver => _gameOver;
        public Car Car => _car;

        public CarViewModel(string carName)
        {
            this._car = new Car(carName);
            this._gameOver = false;

        }
        public void Move()
        {
            Console.SetCursorPosition(_car.CarPossition, 14);
            Console.Write(_car.CarAppearance);
            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.RightArrow)

                {
                    _car.CarPossition += 6;
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    _car.CarPossition -= 6;
                }
            }
            if (_car.CarPossition <= 0 || _car.CarPossition >= 48 - _car.CarAppearance.Length)
            {
                _gameOver = true;
            }
        }
    }
}
