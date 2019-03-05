namespace RockPaperScissorsLoganC
{
    partial class frmRPS
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
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.grbComputer = new System.Windows.Forms.GroupBox();
            this.radUserRock = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.radCompScissors = new System.Windows.Forms.RadioButton();
            this.radCompPaper = new System.Windows.Forms.RadioButton();
            this.radCompRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.grbUser.SuspendLayout();
            this.grbComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.radUserScissors);
            this.grbUser.Controls.Add(this.radUserPaper);
            this.grbUser.Controls.Add(this.radUserRock);
            this.grbUser.Location = new System.Drawing.Point(26, 26);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(315, 105);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Your choice";
            this.grbUser.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grbComputer
            // 
            this.grbComputer.Controls.Add(this.radCompScissors);
            this.grbComputer.Controls.Add(this.radCompPaper);
            this.grbComputer.Controls.Add(this.radCompRock);
            this.grbComputer.Location = new System.Drawing.Point(26, 147);
            this.grbComputer.Name = "grbComputer";
            this.grbComputer.Size = new System.Drawing.Size(315, 99);
            this.grbComputer.TabIndex = 1;
            this.grbComputer.TabStop = false;
            this.grbComputer.Text = "Computer\'s choice";
            this.grbComputer.Enter += new System.EventHandler(this.grbComputer_Enter);
            // 
            // radUserRock
            // 
            this.radUserRock.AutoSize = true;
            this.radUserRock.Location = new System.Drawing.Point(20, 19);
            this.radUserRock.Name = "radUserRock";
            this.radUserRock.Size = new System.Drawing.Size(51, 17);
            this.radUserRock.TabIndex = 0;
            this.radUserRock.TabStop = true;
            this.radUserRock.Text = "Rock";
            this.radUserRock.UseVisualStyleBackColor = true;
            this.radUserRock.CheckedChanged += new System.EventHandler(this.radUserRock_CheckedChanged);
            // 
            // radUserPaper
            // 
            this.radUserPaper.AutoSize = true;
            this.radUserPaper.Location = new System.Drawing.Point(20, 43);
            this.radUserPaper.Name = "radUserPaper";
            this.radUserPaper.Size = new System.Drawing.Size(53, 17);
            this.radUserPaper.TabIndex = 1;
            this.radUserPaper.TabStop = true;
            this.radUserPaper.Text = "Paper";
            this.radUserPaper.UseVisualStyleBackColor = true;
            this.radUserPaper.CheckedChanged += new System.EventHandler(this.radUserPaper_CheckedChanged);
            // 
            // radUserScissors
            // 
            this.radUserScissors.AutoSize = true;
            this.radUserScissors.Location = new System.Drawing.Point(20, 67);
            this.radUserScissors.Name = "radUserScissors";
            this.radUserScissors.Size = new System.Drawing.Size(64, 17);
            this.radUserScissors.TabIndex = 2;
            this.radUserScissors.TabStop = true;
            this.radUserScissors.Text = "Scissors";
            this.radUserScissors.UseVisualStyleBackColor = true;
            this.radUserScissors.CheckedChanged += new System.EventHandler(this.radUserScissors_CheckedChanged);
            // 
            // radCompScissors
            // 
            this.radCompScissors.AutoSize = true;
            this.radCompScissors.Enabled = false;
            this.radCompScissors.Location = new System.Drawing.Point(20, 67);
            this.radCompScissors.Name = "radCompScissors";
            this.radCompScissors.Size = new System.Drawing.Size(64, 17);
            this.radCompScissors.TabIndex = 5;
            this.radCompScissors.Text = "Scissors";
            this.radCompScissors.UseVisualStyleBackColor = true;
            // 
            // radCompPaper
            // 
            this.radCompPaper.AutoSize = true;
            this.radCompPaper.Enabled = false;
            this.radCompPaper.Location = new System.Drawing.Point(20, 43);
            this.radCompPaper.Name = "radCompPaper";
            this.radCompPaper.Size = new System.Drawing.Size(53, 17);
            this.radCompPaper.TabIndex = 4;
            this.radCompPaper.Text = "Paper";
            this.radCompPaper.UseVisualStyleBackColor = true;
            // 
            // radCompRock
            // 
            this.radCompRock.AutoSize = true;
            this.radCompRock.Enabled = false;
            this.radCompRock.Location = new System.Drawing.Point(20, 19);
            this.radCompRock.Name = "radCompRock";
            this.radCompRock.Size = new System.Drawing.Size(51, 17);
            this.radCompRock.TabIndex = 3;
            this.radCompRock.Text = "Rock";
            this.radCompRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(46, 268);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(139, 273);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(47, 13);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "Winner: ";
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 550);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputer);
            this.Controls.Add(this.grbUser);
            this.Name = "frmRPS";
            this.Text = "Rock Paper Scissors by Logan C";
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grbComputer.ResumeLayout(false);
            this.grbComputer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.GroupBox grbComputer;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.RadioButton radUserRock;
        private System.Windows.Forms.RadioButton radCompScissors;
        private System.Windows.Forms.RadioButton radCompPaper;
        private System.Windows.Forms.RadioButton radCompRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWinner;
    }
}

