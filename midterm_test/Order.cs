using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_test
{
    internal class Order
    {
        Vehicle vehList;
        int duration;

        public Order(Vehicle A, int duration) {
            this.vehList = A;
            this.duration = duration;
        }

        public void printOrder()
        {
            vehList.Print();
            Console.WriteLine("Duration: " + duration);
        }

        public float total()
        {
            return (float)(vehList.DRental * this.duration);
        }
    }
}
