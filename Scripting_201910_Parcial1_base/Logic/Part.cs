using System;

namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;
        private float durability;

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return speedBonus * Durability; }
            protected set { speedBonus = value; }
        }

        protected float Durability { get => durability; set => durability = Math.Clamp(value,0,1); }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
        }

        public void Upgrade()
        {
            if(Level < 3)
            {
                Level++;
                SpeedBonus = SpeedBonus + (SpeedBonus * 0.03f * Level); 
            }
                


        }
    }
}