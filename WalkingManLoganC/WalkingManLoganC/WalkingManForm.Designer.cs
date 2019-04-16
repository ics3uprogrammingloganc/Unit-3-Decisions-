namespace WalkingManLoganC
{
    partial class frmWalkingMan
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
            this.pbxWalkingMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWalkingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxWalkingMan
            // 
            this.pbxWalkingMan.Image = global::WalkingManLoganC.Properties.Resources.walk1;
            this.pbxWalkingMan.InitialImage = global::WalkingManLoganC.Properties.Resources.walk1;
            this.pbxWalkingMan.Location = new System.Drawing.Point(117, 89);
            this.pbxWalkingMan.Name = "pbxWalkingMan";
            this.pbxWalkingMan.Size = new System.Drawing.Size(182, 194);
            this.pbxWalkingMan.TabIndex = 0;
            this.pbxWalkingMan.TabStop = false;
            this.pbxWalkingMan.Click += new System.EventHandler(this.pbxWalkingMan_Click);
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 316);
            this.Controls.Add(this.pbxWalkingMan);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man by Logan C";
            ((System.ComponentModel.ISupportInitialize)(this.pbxWalkingMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxWalkingMan;
    }
}

