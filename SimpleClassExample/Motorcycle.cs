using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        //new members to represent the name of the driver.
        public void SetDriverName(string name)
        {
            //These two statements are functionally the same
            driverName = name;
            this.driverName = name;
        }
        public void PopAWheely()
        {
            for (int i = 0;i<driverIntensity;i++)
            {
                Console.WriteLine("YEEEEEEE Haaaaaaawwwwwwwww!!");
            }
        }

        //
        //Put back the default constructor, which will set all data members to default values
        /*
        public Motorcycle() {}
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
        */

        //Constructor Chaining:
        public Motorcycle() {}
        public Motorcycle(int intensity)
            : this(intensity,"") { }
        public Motorcycle(string name)
            : this(0, name) { }
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
