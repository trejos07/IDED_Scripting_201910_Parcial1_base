namespace Scripting_201910_Parcial1_base.Logic
{
    public class Muffler : Part
    {
        public Muffler() : base()
        {
        }

        public Muffler(float speedBonus) : base(speedBonus)
        {
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Bike;
            }
        }
    }
}