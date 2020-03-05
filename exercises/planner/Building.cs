using System;

namespace planner
{
    public class Building
    {
        private string _designer = "William Green";
        private DateTime _dateConstructed;
        private string _address = "301 Plus Park Blvd";
        private string _owner = "John Wark";

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;

        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public override string ToString()
        {
            return ($"\n{_address}\n---------------\nDesigned by { _designer}\nConstructed on {_dateConstructed}\nOwned by {_owner}\n{Volume} cubic meters of space");
        }
    }

}
