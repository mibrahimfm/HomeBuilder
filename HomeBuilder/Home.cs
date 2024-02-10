namespace HomeBuilder
{
    public class Home
    {
        public int Walls { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public string Roof { get; set; }
        public int Garage { get; set; }
        public bool SwimmingPool { get; set; }

        public override string ToString()
        {
            string spText = SwimmingPool ? "no" : "a";
            return $"Home with {Walls} walls, {Doors} doors, {Windows} windows, a {Roof}, {Garage} garage parking spots and {spText} swimming pool";
        }
    }
}
