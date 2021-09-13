using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformCar
{
    enum MyRang
    {
        Whilte,
        Black
    }
    enum MyBrand
    {
        Benz,
        Bmw
    }
    class Car
    {
        public string Name { get; set; }
        public MyRang Rang { get; set; }
        public MyBrand Brand { get; set; }
        public bool IsAutomatic { get; set; }

        private int vMotor;
        public bool IsGaz { get; set; }
        public MyDate ProductionDate { get; set; }

        private int maxSpeed;
        public int VMOTOR
        {
            get
            {
                return vMotor;
            }
            set
            {
                if (1100 <= value && value <= 3300)
                {
                    vMotor = value;
                }
                else
                {
                    vMotor = -1;
                }
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (1 <= value && value <= 300)
                {
                    maxSpeed = value;
                }
                else
                {
                    maxSpeed = 0;
                }
            }
        }



    }
}
