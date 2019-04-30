using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class represents a tile object. Each button on the form is a representation of a tile
 * Each tile has a value and a color.
 */

namespace TwentyFortyEight
{
    public class Tile
    {
        //variables
        private string value;
        private string Color;
        private bool isChanged;
        
        public Tile(string value)//constructor. upon creation the value gets assigned
        {
            this.value = value;
        }
        public void setValue(string val) //setter for the value
        {
            this.value = val;
        }
        
        public string getValue() //getter for the value
        {
            return this.value;
        }

        public void setIsChanged(bool isChanged) //setter for isChanged
        {
            this.isChanged = isChanged;
        }

        public bool getIsChanged() //getter for isChanged
        {
            return this.isChanged;
        }
    }
}