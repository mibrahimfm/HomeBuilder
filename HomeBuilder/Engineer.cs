using HomeBuilder.Builder;


namespace HomeBuilder
{
    public class Engineer
    {
        public void Build(HouseBuilder builder)
        {
            builder.AddWalls();
            builder.AddDoors();
            builder.AddWindows();
            builder.AddRoof();
            builder.AddGarage();
            builder.AddSwimmingPool();
        }
    }
}
