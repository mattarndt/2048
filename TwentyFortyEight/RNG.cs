using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class is used to get random numbers that spawn on the board when it is first created and everytime a tile is moved.
 * Also used to give a random row and random col for where that random tile will be placed
 * 
 */

namespace TwentyFortyEight
{
    class RNG
    {
        private Random RandomObj;      // Type random object
        // Constructor -- Creates and seeds a type random object
        public RNG()
        {
            RandomObj = new Random();  // Creates and seeds (using current time) random object 
        }  // end RNGType
        
        public int get2or4()// returns either a 2 or a 4, with probablilty for 2 being 80% and 4 being 20%
        {
            int num;
            int rn = RandomObj.Next(0, 100);
            if (rn < 80)
            {
                num = 2;
            }
            else
            {
                num = 4;
            }
            return num;
        }
        
        public int getRandomCol()//return random col
        {
            return RandomObj.Next(0, 4);
        }

        public int getRandomRow() //returns random row
        {
            return RandomObj.Next(0, 4);
        }
    }
}