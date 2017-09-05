namespace bjcs
{
    partial class Main
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
            this.btnDeal = new System.Windows.Forms.Button();
            this.textBoxCards = new System.Windows.Forms.TextBox();
            this.textBoxNumberInHand = new System.Windows.Forms.TextBox();
            this.lblScoreHigh = new System.Windows.Forms.Label();
            this.lblScoreLow = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(408, 217);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "DEAL!";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // textBoxCards
            // 
            this.textBoxCards.Location = new System.Drawing.Point(257, 219);
            this.textBoxCards.Multiline = true;
            this.textBoxCards.Name = "textBoxCards";
            this.textBoxCards.Size = new System.Drawing.Size(129, 247);
            this.textBoxCards.TabIndex = 1;
            // 
            // textBoxNumberInHand
            // 
            this.textBoxNumberInHand.Location = new System.Drawing.Point(257, 187);
            this.textBoxNumberInHand.Name = "textBoxNumberInHand";
            this.textBoxNumberInHand.Size = new System.Drawing.Size(39, 20);
            this.textBoxNumberInHand.TabIndex = 2;
            // 
            // lblScoreHigh
            // 
            this.lblScoreHigh.AutoSize = true;
            this.lblScoreHigh.Location = new System.Drawing.Point(408, 267);
            this.lblScoreHigh.Name = "lblScoreHigh";
            this.lblScoreHigh.Size = new System.Drawing.Size(35, 13);
            this.lblScoreHigh.TabIndex = 3;
            this.lblScoreHigh.Text = "label1";
            // 
            // lblScoreLow
            // 
            this.lblScoreLow.AutoSize = true;
            this.lblScoreLow.Location = new System.Drawing.Point(408, 288);
            this.lblScoreLow.Name = "lblScoreLow";
            this.lblScoreLow.Size = new System.Drawing.Size(35, 13);
            this.lblScoreLow.TabIndex = 4;
            this.lblScoreLow.Text = "label1";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(490, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 851);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScoreLow);
            this.Controls.Add(this.lblScoreHigh);
            this.Controls.Add(this.textBoxNumberInHand);
            this.Controls.Add(this.textBoxCards);
            this.Controls.Add(this.btnDeal);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.TextBox textBoxCards;
        private System.Windows.Forms.TextBox textBoxNumberInHand;
        private System.Windows.Forms.Label lblScoreHigh;
        private System.Windows.Forms.Label lblScoreLow;
        private System.Windows.Forms.Button btnReset;
    }
}

