using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
  class Game
    {
        //member variables
        Customer customer;
        Day day;
        Game game;
        Glasses glass;
        Ice ice;
        Inventory inventory;
        Lemons lemons;
        Pitcher pitcher;
        Player player;
        Recipe recipe;
        Store store;
        Sugar sugar;
        Weather_Forecast forecast;
        int dayNum;

        //constructor
        public Game()
        {

        }


        //methods
        public void RunGame()
        {
            while (dayNum < 8)
            {
                RunGame();
            }
            if (dayNum == 8 || dayNum > 7)
            {
                
            }


        }


    }
}
