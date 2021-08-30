using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            Car car = new Car { Year = "1970", Make = "Pontiac", Model = "GTO", HasThirdDoor = false };
            Truck truck = new Truck { Year = "1999", Make = "Ford", Model = "Lightning", HasTruckBed = true };
            SUV suv = new SUV { Year = "1997", Make = "Isuzu", Model = "Rodeo", HasThirdRowSitting = false };

            List<ICompany> vehicles = new List<ICompany>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);

            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.Drive();
                vehicle.DriveDefault();
                Console.WriteLine();
            }
            


           

          

            Console.ReadLine();
        }
    }
}
