/// Contestant # 510
/// Currency Conversion Program # 1

namespace CurrencyConversion
{
    partial class CurrencyConversion
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
            this.ContestantNumber = new System.Windows.Forms.Label();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.CurrencyTypes = new System.Windows.Forms.ComboBox();
            this.CurrencyTypeLabel = new System.Windows.Forms.Label();
            this.CurrencyAmountLabel = new System.Windows.Forms.Label();
            this.CurrencyAmount = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContestantNumber
            // 
            this.ContestantNumber.AutoSize = true;
            this.ContestantNumber.Location = new System.Drawing.Point(129, 9);
            this.ContestantNumber.Name = "ContestantNumber";
            this.ContestantNumber.Size = new System.Drawing.Size(122, 13);
            this.ContestantNumber.TabIndex = 0;
            this.ContestantNumber.Text = "Contestant Number: 510";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Location = new System.Drawing.Point(100, 31);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(208, 13);
            this.ProgramLabel.TabIndex = 1;
            this.ProgramLabel.Text = "Program #1: Currency Conversion Program";
            // 
            // CurrencyTypes
            // 
            this.CurrencyTypes.FormattingEnabled = true;
            this.CurrencyTypes.Items.AddRange(new object[] {
            "British Pound",
            "French Francs",
            "Italian Lire",
            "German Deutsche Mark",
            "Spanish Pesetas",
            "All"});
            this.CurrencyTypes.Location = new System.Drawing.Point(169, 85);
            this.CurrencyTypes.Name = "CurrencyTypes";
            this.CurrencyTypes.Size = new System.Drawing.Size(137, 21);
            this.CurrencyTypes.TabIndex = 1;
            this.CurrencyTypes.Text = "Select Currency Type";
            // 
            // CurrencyTypeLabel
            // 
            this.CurrencyTypeLabel.AutoSize = true;
            this.CurrencyTypeLabel.Location = new System.Drawing.Point(100, 88);
            this.CurrencyTypeLabel.Name = "CurrencyTypeLabel";
            this.CurrencyTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.CurrencyTypeLabel.TabIndex = 3;
            this.CurrencyTypeLabel.Text = "Convert To:";
            // 
            // CurrencyAmountLabel
            // 
            this.CurrencyAmountLabel.AutoSize = true;
            this.CurrencyAmountLabel.Location = new System.Drawing.Point(100, 60);
            this.CurrencyAmountLabel.Name = "CurrencyAmountLabel";
            this.CurrencyAmountLabel.Size = new System.Drawing.Size(100, 13);
            this.CurrencyAmountLabel.TabIndex = 4;
            this.CurrencyAmountLabel.Text = "U.S. Dollar Amount:";
            // 
            // CurrencyAmount
            // 
            this.CurrencyAmount.Location = new System.Drawing.Point(206, 57);
            this.CurrencyAmount.Name = "CurrencyAmount";
            this.CurrencyAmount.Size = new System.Drawing.Size(100, 20);
            this.CurrencyAmount.TabIndex = 0;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(12, 169);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "&Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(93, 169);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "C&lear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(176, 169);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(0, 116);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(378, 50);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrencyConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 204);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.CurrencyAmount);
            this.Controls.Add(this.CurrencyAmountLabel);
            this.Controls.Add(this.CurrencyTypeLabel);
            this.Controls.Add(this.CurrencyTypes);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.ContestantNumber);
            this.Name = "CurrencyConversion";
            this.Text = "Currency Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContestantNumber;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.ComboBox CurrencyTypes;
        private System.Windows.Forms.Label CurrencyTypeLabel;
        private System.Windows.Forms.Label CurrencyAmountLabel;
        private System.Windows.Forms.TextBox CurrencyAmount;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

