namespace GITTest
{
    partial class MainMenu
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
            this.btnGetDates = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.btnFromDb = new System.Windows.Forms.Button();
            this.btnPopulateFactTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(75, 166);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(131, 50);
            this.btnGetDates.TabIndex = 0;
            this.btnGetDates.Text = "Get Dates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(75, 274);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(167, 50);
            this.btnGetProducts.TabIndex = 1;
            this.btnGetProducts.Text = "Get Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.Location = new System.Drawing.Point(75, 371);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(167, 50);
            this.btnGetCustomers.TabIndex = 2;
            this.btnGetCustomers.Text = "Get Customers";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            // 
            // btnFromDb
            // 
            this.btnFromDb.Location = new System.Drawing.Point(396, 166);
            this.btnFromDb.Name = "btnFromDb";
            this.btnFromDb.Size = new System.Drawing.Size(167, 50);
            this.btnFromDb.TabIndex = 3;
            this.btnFromDb.Text = "Get From Db";
            this.btnFromDb.UseVisualStyleBackColor = true;
            // 
            // btnPopulateFactTable
            // 
            this.btnPopulateFactTable.Location = new System.Drawing.Point(396, 274);
            this.btnPopulateFactTable.Name = "btnPopulateFactTable";
            this.btnPopulateFactTable.Size = new System.Drawing.Size(176, 66);
            this.btnPopulateFactTable.TabIndex = 4;
            this.btnPopulateFactTable.Text = "Populate Fact Table";
            this.btnPopulateFactTable.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 680);
            this.Controls.Add(this.btnPopulateFactTable);
            this.Controls.Add(this.btnFromDb);
            this.Controls.Add(this.btnGetCustomers);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.btnGetDates);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.Button btnFromDb;
        private System.Windows.Forms.Button btnPopulateFactTable;
    }
}