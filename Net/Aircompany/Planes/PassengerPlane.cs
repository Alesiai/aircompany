﻿namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity,
            int passengersCapacity)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
        }

        public int PassengersCapacity { get; set; }

        public override string ToString()
        {
            return base.ToString().Replace("}", $", passengersCapacity = {PassengersCapacity} }}");
        }
    }
}