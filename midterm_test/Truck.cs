using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_test
{
    class Truck: Vehicle
    {
        //private var
        float cargo;

        //constructor
        public Truck(): base() {
            cargo = 0.0f;
        }
        public Truck(string uId, string make, string year, string model, float rental, float cargo) : base(uId, make, year, model, rental) { 
            this.cargo = cargo;
        }

        //function
        public override void Print()
        {
            Console.WriteLine("Unique Id: " + uId);
            Console.WriteLine("Brand: " + make);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Daily rental cost: " + dRental);
            Console.WriteLine("Cargo space: " + cargo);
        }
    }
}
