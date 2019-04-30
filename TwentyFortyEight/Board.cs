using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 /*
  This class represents the board for the game. It is a 4x4 2d array.
  Upon creation of the board, it creates two tiles randomly and places them randomly.
  This is the main driver for movement of the tiles.
 */


namespace TwentyFortyEight
{
    public class Board
    {
        private RNG rand = new RNG();
        private Tile[,] tileArr = new Tile[4, 4];
        //private Player player = new Player();

        public Board() //constructor, sets all tile values to 0 and then sets generates 2 random tiles, either with values 2 or 4.
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Tile tile = new Tile("");
                    tileArr[i, j] = tile;
                }
            }
            string num = rand.get2or4().ToString();
            int randCol = rand.getRandomCol();
            int randRow = rand.getRandomRow();
            int randCol2 = rand.getRandomCol();
            int randRow2 = rand.getRandomRow();
            /*
            tileArr[randRow, randCol].setValue(num);
            if (isTileOccupied(randCol2, randRow2))
            {
                num = rand.get2or4().ToString();
                tileArr[randRow2, randCol2].setValue(num);
            } */
            addTile();
            addTile();
        }

        public string getTileArr(int row, int col)
        {
            return this.tileArr[row, col].getValue().ToString();
        }

        public bool addTile() //adds a tile randomly, with random value, either 2 or 4
        {
            bool tileNotLaid = true;
            //string num = rand.get2or4().ToString();
            while(tileNotLaid || isBoardFull())
            {
                int randRow = rand.getRandomRow();
                int randCol = rand.getRandomCol();
                if (!isTileOccupied(randRow, randCol))
                {
                    string num = rand.get2or4().ToString();
                    tileArr[randRow, randCol].setValue(num);
                    tileNotLaid = false;
                    return true;
                }
            }
            return false;
        }

        public void move(String direction)//moves the tiles in the corresponding direction
        {
            switch (direction)
            {
                case "left":
                    slideLeft();
                    slideLeft();
                    slideLeft();
                    break;
                case "right":
                    slideRight();
                    slideRight();
                    slideRight();
                    break;
                case "up":
                    slideUp();
                    slideUp();
                    slideUp();
                    break;
                case "down":
                    slideDown();
                    slideDown();
                    slideDown();
                    break;
            }
            addTile();
            resetIsChanged();
            isWinner();
            isLoser();
        }

        public void slideUp()//algotrithm for moving down
        {
            for(int i = 1; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (tileArr[i - 1, j].getValue() != "" && tileArr[i, j].getValue() != tileArr[i - 1, j].getValue())
                    {

                    }
                    else if (tileArr[i - 1, j].getValue() != "" && tileArr[i, j].getValue() == tileArr[i - 1, j].getValue()
                        && tileArr[i, j].getIsChanged() != true)
                    {
                        int newInt = Convert.ToInt32(tileArr[i, j].getValue()) * 2;
                        tileArr[i - 1, j].setValue(Convert.ToString(newInt));
                        tileArr[i, j].setValue("");
                        tileArr[i - 1, j].setIsChanged(true);
                    }
                    else if (tileArr[i - 1, j].getValue() != "" && tileArr[i, j].getValue() == tileArr[i - 1, j].getValue()
                        && tileArr[i, j].getIsChanged() == true)
                    {

                    }
                    else
                    {
                        tileArr[i - 1, j].setValue(tileArr[i, j].getValue());
                        tileArr[i, j].setValue("");
                    }
                }
            }
        }

        public void slideDown() //algorithm for moving down
        {
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tileArr[i + 1, j].getValue() != "" && tileArr[i, j].getValue() != tileArr[i + 1, j].getValue())
                    {

                    }
                    else if (tileArr[i + 1, j].getValue() != "" && tileArr[i, j].getValue() == tileArr[i + 1, j].getValue()
                        && tileArr[i, j].getIsChanged() != true)
                    {
                        int newInt = Convert.ToInt32(tileArr[i, j].getValue()) * 2;
                        tileArr[i + 1, j].setValue(Convert.ToString(newInt));
                        tileArr[i, j].setValue("");
                        tileArr[i + 1, j].setIsChanged(true);
                    }
                    else if (tileArr[i + 1, j].getValue() != "" && tileArr[i, j].getValue() == tileArr[i + 1, j].getValue()
                        && tileArr[i, j].getIsChanged() == true)
                    {
                    }
                    else
                    { 
                        tileArr[i + 1, j].setValue(tileArr[i, j].getValue());
                        tileArr[i, j].setValue("");
                    }
                }
            }
        }

        public void slideLeft()//algorithm for moving left.
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (tileArr[i, j - 1].getValue() != "" && tileArr[i, j].getValue() != tileArr[i, j - 1].getValue())
                    {

                    }
                    else if (tileArr[i, j - 1].getValue() != "" && tileArr[i, j].getValue() == tileArr[i, j - 1].getValue() 
                        && tileArr[i, j].getIsChanged() != true)
                    {
                        int newInt = Convert.ToInt32(tileArr[i, j].getValue()) * 2;
                        tileArr[i, j - 1].setValue(Convert.ToString(newInt));
                        tileArr[i, j].setValue("");
                        tileArr[i, j - 1].setIsChanged(true);
                    }
                    else if (tileArr[i, j - 1].getValue() != "" && tileArr[i, j].getValue() == tileArr[i, j - 1].getValue()
                        && tileArr[i, j].getIsChanged() == true)
                    {

                    }
                    else
                    {
                        tileArr[i, j - 1].setValue(tileArr[i, j].getValue());
                        tileArr[i, j].setValue("");
                    }
                }
            }
        }

        public void slideRight() //algorithm for moving right.
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j >= 0; j--)
                {
                    if (tileArr[i, j + 1].getValue() != "" && tileArr[i, j].getValue() != tileArr[i, j + 1].getValue())
                    {

                    }
                    else if (tileArr[i, j + 1].getValue() != "" && tileArr[i, j].getValue() == tileArr[i, j + 1].getValue()
                        && tileArr[i, j].getIsChanged() != true)
                    {
                        int newInt = Convert.ToInt32(tileArr[i, j].getValue()) * 2;
                        tileArr[i, j + 1].setValue(Convert.ToString(newInt));
                        tileArr[i, j].setValue("");
                        tileArr[i, j + 1].setIsChanged(true);
                    }
                    else if (tileArr[i, j + 1].getValue() != "" && tileArr[i, j].getValue() == tileArr[i, j + 1].getValue()
                        && tileArr[i, j].getIsChanged() == true)
                    {

                    }
                    else
                    {
                        tileArr[i, j + 1].setValue(tileArr[i, j].getValue());
                        tileArr[i, j].setValue("");
                    }
                }
            }
        }

        private bool isTileOccupied(int row, int col)//checks on whether or not a a tile exists given a certain row and column
        {
            if (tileArr[row, col].getValue().Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isBoardFull() //checks to see if the board is full
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(!isTileOccupied(i, j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void resetIsChanged()
        {
            foreach (Tile tile in tileArr)
            {
                tile.setIsChanged(false);
            }
        }


        public void isWinner() //checks if the user gets to the winning tile
        {
            foreach (Tile tile in tileArr)
            {
                if (tile.getValue() == "256")
                {
                    MessageBox.Show("Congratulations, you won! HOLLaRD");
                }
            }
        }

        public void isLoser() //checks whether or not the board is full, if it is, then you lost
        {
            if(!addTile())
            {
                MessageBox.Show("YOU LOST! GEEEEZE...");
            }
        }
    }
}