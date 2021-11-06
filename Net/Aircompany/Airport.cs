using System.Collections.Generic;
using System.Linq;
using Aircompany.Models;
using Aircompany.Planes;

namespace Aircompany
{
    public class Airport
    {
        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<Plane> Planes { get; set; }

        public List<T> GetPlanes<T>() where T : class
        {
            var answeredPlanes = new List<T>();

            foreach (var plane in Planes)
                if (plane.GetType() == typeof(T))
                    answeredPlanes.Add(plane as T);

            return answeredPlanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPlanes<PassengerPlane>().OrderByDescending(x => x.PassengersCapacity).First();
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return GetPlanes<MilitaryPlane>().Where(x => x.PlaneType == MilitaryType.Transport).ToList();
        }

        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(w => w.MaxFlightDistance));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(w => w.MaxSpeed));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(w => w.MaxLoadCapacity));
        }

        public override string ToString()
        {
            return $"Airport {{ planes = {string.Join(", ", Planes.Select(x => x.Model))} }}";
        }
    }
}