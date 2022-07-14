using System;
using System.Collections.Generic;
using System.Text;

namespace T02.VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double TruckFuelConsumptionIncrement = 1.6;
        private const double RefuelCoeffiecient = 0.95;

        //TODO: Fix truck Refuel (950 -> 1000) and Fuel Quantity.
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        protected override double FuelConsumptionModifier
            => TruckFuelConsumptionIncrement;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelCoeffiecient);
        }
    }
}
