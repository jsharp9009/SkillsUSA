namespace OnlineMovieStore___Contestant_7
{
    partial class AddMovie
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 9);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(89, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year of Release: ";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(12, 135);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(44, 13);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title: ";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(12, 102);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(85, 13);
            this.lblPurchasePrice.TabIndex = 3;
            this.lblPurchasePrice.Text = "Purchase Price: ";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 70);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre: ";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(107, 6);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(182, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(51, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(238, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(60, 67);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(229, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(103, 99);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(186, 20);
            this.txtPurchasePrice.TabIndex = 8;
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG13",
            "R"});
            this.cmbRating.Location = new System.Drawing.Point(62, 132);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(227, 21);
            this.cmbRating.TabIndex = 9;
            // 
            // btnAddExit
            // 
            this.btnAddExit.Location = new System.Drawing.Point(28, 162);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(83, 35);
            this.btnAddExit.TabIndex = 10;
            this.btnAddExit.Text = "Add";
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(117, 162);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(83, 35);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add and Start Another";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblYear);
            this.Name = "AddMovie";
            this.Text = "Add A Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
    }
}