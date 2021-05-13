namespace Total_Sales_and_Sales_Analysis
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.calculatedTotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageSalesLabel = new System.Windows.Forms.Label();
            this.largestLabel = new System.Windows.Forms.Label();
            this.largestSaleLabel = new System.Windows.Forms.Label();
            this.smallestLabel = new System.Windows.Forms.Label();
            this.smallestSaleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 196);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(108, 13);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "The total sales is:";
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.Location = new System.Drawing.Point(12, 12);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(236, 147);
            this.salesListBox.TabIndex = 2;
            // 
            // calculatedTotalLabel
            // 
            this.calculatedTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedTotalLabel.Location = new System.Drawing.Point(145, 191);
            this.calculatedTotalLabel.Name = "calculatedTotalLabel";
            this.calculatedTotalLabel.Size = new System.Drawing.Size(122, 23);
            this.calculatedTotalLabel.TabIndex = 3;
            this.calculatedTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(264, 47);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 34);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(9, 226);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 13);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.Text = "The average is: ";
            // 
            // averageSalesLabel
            // 
            this.averageSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageSalesLabel.Location = new System.Drawing.Point(145, 221);
            this.averageSalesLabel.Name = "averageSalesLabel";
            this.averageSalesLabel.Size = new System.Drawing.Size(122, 23);
            this.averageSalesLabel.TabIndex = 7;
            this.averageSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // largestLabel
            // 
            this.largestLabel.AutoSize = true;
            this.largestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largestLabel.Location = new System.Drawing.Point(9, 258);
            this.largestLabel.Name = "largestLabel";
            this.largestLabel.Size = new System.Drawing.Size(123, 13);
            this.largestLabel.TabIndex = 8;
            this.largestLabel.Text = "The largest value is:";
            // 
            // largestSaleLabel
            // 
            this.largestSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largestSaleLabel.Location = new System.Drawing.Point(145, 253);
            this.largestSaleLabel.Name = "largestSaleLabel";
            this.largestSaleLabel.Size = new System.Drawing.Size(122, 23);
            this.largestSaleLabel.TabIndex = 9;
            this.largestSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallestLabel
            // 
            this.smallestLabel.AutoSize = true;
            this.smallestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallestLabel.Location = new System.Drawing.Point(9, 291);
            this.smallestLabel.Name = "smallestLabel";
            this.smallestLabel.Size = new System.Drawing.Size(130, 13);
            this.smallestLabel.TabIndex = 10;
            this.smallestLabel.Text = "The smallest value is:";
            // 
            // smallestSaleLabel
            // 
            this.smallestSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallestSaleLabel.Location = new System.Drawing.Point(145, 286);
            this.smallestSaleLabel.Name = "smallestSaleLabel";
            this.smallestSaleLabel.Size = new System.Drawing.Size(122, 23);
            this.smallestSaleLabel.TabIndex = 11;
            this.smallestSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 323);
            this.Controls.Add(this.smallestSaleLabel);
            this.Controls.Add(this.smallestLabel);
            this.Controls.Add(this.largestSaleLabel);
            this.Controls.Add(this.largestLabel);
            this.Controls.Add(this.averageSalesLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calculatedTotalLabel);
            this.Controls.Add(this.salesListBox);
            this.Controls.Add(this.totalLabel);
            this.Name = "Form1";
            this.Text = "Total Sales and Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.Label calculatedTotalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageSalesLabel;
        private System.Windows.Forms.Label largestLabel;
        private System.Windows.Forms.Label largestSaleLabel;
        private System.Windows.Forms.Label smallestLabel;
        private System.Windows.Forms.Label smallestSaleLabel;
    }
}

