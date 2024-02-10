namespace HomeBuilder.Builder
{
    public class BasicHomeBuilder : HouseBuilder
    {
        public BasicHomeBuilder()
        {
            Reset();
        }

        public override void AddDoors()
        {
            home.Doors = 1;
        }

        public override void AddGarage()
        {
            home.Garage = 0;
        }

        public override void AddRoof()
        {
            home.Roof = "Brick roof";
        }

        public override void AddSwimmingPool()
        {
            home.SwimmingPool = false;
        }

        public override void AddWalls()
        {
            home.Walls = 4;
        }

        public override void AddWindows()
        {
            home.Windows = 2;
        }
    }
}
