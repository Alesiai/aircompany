using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType PlaneType;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity,
            MilitaryType planeType)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PlaneType = planeType;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}", $", planeType = {PlaneType} }}");
        }
    }
}