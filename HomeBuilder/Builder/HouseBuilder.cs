namespace HomeBuilder.Builder
{
    public abstract class HouseBuilder
    {
        protected Home home;
        
        public HouseBuilder()
        {
            Reset();
        }

        public virtual void Reset()
        {
            home = new Home();
        }

        public abstract void AddWalls();
        public abstract void AddDoors();
        public abstract void AddWindows();
        public abstract void AddRoof();
        public abstract void AddGarage();
        public abstract void AddSwimmingPool();
        public virtual string GetBuiltHouse()
        {
            return home.ToString();
        }
    }
}
