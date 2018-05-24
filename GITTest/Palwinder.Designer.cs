namespace GITTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.btnGetfromDesinitionDb = new System.Windows.Forms.Button();
            this.listBoxFromDb = new System.Windows.Forms.ListBox();
            this.listBoxFromDbNamed = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(31, 115);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(186, 58);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 25;
            this.listBoxDates.Location = new System.Drawing.Point(31, 226);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(298, 229);
            this.listBoxDates.TabIndex = 3;
            // 
            // btnGetfromDesinitionDb
            // 
            this.btnGetfromDesinitionDb.Location = new System.Drawing.Point(521, 107);
            this.btnGetfromDesinitionDb.Name = "btnGetfromDesinitionDb";
            this.btnGetfromDesinitionDb.Size = new System.Drawing.Size(162, 75);
            this.btnGetfromDesinitionDb.TabIndex = 4;
            this.btnGetfromDesinitionDb.Text = "Get from Destination Db";
            this.btnGetfromDesinitionDb.UseVisualStyleBackColor = true;
            this.btnGetfromDesinitionDb.Click += new System.EventHandler(this.btnGetfromDesinitionDb_Click);
            // 
            // listBoxFromDb
            // 
            this.listBoxFromDb.FormattingEnabled = true;
            this.listBoxFromDb.ItemHeight = 25;
            this.listBoxFromDb.Location = new System.Drawing.Point(521, 218);
            this.listBoxFromDb.Name = "listBoxFromDb";
            this.listBoxFromDb.Size = new System.Drawing.Size(307, 229);
            this.listBoxFromDb.TabIndex = 5;
            // 
            // listBoxFromDbNamed
            // 
            this.listBoxFromDbNamed.FormattingEnabled = true;
            this.listBoxFromDbNamed.ItemHeight = 25;
            this.listBoxFromDbNamed.Location = new System.Drawing.Point(937, 218);
            this.listBoxFromDbNamed.Name = "listBoxFromDbNamed";
            this.listBoxFromDbNamed.Size = new System.Drawing.Size(280, 229);
            this.listBoxFromDbNamed.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 699);
            this.Controls.Add(this.listBoxFromDbNamed);
            this.Controls.Add(this.listBoxFromDb);
            this.Controls.Add(this.btnGetfromDesinitionDb);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.btnGetDates);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Palwinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnGetfromDesinitionDb;
        private System.Windows.Forms.ListBox listBoxFromDb;
        private System.Windows.Forms.ListBox listBoxFromDbNamed;
    }
}

