namespace HomeBuilder.Builder
{
    internal class FamilyHomeBuilder : HouseBuilder
    {
        public FamilyHomeBuilder()
        {
            Reset();
        }

        public override void AddDoors()
        {
            home.Doors = 3;
        }

        public override void AddGarage()
        {
            home.Garage = 2;
        }

        public override void AddRoof()
        {
            home.Roof = "Concrete roof";
        }

        public override void AddSwimmingPool()
        {
            home.SwimmingPool = true;
        }

        public override void AddWalls()
        {
            home.Walls = 10;
        }

        public override void AddWindows()
        {
            home.Windows = 4;
        }
    }
}
