namespace GITTest
{
    partial class GetProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetProducts));
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.lstboxGetProducts = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGetfromDesinitionDb = new System.Windows.Forms.Button();
            this.listBoxFromDbNamed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(48, 138);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(206, 47);
            this.btnGetProducts.TabIndex = 0;
            this.btnGetProducts.Text = "Get Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // lstboxGetProducts
            // 
            this.lstboxGetProducts.FormattingEnabled = true;
            this.lstboxGetProducts.ItemHeight = 25;
            this.lstboxGetProducts.Location = new System.Drawing.Point(48, 201);
            this.lstboxGetProducts.Name = "lstboxGetProducts";
            this.lstboxGetProducts.Size = new System.Drawing.Size(553, 404);
            this.lstboxGetProducts.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(994, 635);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1061, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(48, 635);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 52);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGetfromDesinitionDb
            // 
            this.btnGetfromDesinitionDb.Location = new System.Drawing.Point(669, 137);
            this.btnGetfromDesinitionDb.Name = "btnGetfromDesinitionDb";
            this.btnGetfromDesinitionDb.Size = new System.Drawing.Size(270, 48);
            this.btnGetfromDesinitionDb.TabIndex = 13;
            this.btnGetfromDesinitionDb.Text = "Get from Destination Db";
            this.btnGetfromDesinitionDb.UseVisualStyleBackColor = true;
            this.btnGetfromDesinitionDb.Click += new System.EventHandler(this.btnGetfromDesinitionDb_Click);
            // 
            // listBoxFromDbNamed
            // 
            this.listBoxFromDbNamed.FormattingEnabled = true;
            this.listBoxFromDbNamed.ItemHeight = 25;
            this.listBoxFromDbNamed.Location = new System.Drawing.Point(669, 201);
            this.listBoxFromDbNamed.Name = "listBoxFromDbNamed";
            this.listBoxFromDbNamed.Size = new System.Drawing.Size(478, 404);
            this.listBoxFromDbNamed.TabIndex = 14;
            // 
            // GetProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1227, 904);
            this.Controls.Add(this.listBoxFromDbNamed);
            this.Controls.Add(this.btnGetfromDesinitionDb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstboxGetProducts);
            this.Controls.Add(this.btnGetProducts);
            this.Name = "GetProducts";
            this.Text = "Harminder";
            this.Load += new System.EventHandler(this.GetProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox lstboxGetProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGetfromDesinitionDb;
        private System.Windows.Forms.ListBox listBoxFromDbNamed;
    }
}