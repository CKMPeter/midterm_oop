using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace midterm_test
{
    class Customer
    {
        //private var
        Vehicle rental;
        List<Order> orders= new List<Order>();
        string fullName;
        string id;
        string contact;
        int state;

        //constructor
        public Customer()
        {
            fullName = "";
            id = "";
            contact = "";
            state = 0;
        }
        public Customer(Vehicle rental, string fullName, string id, string contact, int duration) {
            this.fullName = fullName;
            this.id = id;
            this.contact = contact;
            if (rental.State == 0)
            {
                this.rental = rental;
                this.state++; //1. for rent.
                rental.State++; //1. for rent.
                Order tmp = new Order(rental, duration);
                orders.Add(tmp);
            }
        }

        //function
        public string Name
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public void printCusInfo() {
            Console.WriteLine("Name: " + fullName);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Contact: " + contact);
            if (state == 1)
            {
                Console.WriteLine("State: Rentting...\n");
                rental.Print();
            }else
                Console.WriteLine("State: Haven't Rent...\n");
        }

        public void returnRental() { // remove rentting status from customer and vehicle.
            if (this.state == 0) return;
            this.rental.State--; //from 1 to 0
            this.state--;
        }

        public void addRental(Vehicle rental, int duration) // assign rentting status and adding vehicle to the history of rentting.
        {
            if (this.state == 1 || rental.State == 1) {
                Console.WriteLine("Adding Operation Failed!");
                return; 
            } // check for whether if the customer is currently retting or the vehicle is available
            rental.State++;
            this.state++;   //from 0 to 1
            this.rental = rental;


            Order tmp = new Order(rental, duration);
            this.orders.Add(tmp);   


            Console.WriteLine("Successfully Added!");
        }

        public void printHistory()
        {
            Console.WriteLine("Rental History of " + id);
            for(int i = 0; i< orders.Count; i++)
            {
                Console.Write((i + 1) +" : ");
                orders[i].printOrder();
            }
        }

        public float TotalCost()
        {
            float sum = 0;
            for (int i = 0; i < orders.Count(); i++)
                sum += orders[i].total();
            return sum;
        }
    }
}
