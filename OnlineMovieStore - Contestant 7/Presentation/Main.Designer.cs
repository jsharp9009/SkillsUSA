namespace OnlineMovieStore___Contestant_7
{
    partial class Form1
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtYearSearch = new System.Windows.Forms.TextBox();
            this.cmbYearSearch = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.cmbRatingSort = new System.Windows.Forms.ComboBox();
            this.ckbRatingSort = new System.Windows.Forms.CheckBox();
            this.cmbYearSort = new System.Windows.Forms.ComboBox();
            this.ckbYearSort = new System.Windows.Forms.CheckBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.grbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMovies.GridColor = System.Drawing.Color.Black;
            this.dgvMovies.Location = new System.Drawing.Point(12, 128);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(617, 330);
            this.dgvMovies.TabIndex = 5;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(554, 24);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "&Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.txtYearSearch);
            this.grbSearch.Controls.Add(this.cmbYearSearch);
            this.grbSearch.Controls.Add(this.lblYear);
            this.grbSearch.Controls.Add(this.txtTitleSearch);
            this.grbSearch.Controls.Add(this.lblTitleSearch);
            this.grbSearch.Location = new System.Drawing.Point(12, 8);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(326, 114);
            this.grbSearch.TabIndex = 3;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(245, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYearSearch
            // 
            this.txtYearSearch.Location = new System.Drawing.Point(215, 56);
            this.txtYearSearch.Name = "txtYearSearch";
            this.txtYearSearch.Size = new System.Drawing.Size(100, 20);
            this.txtYearSearch.TabIndex = 3;
            // 
            // cmbYearSearch
            // 
            this.cmbYearSearch.FormattingEnabled = true;
            this.cmbYearSearch.Items.AddRange(new object[] {
            "Released Before",
            "Released Before or On",
            "Released After or On",
            "Released After"});
            this.cmbYearSearch.Location = new System.Drawing.Point(47, 56);
            this.cmbYearSearch.Name = "cmbYearSearch";
            this.cmbYearSearch.Size = new System.Drawing.Size(162, 21);
            this.cmbYearSearch.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 59);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year: ";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Location = new System.Drawing.Point(89, 23);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(231, 20);
            this.txtTitleSearch.TabIndex = 1;
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.Location = new System.Drawing.Point(6, 26);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(77, 13);
            this.lblTitleSearch.TabIndex = 0;
            this.lblTitleSearch.Text = "Title Contains: ";
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.btnSort);
            this.grbSort.Controls.Add(this.cmbRatingSort);
            this.grbSort.Controls.Add(this.ckbRatingSort);
            this.grbSort.Controls.Add(this.cmbYearSort);
            this.grbSort.Controls.Add(this.ckbYearSort);
            this.grbSort.Location = new System.Drawing.Point(344, 8);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(204, 114);
            this.grbSort.TabIndex = 4;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sort";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(123, 85);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "S&ort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cmbRatingSort
            // 
            this.cmbRatingSort.FormattingEnabled = true;
            this.cmbRatingSort.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbRatingSort.Location = new System.Drawing.Point(69, 58);
            this.cmbRatingSort.Name = "cmbRatingSort";
            this.cmbRatingSort.Size = new System.Drawing.Size(121, 21);
            this.cmbRatingSort.TabIndex = 3;
            // 
            // ckbRatingSort
            // 
            this.ckbRatingSort.AutoSize = true;
            this.ckbRatingSort.Location = new System.Drawing.Point(15, 60);
            this.ckbRatingSort.Name = "ckbRatingSort";
            this.ckbRatingSort.Size = new System.Drawing.Size(57, 17);
            this.ckbRatingSort.TabIndex = 2;
            this.ckbRatingSort.Text = "Rating";
            this.ckbRatingSort.UseVisualStyleBackColor = true;
            // 
            // cmbYearSort
            // 
            this.cmbYearSort.FormattingEnabled = true;
            this.cmbYearSort.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbYearSort.Location = new System.Drawing.Point(69, 18);
            this.cmbYearSort.Name = "cmbYearSort";
            this.cmbYearSort.Size = new System.Drawing.Size(121, 21);
            this.cmbYearSort.TabIndex = 1;
            // 
            // ckbYearSort
            // 
            this.ckbYearSort.AutoSize = true;
            this.ckbYearSort.Location = new System.Drawing.Point(15, 26);
            this.ckbYearSort.Name = "ckbYearSort";
            this.ckbYearSort.Size = new System.Drawing.Size(48, 17);
            this.ckbYearSort.TabIndex = 0;
            this.ckbYearSort.Text = "Year";
            this.ckbYearSort.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(554, 53);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "&Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(554, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 471);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grbSort);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.dgvMovies);
            this.Name = "Form1";
            this.Text = "Online Movie Store Inventory - Contestant #7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtYearSearch;
        private System.Windows.Forms.ComboBox cmbYearSearch;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label lblTitleSearch;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.CheckBox ckbRatingSort;
        private System.Windows.Forms.ComboBox cmbYearSort;
        private System.Windows.Forms.CheckBox ckbYearSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cmbRatingSort;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnExit;
    }
}

