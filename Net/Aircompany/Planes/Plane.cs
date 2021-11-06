namespace Aircompany.Planes
{
    public abstract class Plane
    {
        protected Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }

        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxFlightDistance { get; set; }
        public int MaxLoadCapacity { get; set; }

        public override string ToString()
        {
            return
                $@"Plane {{ mode = '{Model}', maxSpeed = {MaxSpeed}, maxFlightDistance = {MaxFlightDistance}, maxLoadCapacity = {MaxLoadCapacity} }}";
        }
    }
}