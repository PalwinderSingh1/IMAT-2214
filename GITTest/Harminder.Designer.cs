﻿namespace GITTest
{
    partial class Harminder
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
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.lstboxGetProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(79, 122);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(168, 68);
            this.btnGetProducts.TabIndex = 0;
            this.btnGetProducts.Text = "Get Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // lstboxGetProducts
            // 
            this.lstboxGetProducts.FormattingEnabled = true;
            this.lstboxGetProducts.ItemHeight = 25;
            this.lstboxGetProducts.Location = new System.Drawing.Point(79, 217);
            this.lstboxGetProducts.Name = "lstboxGetProducts";
            this.lstboxGetProducts.Size = new System.Drawing.Size(599, 529);
            this.lstboxGetProducts.TabIndex = 1;
            // 
            // Harminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 792);
            this.Controls.Add(this.lstboxGetProducts);
            this.Controls.Add(this.btnGetProducts);
            this.Name = "Harminder";
            this.Text = "Harminder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox lstboxGetProducts;
    }
}