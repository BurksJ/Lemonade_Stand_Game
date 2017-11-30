using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Weather_Forecast
    {
        Random num = new Random();
        int forecast;
        int degrees;
        List<string> forecastList = new List<string>(new string[] { "rainy", "sunny", "partly cloudy", "hot and sunny" });
        public string dailyForecast;
        //member variables
        /* Each day Random num = new Random();
         * Rainy = 1
         * Sunny = 2
         * partly-cloudy = 3
         * hot and sunny = 4 
         * 
         */

        //constructor
        public Weather_Forecast()
        {
        }


        //methods
        public int Temperature()
        {
            if (dailyForecast == "rainy")
            {
                degrees = num.Next(50, 65);
            }
            else if (dailyForecast == "sunny")
            {
                degrees = num.Next(65, 70);
            }
            else if (dailyForecast == "partly cloudy")
            {
                degrees = num.Next(70, 85);
            }
            else if (dailyForecast == "hot and sunny")
            {
                degrees = num.Next(85, 100);
            }
            return degrees;
        }

        //method for temperature in degrees
        //rainy to (50-65degrees)
        //party-cloudy to (65-70)
        //sunny to (70-85)
        //hot and sunny to (85-100)
        public string Forecast()
        {
            int forecast = num.Next(0, 3);
            dailyForecast = forecastList[forecast];
            return dailyForecast;          
        }
        public void DisplayWeather()
        {
            Forecast();
            Console.WriteLine("Today's weather prediction is " + Temperature() + " and " + dailyForecast);
        }
    }
}
