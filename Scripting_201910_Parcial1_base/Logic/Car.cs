namespace Scripting_201910_Parcial1_base.Logic
{
    public class Car : Vehicle
    {
        public Car() : base()
        {
        }

        public Car(float _baseMaxSpeed) : base(_baseMaxSpeed)
        {
        }

        protected override VehicleType Type
        {
            get
            {
                return VehicleType.Car;
            }
        }
    }
}