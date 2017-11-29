using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    class Weather_Forecast
    {
        //member variables
        /* Each day Random num = new Random();
         * Rainy = 1
         * Sunny = 2
         * partly-cloudy = 3
         * hot and sunny = 4 
         * 
         */
        List<string> forecast = new List<string>(new string[] { "rainy", "sunny", "partly cloudy", "hot and sunny" });
        //constructor
        public Weather_Forecast()
        {
            Random num = new Random();
        }


        //methods

        //method for temperature in degrees

    }
}
