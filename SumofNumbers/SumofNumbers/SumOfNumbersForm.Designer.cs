namespace SumofNumbers
{
    partial class frmSumofNumbers
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(29, 25);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(47, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Number:";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(81, 22);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 20);
            this.tbxInput.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(63, 62);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(22, 106);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(182, 199);
            this.lstList.TabIndex = 3;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(22, 320);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(64, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "The sum is: ";
            // 
            // frmSumofNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 345);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblPrompt);
            this.Name = "frmSumofNumbers";
            this.Text = "Sum of Numbers by Logan C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Label lblSum;
    }
}

