using System.Timers;

namespace CarRacing
{
    internal class ConsoleViewModel : IQuestion
    {
        private readonly System.Timers.Timer _timer;
        private readonly ConsoleComands _kConsole;

        public ConsoleViewModel()
        {
            _timer = new System.Timers.Timer(60000);
            string name = ((IQuestion)this).WhatIsYourName();
            string carName = ((IQuestion)this).WhatIsYourCarName();
            _kConsole = new ConsoleComands(name, carName);
            ((IQuestion)this).StartGame(true);
        }

        public ConsoleComands KConsole { get { return _kConsole; } }

        public void WinAndEndGame()
        {
            _timer.Elapsed += TimerElapsed;
            _timer.Start();
            // Console.WriteLine("Waiting for 60 seconds...");
            Console.ReadLine();



        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            Console.Clear();
            Console.WriteLine("You win!");
            Console.ReadLine();
            Environment.Exit(0);
        }
        void IQuestion.StartGame(bool start)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please press enter to play the game");
            Console.ReadLine();
            Console.Clear();


        }

        string IQuestion.WhatIsYourCarName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your car name:");
            string carName = Console.ReadLine();
            return carName;
        }

        string IQuestion.WhatIsYourName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }




    }
}
