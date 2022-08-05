namespace Airline_Reservation_System
{
    partial class PrintBoardingPass
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
            this.labelThankYou = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelThankYou
            // 
            this.labelThankYou.AutoSize = true;
            this.labelThankYou.Location = new System.Drawing.Point(12, 9);
            this.labelThankYou.Name = "labelThankYou";
            this.labelThankYou.Size = new System.Drawing.Size(160, 13);
            this.labelThankYou.TabIndex = 0;
            this.labelThankYou.Text = "Thank you for flying XYZ Airlines";
            // 
            // labelPass
            // 
            this.labelPass.BackColor = System.Drawing.Color.White;
            this.labelPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPass.Location = new System.Drawing.Point(12, 35);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(350, 167);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "label2";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(12, 214);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print to File";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // PrintBoardingPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 249);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelThankYou);
            this.Name = "PrintBoardingPass";
            this.Text = "PrintBoardingPass";
            this.Load += new System.EventHandler(this.PrintBoardingPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThankYou;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonPrint;
    }
}