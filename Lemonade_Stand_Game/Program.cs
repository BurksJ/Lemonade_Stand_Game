using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather_Forecast w = new Weather_Forecast();
            w.PredictedWeather();
            w.DisplayRealWeather();
            Game game = new Game();
           // game.RunGame();
            Console.ReadKey();
        }
    }
}
