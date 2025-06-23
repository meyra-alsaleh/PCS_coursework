using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulation
{
    internal class Car
    {
        // Instance variables
        private string brand;
        private int currentSpeed = 0;
        private int maxSpeed;



        // Mehods
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public string AsAString()
        {
            return "Speed of my " + this.brand + " is " + this.currentSpeed + 
                " km/h and its maximum speed is " + this.maxSpeed + " km/h";
        }
        public void SpeedUp()
        {
            if (this.currentSpeed < this.maxSpeed)
            {
                this.currentSpeed += 7;

                if (this.currentSpeed > this.maxSpeed)
                {
                    this.currentSpeed = this.maxSpeed;
                }
            }
        }

        public void SlowDown()
        {
            if (this.currentSpeed > 0)
            {
                this.currentSpeed -= 10;

                if (this.currentSpeed < 0)
                {
                    this.currentSpeed = 0;
                }
            }
        }
    }
}
