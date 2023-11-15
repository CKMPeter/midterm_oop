using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_test
{
    class Motocycle: Vehicle
    {
        //private var
        float engine;

        //constructor
        public Motocycle(): base(){
            engine = 0.0f;
        }
        public Motocycle(string uId, string make, string year, string model, float rental, float engine) : base(uId, make, year, model, rental) {
            this.engine = engine;  
        }

        //function
        public override void Print()
        {
            Console.WriteLine("Unique Id: " + uId);
            Console.WriteLine("Brand: " + make);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Daily rental cost: " + dRental);
            Console.WriteLine("Engine Displacement: " + engine);
        }
    }
}
