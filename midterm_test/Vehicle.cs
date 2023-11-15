using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_test
{
    abstract class Vehicle
    {
        protected string uId;
        protected string make;
        protected string year;
        protected string model;
        protected float dRental;
        protected int state;

        //constructor
        public Vehicle() {
            this.uId = "";
            this.make = "";
            this.year = "";
            this.model = "";
            this.dRental = 0.0f;
            this.state = 0;
        }

        public Vehicle(string uId, string make, string year, string model, float rental) {
            this.uId = uId;
            this.make = make;
            this.year = year;
            this.model = model;
            this.dRental = rental;
        }
        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public float DRental
        {
            get { return dRental; }
            set { dRental = value; }
        }
        public abstract void Print();
    }
}
