using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT
{
    internal class TrafficLightSignal
    {
        //Create a TrafficLightSignal with a property Color of type TrafficLightEnum.
        //Add a method ChangeColor() that changes the color to the next one in the sequence Red -> Green -> Yellow -> Red.
        public Trafficlightenums Color;

        public void ChangeColor()
        {
            Console.WriteLine("Enter Color Change (Red, Yellow, Green)");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            switch (input.ToLower())
            {
                case "Red":
                    //Color = Trafficlightenums.Red;
                    Console.WriteLine("Red means STOP!");
                    break;
                case "Yellow":
                    Color = Trafficlightenums.Yellow;
                    Console.WriteLine("Yellow means GET READY!");
                    break;
                case "Green":
                    Color = Trafficlightenums.Green;
                    Console.WriteLine("Green means GO!");
                    break;
            }
        }


        public void Display()
        {
            Console.WriteLine($"Color: {Color}");
        }
    }
}
