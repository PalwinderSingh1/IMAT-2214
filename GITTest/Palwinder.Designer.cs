namespace GITTest
{
    partial class GetDates
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
            this.listBoxFromDbNamed = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.btnGetDates.Location = new System.Drawing.Point(31, 131);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(204, 48);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "Get Dates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 25;
            this.listBoxDates.Location = new System.Drawing.Point(31, 193);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(277, 379);
            this.listBoxDates.TabIndex = 3;
            // 
            // btnGetfromDesinitionDb
            // 
            this.btnGetfromDesinitionDb.Location = new System.Drawing.Point(432, 131);
            this.btnGetfromDesinitionDb.Name = "btnGetfromDesinitionDb";
            this.btnGetfromDesinitionDb.Size = new System.Drawing.Size(270, 48);
            this.btnGetfromDesinitionDb.TabIndex = 4;
            this.btnGetfromDesinitionDb.Text = "Get from Destination Db";
            this.btnGetfromDesinitionDb.UseVisualStyleBackColor = true;
            this.btnGetfromDesinitionDb.Click += new System.EventHandler(this.btnGetfromDesinitionDb_Click);
            // 
            // listBoxFromDbNamed
            // 
            this.listBoxFromDbNamed.FormattingEnabled = true;
            this.listBoxFromDbNamed.ItemHeight = 25;
            this.listBoxFromDbNamed.Location = new System.Drawing.Point(432, 193);
            this.listBoxFromDbNamed.Name = "listBoxFromDbNamed";
            this.listBoxFromDbNamed.Size = new System.Drawing.Size(283, 379);
            this.listBoxFromDbNamed.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(562, 706);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 52);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(31, 706);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 52);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GetDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(739, 807);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listBoxFromDbNamed);
            this.Controls.Add(this.btnGetfromDesinitionDb);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.btnGetDates);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GetDates";
            this.Text = "Palwinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnGetfromDesinitionDb;
        private System.Windows.Forms.ListBox listBoxFromDbNamed;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
    }
}

