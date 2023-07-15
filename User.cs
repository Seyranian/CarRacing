namespace CarRacing
{
    internal class User
    {
        private readonly int _userId;
        private readonly string _userName;
        private int _bestWin;

        public User(int userId, string userName, int bastWin)
        {
            this._userId = userId;

            if (userName == "") this._userName = "User1";
            else this._userName = userName;

            if (bastWin < 0) this._bestWin = 0;
            else this._bestWin = bastWin;
        }

        public int UserId => _userId;
        public string UserName => _userName;

        public int BanWin
        {
            get => _bestWin;
            set
            {
                if (value < 0) value = 0;
                _bestWin = value;
            }
        }

    }
}
