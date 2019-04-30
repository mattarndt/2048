using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Matthew Arndt & Michael Kelley - 2048
 * This is the class that handles all actions with the form - it is essentially the main driver of the game.
 * 2048 is a game in which the objective is to get a tile that reads "2048". You lose when there is no more moves you can make on the board.
 * You can move the game board with the "WASD" keys instead of tediously pressing the arrow keys on the Windows form.
 * 
*/

namespace TwentyFortyEight
{
    public partial class frmTwentyFortyEight : Form
    {
        //variables
        Board board = new Board();
        Player player = new Player();
        
        private const int BINGOCARDSIZE = 4;
        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;
        bool firstgame = true;
        private Button[,] newButton = new Button[4, 4];
        
        public frmTwentyFortyEight()
        {
            InitializeComponent();
        }
        
        private void frmTwentyFortyEight_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "A":
                    btnLeft.PerformClick();
                    break;
                case "W":
                    btnUp.PerformClick();
                    break;
                case "D":
                    btnRight.PerformClick();
                    break;
                case "S":
                    btnDown.PerformClick();
                    break;
                default:
                    break;
            }
        }
        
        private void frmTwentyFortyEight_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //makes the form look for key presses
        }
        
        private void btnLeft_Click(object sender, EventArgs e)//triggers when user presses "a" or clicks the left arrow
        {
            board.move("left");
            displayBoard();
        }

        private void btnUp_Click(object sender, EventArgs e)//triggers when the user presses "w" or presses the up arrow
        {
            board.move("up");
            displayBoard();
        }

        private void btnRight_Click(object sender, EventArgs e)//triggers when the user presses "d" or presses the right arrow
        {
            board.move("right");
            displayBoard();
        }

        private void btnDown_Click(object sender, EventArgs e)//triggers when the user presses "s" or presses the down arrow
        {
            board.move("down");
            displayBoard();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            if (name == "" || name == "Name" || name == " " || name == null) //if the user entered a name
            {
                MessageBox.Show("You must enter in a name to play the game");
            }
            else //user entered a valied name
            {
                player.setName(name);
                //MessageBox.Show("Welcome to 2048! Press rules to read the rules, \n" +
                //   "To start a game, press the new button \n" +
                //   " move with the WASD keys or simply press the buttons at the bottom");
                //turning the name functionality off, and everything else on
                txtName.Enabled = false;
                btnOk.Enabled = false;
                txtScore.Enabled = true;
                btnNew.Enabled = true;
                btnRules.Enabled = true;
            }
        }

        
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form
            //Board board = new Board();
            Size size = new Size(50, 50);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;
            
            int x;
            int y;
            
            // Draw Column indexes
            y = 0;
            //DrawColumnLabels();
            
            x = xcardUpperLeft;
            y = ycardUpperLeft;
            
            // Draw top line for card
            // drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;
            
            // The board is treated like a 5x5 array
            //drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 8, FontStyle.Bold);
                    newButton[row, col].Text = board.getTileArr(row,col);
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();
                    
                    // Associates the same event handler with each of the buttons generated
                    //newButton[row, col].Click += new EventHandler(Button_Click);
                    
                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);
                    
                    // Draw vertical delimiter  
                    x += cardCellWidth + padding;
                    // if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete
                
                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                //drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row
            
            // Draw column indices at bottom of card
            y += barWidth - 1;
            //DrawColumnLabels();
            //Globals.selectedNumbersListObj.reset();
        } // end createBoard
        
        private void btnClose_Click(object sender, EventArgs e) //closes the form when the user clicks "close"
        {
            this.Close();
        }
        
        //When the user clicks on the name textbox, the name placeholder field dissapears
        private void txtName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
            }
            txtName.ForeColor = Color.Black;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            //enables all of the move buttons
            btnRight.Enabled = true;
            btnDown.Enabled = true;
            btnLeft.Enabled = true;
            btnUp.Enabled = true;
            
            //this resets and creates a new board when the user presses new
            if (firstgame)//if this is the first game, then create the card from scratch and do it from the beginning
            {
                createCard();
                firstgame = false;
            }
            else //if this isnt the first game, then just reload the board and assign all the buttons' text to the appropriate text.
            {
                board = new Board();
                for (int row = 0; row < BINGOCARDSIZE; row++)
                {
                    for (int col = 0; col < BINGOCARDSIZE; col++)
                    {
                        newButton[row, col].Text = board.getTileArr(row,col);
                        newButton[row, col].Font = new Font("Arial", 8, FontStyle.Bold);
                        //newButton[row, col].Enabled = false;
                    }
                }
            }
        }

        public void displayBoard()
        {
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col].Text = board.getTileArr(row, col);
                    newButton[row, col].Font = new Font("Microsoft Sans Serif", 8);
                    //newButton[row, col].Enabled = false;
                }
            }
        }
        
        

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome, " + player.getName() + ", these are the rules: \n" +
                "Use the directional buttons or 'W' 'A' 'S' 'D' to move the tiles. \n" +
                "When the numbers running into each other match, they become one \n" +
                "tile with a new combined value. Your goal is to reach the value 2048 \n" +
                "before you run out of moves to make.");
        }
        
    }
}