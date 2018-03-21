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
            this.GetDates = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.listBoxFromDb = new System.Windows.Forms.ListBox();
            this.GetFromDestinationButton = new System.Windows.Forms.Button();
            this.listBoxFromDbNamed = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetDates
            // 
            this.GetDates.Location = new System.Drawing.Point(12, 53);
            this.GetDates.Name = "GetDates";
            this.GetDates.Size = new System.Drawing.Size(75, 23);
            this.GetDates.TabIndex = 2;
            this.GetDates.Text = "GetDates";
            this.GetDates.UseVisualStyleBackColor = true;
            this.GetDates.Click += new System.EventHandler(this.GetDates_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.HorizontalScrollbar = true;
            this.listBoxDates.Location = new System.Drawing.Point(12, 100);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.ScrollAlwaysVisible = true;
            this.listBoxDates.Size = new System.Drawing.Size(120, 95);
            this.listBoxDates.TabIndex = 3;
            // 
            // listBoxFromDb
            // 
            this.listBoxFromDb.FormattingEnabled = true;
            this.listBoxFromDb.HorizontalScrollbar = true;
            this.listBoxFromDb.Location = new System.Drawing.Point(278, 100);
            this.listBoxFromDb.Name = "listBoxFromDb";
            this.listBoxFromDb.ScrollAlwaysVisible = true;
            this.listBoxFromDb.Size = new System.Drawing.Size(120, 95);
            this.listBoxFromDb.TabIndex = 4;
            // 
            // GetFromDestinationButton
            // 
            this.GetFromDestinationButton.Location = new System.Drawing.Point(278, 53);
            this.GetFromDestinationButton.Name = "GetFromDestinationButton";
            this.GetFromDestinationButton.Size = new System.Drawing.Size(88, 41);
            this.GetFromDestinationButton.TabIndex = 5;
            this.GetFromDestinationButton.Text = "Get from Destination Db";
            this.GetFromDestinationButton.UseVisualStyleBackColor = true;
            this.GetFromDestinationButton.Click += new System.EventHandler(this.GetFromDestinationButton_Click);
            // 
            // listBoxFromDbNamed
            // 
            this.listBoxFromDbNamed.FormattingEnabled = true;
            this.listBoxFromDbNamed.HorizontalScrollbar = true;
            this.listBoxFromDbNamed.Location = new System.Drawing.Point(404, 100);
            this.listBoxFromDbNamed.Name = "listBoxFromDbNamed";
            this.listBoxFromDbNamed.ScrollAlwaysVisible = true;
            this.listBoxFromDbNamed.Size = new System.Drawing.Size(137, 95);
            this.listBoxFromDbNamed.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 261);
            this.Controls.Add(this.listBoxFromDbNamed);
            this.Controls.Add(this.GetFromDestinationButton);
            this.Controls.Add(this.listBoxFromDb);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.GetDates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GetDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.ListBox listBoxFromDb;
        private System.Windows.Forms.Button GetFromDestinationButton;
        private System.Windows.Forms.ListBox listBoxFromDbNamed;
    }
}

