using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_test
{
    class Car: Vehicle
    {
        //private var
        int seat;

        //constructor
        public Car(): base() { 
            seat = 0;
        }
        public Car(string uId, string make, string year, string model, float dRental, int seat) : base(uId, make, year, model, dRental) { 
            this.seat = seat;
        }

        //function
        public override void Print()
        {
            Console.WriteLine("Unique Id: " + uId);
            Console.WriteLine("Brand: " + make);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Daily rental cost: " + dRental);
            Console.WriteLine("Number of seat: " + seat);
        }
    }
}
