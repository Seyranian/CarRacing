namespace CarRacing
{
    internal class Car : IDrow
    {
        private readonly string _carName;
        private string _carAppearance;
        public int CarPossition { get; set; } = 14;
        public string CarName => _carName;
        public string CarAppearance => _carAppearance;

        public Car(string carName)
        {
            if (carName == "") this._carName = "Defult Car";
            else this._carName = carName;
            ((IDrow)this).Drow();
        }

        void IDrow.Drow()
        {
            this._carAppearance = $"|***{this._carName}***|";

        }
    }
}
