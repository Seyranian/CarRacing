namespace CarRacing
{
    internal interface IQuestion
    {
        string WhatIsYourName();
        string WhatIsYourCarName();
        void StartGame(bool start);
        void WinAndEndGame();
    }
}
