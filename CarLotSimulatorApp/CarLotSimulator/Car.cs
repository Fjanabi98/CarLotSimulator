using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {

        public Car (int year, string make,string model, bool isdriveable,string EngineNoise,string HonkNoise)
        {
            Year = year;
            Make = make;
            Model = Model;
            IsDriveable = true;
            EngineNoise = EngineNoise;
            HonkNoise = HonkNoise;
        } 
        public Car()
        {

         
        }

      public int Year { get; set; }
      public string Make { get; set; }
      public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public void MakeEngineNoise (string enginenoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }
    
}
