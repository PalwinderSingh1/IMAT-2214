namespace GITTest
{
    partial class Mohammed
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
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(121, 136);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(164, 60);
            this.btnGetCustomer.TabIndex = 0;
            this.btnGetCustomer.Text = "GetCustomer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 25;
            this.listBoxCustomers.Location = new System.Drawing.Point(121, 275);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(517, 504);
            this.listBoxCustomers.TabIndex = 1;
            // 
            // Mohammed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 899);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.btnGetCustomer);
            this.Name = "Mohammed";
            this.Text = "Mohammed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.ListBox listBoxCustomers;
    }
}