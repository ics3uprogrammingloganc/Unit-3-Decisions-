namespace ChocolateBoxesLoganC
{
    partial class frmChocolate
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.btnReward = new System.Windows.Forms.Button();
            this.lblReward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(34, 40);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(197, 17);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "How many boxes did you sell?";
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(237, 39);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(125, 20);
            this.tbxAnswer.TabIndex = 1;
            // 
            // btnReward
            // 
            this.btnReward.Location = new System.Drawing.Point(287, 65);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(75, 23);
            this.btnReward.TabIndex = 2;
            this.btnReward.Text = "Get Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(94, 70);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(0, 13);
            this.lblReward.TabIndex = 3;
            // 
            // frmChocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 140);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.tbxAnswer);
            this.Controls.Add(this.lblPrompt);
            this.Name = "frmChocolate";
            this.Text = "Chocolate Box by Logan C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Label lblReward;
    }
}

