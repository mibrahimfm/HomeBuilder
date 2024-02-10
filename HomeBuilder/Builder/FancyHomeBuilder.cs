namespace HomeBuilder.Builder
{
    internal class FancyHomeBuilder : HouseBuilder
    {
        public FancyHomeBuilder()
        {
            Reset();
        }

        public override void AddDoors()
        {
            home.Doors = 8;
        }

        public override void AddGarage()
        {
            home.Garage = 4;
        }

        public override void AddRoof()
        {
            home.Roof = "Reinforced glass roof";
        }

        public override void AddSwimmingPool()
        {
            home.SwimmingPool = true;
        }

        public override void AddWalls()
        {
            home.Walls = 24;
        }

        public override void AddWindows()
        {
            home.Windows = 12;
        }
    }
}
