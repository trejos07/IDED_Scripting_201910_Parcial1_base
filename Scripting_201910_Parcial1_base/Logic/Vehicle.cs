using System;

namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        protected float baseMaxSpeed;

        protected int Level { get; set; }

        protected abstract VehicleType Type { get; }

        protected Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return baseMaxSpeed;
            }
        }

        public Vehicle()
        {
            Level = 0;
            CurrentPart = null;
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (Type == part.Type || part.Type == VehicleType.Any)
            {
                baseMaxSpeed = baseMaxSpeed+(baseMaxSpeed * part.SpeedBonus);
                baseMaxSpeed = Math.Clamp(baseMaxSpeed, 0, baseMaxSpeed * 1.5f);
            }

            return result;
        }

        public void Upgrade()
        {
            if(Level <3)
            {
                Level++;
                baseMaxSpeed = baseMaxSpeed + (baseMaxSpeed * 0.05f * Level);

                if (CurrentPart != null)
                {
                    CurrentPart.Upgrade();
                } 

            }


        }
    }
}