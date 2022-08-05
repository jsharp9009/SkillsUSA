namespace Airline_Reservation_System
{
    partial class ReservationScreen
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.buttonFirstClass = new System.Windows.Forms.Button();
            this.buttonEconomy = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(80, 78);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(80, 105);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(143, 75);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(143, 20);
            this.textFirstName.TabIndex = 0;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(144, 101);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(143, 20);
            this.textLastName.TabIndex = 1;
            // 
            // buttonFirstClass
            // 
            this.buttonFirstClass.Location = new System.Drawing.Point(65, 140);
            this.buttonFirstClass.Name = "buttonFirstClass";
            this.buttonFirstClass.Size = new System.Drawing.Size(75, 44);
            this.buttonFirstClass.TabIndex = 2;
            this.buttonFirstClass.Text = "Book &First Class";
            this.buttonFirstClass.UseVisualStyleBackColor = true;
            this.buttonFirstClass.Click += new System.EventHandler(this.buttonFirstClass_Click);
            // 
            // buttonEconomy
            // 
            this.buttonEconomy.Location = new System.Drawing.Point(146, 140);
            this.buttonEconomy.Name = "buttonEconomy";
            this.buttonEconomy.Size = new System.Drawing.Size(75, 44);
            this.buttonEconomy.TabIndex = 3;
            this.buttonEconomy.Text = "Book &Economy";
            this.buttonEconomy.UseVisualStyleBackColor = true;
            this.buttonEconomy.Click += new System.EventHandler(this.Economy_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(227, 140);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 44);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Airline Reservation System";
            // 
            // ReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEconomy);
            this.Controls.Add(this.buttonFirstClass);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "ReservationScreen";
            this.Text = "Airline Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Button buttonFirstClass;
        private System.Windows.Forms.Button buttonEconomy;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}

