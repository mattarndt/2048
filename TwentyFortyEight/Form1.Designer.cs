namespace TwentyFortyEight
{
    partial class frmTwentyFortyEight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTwentyFortyEight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRules = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTwentyFortyEight
            // 
            this.lblTwentyFortyEight.AutoSize = true;
            this.lblTwentyFortyEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwentyFortyEight.Location = new System.Drawing.Point(49, 9);
            this.lblTwentyFortyEight.Name = "lblTwentyFortyEight";
            this.lblTwentyFortyEight.Size = new System.Drawing.Size(754, 147);
            this.lblTwentyFortyEight.TabIndex = 0;
            this.lblTwentyFortyEight.Text = "2    0    4    8";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(39, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 685);
            this.panel1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 31);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(250, 144);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(124, 43);
            this.btnRules.TabIndex = 3;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(458, 150);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(138, 31);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(665, 144);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 43);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(74, 917);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(137, 63);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(271, 917);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(137, 63);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(468, 917);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(138, 63);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(656, 917);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(138, 63);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // frmTwentyFortyEight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 1080);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTwentyFortyEight);
            this.Name = "frmTwentyFortyEight";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTwentyFortyEight_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTwentyFortyEight_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTwentyFortyEight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
    }
}

