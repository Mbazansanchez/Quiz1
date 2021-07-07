using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1
{
    class Gforce
    {
        
        double Mass1;
        double Mass2;
        double Distance;
        double GraviForce;

       public void SetMass1(double value)
        {
            this.Mass1 = value;
        }


        public double GetMass1()
        {
            return Mass1;
        }

        public void SetMass2(double value)
        {
            this.Mass2 = value;

        }

        public double GetMass2()
        {
            return Mass1;
        }

        public void SetDistance(double value)
        {
            this.Distance = value;
        }

        public double GetDistance()
        {
            
            return Distance;
        }


        private void setGraviForce()
        {
            
            double G = 6.67408 * Math.Pow(10, -11);
            GraviForce = G * Mass1 * Mass2 / Math.Pow(Distance, 2); 
        }

        public double GetGraviForce()
        {
            setGraviForce();
            return GraviForce;
        }
    }
}
