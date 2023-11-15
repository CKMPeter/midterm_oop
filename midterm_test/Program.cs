using System.Collections;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace midterm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string uId, string make, string year, string model, float rental, int seat

            //vehicle.
            //Cars.
            Car car1 = new Car("1", "Honda", "2003", "A1", 12.5f, 4);
            Car car2 = new Car("2", "Mazda", "2004", "A2", 15.5f, 7);
            Vehicle[] carList = { car1, car2 };
            //Trucks
            Truck truck = new Truck("1", "Kenworth", "2015", "a1b2", 30.5f, 100.0f);
            Vehicle[] truckList = { truck };
            //Motocycle.
            Motocycle moto1 = new Motocycle("1", "Harley", "2022", "a3", 5.5f, 150.0f);
            Motocycle moto2 = new Motocycle("2", "Yamaha", "2015", "a4", 6.0f, 100.0f);
            Vehicle[] motoList = { moto1, moto2 };

            //customer.
            Customer A = new Customer(car1, "Minh", "12", "0909076618", 2);
            Customer B = new Customer(truck, "Cao", "21", "0777076618", 1);
            Customer[] cusList = { A, B };
           


            int mode = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("/MODE/\n" +
                    "1. Print Customer Information\n" +
                    "2. Print Car List\n" +
                    "3. Print Truck List\n" +
                    "4. Print Motocyle List\n" +
                    "5. Return Rental\n" +
                    "6. Add Rental\n" +
                    "7. Print Rental History\n" +
                    "8. Calculate Total Cost\n" +
                    "0. Exit\n");
                Console.Write("Select: ");
                mode = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (mode)
                {
                    case 1:
                        //print customer information.
                        Console.WriteLine("=========================");
                        Console.WriteLine("CUSTOMERS\n");
                        Console.WriteLine("=========================");
                        for (int i = 0; i < cusList.Length; i++)
                        {
                            Console.WriteLine("Customer No" + (i + 1) + ":");
                            cusList[i].printCusInfo();
                            Console.WriteLine("=========================");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        //print car information.
                        Console.WriteLine("=========================");
                        Console.WriteLine("CAR LIST.\n");
                        Console.WriteLine("=========================");
                        for (int i = 0; i < carList.Length; i++)
                        {
                            Console.WriteLine("Car No" + (i + 1) + ":");
                            carList[i].Print();
                            Console.Write("rental state: ");
                            if (carList[i].State == 0)
                                Console.WriteLine("Available\n");
                            else
                                Console.WriteLine("Unavailable\n");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        //print truck infomation.
                        Console.WriteLine("=========================");
                        Console.WriteLine("TRUCK LIST.\n");
                        Console.WriteLine("=========================");
                        for (int i = 0; i < truckList.Length; i++)
                        {
                            Console.WriteLine("Truck No" + (i + 1) + ":");
                            truckList[i].Print();
                            Console.Write("rental state: ");
                            if (truckList[i].State == 0)
                                Console.WriteLine("Available\n");
                            else
                                Console.WriteLine("Unavailable\n");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        //print motocycle information.
                        Console.WriteLine("=========================");
                        Console.WriteLine("MOTOCYCLE LIST.\n");
                        Console.WriteLine("=========================");
                        for (int i = 0; i < motoList.Length; i++)
                        {
                            Console.WriteLine("Motocycle No" + (i + 1) + ":");
                            motoList[i].Print();
                            Console.Write("rental state: ");
                            if (motoList[i].State == 0)
                                Console.WriteLine("Available\n");
                            else
                                Console.WriteLine("Unavailable\n");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 5: 
                        //return a retal order.
                        Console.WriteLine("=========================");
                        Console.Write("Please Enter the Name: ");
                        string name = Console.ReadLine();
                        for (int i = 0; i < cusList.Length; i++)
                        {
                            if (cusList[i].Name == name)
                            {
                                cusList[i].returnRental();
                                break;
                            }
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 6: 
                        //adding a rental order.
                        Console.WriteLine("=========================");
                        Console.Write("Please Enter the Name: ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("=========================");
                        Console.WriteLine("VEHICLE LIST.");
                        Console.WriteLine("=========================");
                        for (int i = 0; i < carList.Length; i++)
                        {
                            Console.WriteLine("Car No" + (i + 1) + ":");
                            carList[i].Print();
                            Console.Write("rental state: ");
                            if (carList[i].State == 0)
                                Console.WriteLine("Available\n");
                            else
                                Console.WriteLine("Unavailable\n");
                        }
                        for (int i = 0; i < truckList.Length; i++)
                        {
                            Console.WriteLine("Truck No" + (i + 1) + ":");
                            truckList[i].Print();
                            Console.Write("rental state: ");
                            if (truckList[i].State == 0)
                                Console.WriteLine("Available\n");
                            else
                                Console.WriteLine("Unavailable\n");
                        }
                        for (int i = 0; i < motoList.Length; i++)
                        {
                            Console.WriteLine("Motocycle No" + (i + 1) + ":");
                            motoList[i].Print();
                            Console.Write("rental state: ");
                            if (motoList[i].State == 0)
                                Console.WriteLine("Available\n");
                            else
                                Console.WriteLine("Unavailable\n");
                        }
                        Console.WriteLine("=========================");
                        for (int i = 0; i < cusList.Length; i++)
                        {
                            if (cusList[i].Name == name1)
                            {
                                //UI.
                                Console.WriteLine("Type select (1. Car | 2. Truck | 3. Motocycle)\n");
                                Console.Write("Select: ");
                                int type = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Select id: ");
                                int tmpid = Convert.ToInt32(Console.ReadLine());
                                tmpid--;
                                Console.Write("Duration: ");
                                int duration = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                //Function.
                                switch (type)
                                {
                                    case 1:
                                        if (carList[tmpid] != null)
                                            cusList[i].addRental(carList[tmpid], duration);
                                        break; 
                                    case 2:
                                        if (truckList[tmpid] != null)
                                            cusList[i].addRental(truckList[tmpid], duration);
                                        break;
                                    case 3:
                                        if (motoList[tmpid] != null)
                                            cusList[i].addRental(motoList[tmpid], duration);
                                        break;
                                    default:
                                        Console.WriteLine("Adding Operation Canceled!");
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 7:
                        //print rental history.
                        Console.WriteLine("=========================");
                        Console.Write("Please Enter the Name: ");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("=========================");
                        for (int i = 0; i < cusList.Length; i++)
                        {
                            if (cusList[i].Name == name2)
                            {
                                cusList[i].printHistory();
                            }
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 8:
                        //calculate the total cost of all of the orders.
                        Console.WriteLine("=========================");
                        Console.Write("The Total Price for " + cusList.Count() + " Customers: ");
                        float sum = 0;
                        for(int i =0 ;i < cusList.Count(); i++)
                        {
                            sum += cusList[i].TotalCost();
                        }
                        Console.WriteLine(sum);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("=========================");
                        Console.WriteLine("Program terminated!\n");
                        Console.WriteLine("=========================");
                        break;
                }
            }
        }

    }
}