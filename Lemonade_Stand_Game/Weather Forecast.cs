using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Weather_Forecast
    {
        //member variables
        Random num = new Random();
        int forecast;
        int degrees;
        List<string> forecastList = new List<string>(new string[] { "rainy", "sunny", "partly cloudy", "hot and sunny" });
        public string dailyForecast;


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


        public string Forecast()
        {
            int forecast = num.Next(0, 3);
            dailyForecast = forecastList[forecast];
            return dailyForecast;          
        }
        public void PredictedWeather()
        {
            Forecast();
            Console.WriteLine("Today's weather prediction is " + Temperature() + " and " + dailyForecast);
        }

        public int ActualTemp()
        {
            int weatherVariation = num.Next(-5, 6);
            int realTemp = degrees + weatherVariation;
            return realTemp;
        }

        public void DisplayRealWeather()
        {
            Console.WriteLine("Today's actual weather is " + ActualTemp() + " and " + dailyForecast);
        }


    }
}
