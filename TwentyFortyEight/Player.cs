using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *This class is used to represent a player of the game. The only attricute is his/her name. 
 * 
 */


namespace TwentyFortyEight
{
    class Player
    {
        private String playerName;//name
        
        public Player()//constructor
        {
            
        }
        
        public String getName() //getter for the name
        {
            return playerName;
        }
        
        public void setName(String name)//setter for the name
        {
            this.playerName = name;
        }
    }
}