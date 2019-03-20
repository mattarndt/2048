using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyFortyEight
{
    public partial class frmTwentyFortyEight : Form
    {
        public frmTwentyFortyEight()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!");
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you're the best!");
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hollard!!");
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("scooby dooooo!");
        }

        private void frmTwentyFortyEight_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmTwentyFortyEight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Left)
            {
                btnLeft.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Up)
            {
                btnUp.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Down)
            {
                btnDown.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Right)
            {
                btnRight.PerformClick();
            }

        }

        
    }
}
