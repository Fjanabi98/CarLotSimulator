using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            CarLot carLot = new CarLot();
            carLot.CarList = new List<Car>();

            var car1 = new Car();
        
                car1.Year = 2000;
                car1.Make = "Dodge";
                car1.Model = "Ram";
                car1.EngineNoise = "Vroom";
                car1.HonkNoise = "Beep";
                car1.IsDriveable = true;
                car1 .MakeEngineNoise(car1.EngineNoise);
                car1.MakeEngineNoise(car1.HonkNoise);

            carLot.CarList.Add(car1);

                Console.WriteLine();

                var car2 = new Car()
                {
                    Year = 2021,
                    Make = "Toyota",
                    Model = "Camry",
                    EngineNoise = "vroom",
                    HonkNoise = "Beep",
                    IsDriveable = true

                };

                car2 .MakeEngineNoise(car2.EngineNoise);
                car2.EngineNoise = (car2.EngineNoise);
                carLot.CarList.Add(car2);
                Console.WriteLine();


                var car3 =new Car() {Year= 2019,Make= "Lexus",Model= "GX",IsDriveable= true,EngineNoise="Vroom",HonkNoise="Beep" };
                car3 .MakeEngineNoise(car3.EngineNoise);
                car3 .EngineNoise = (car3.EngineNoise);
                carLot.CarList.Add(car3);
                Console.WriteLine();

            foreach (var car in carLot.CarList)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine();
            }
                

                


        }




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
    }
}
