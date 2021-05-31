
namespace CatalogUserControl
{
    partial class CatalogProductsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.nameProductModelLabel = new System.Windows.Forms.Label();
            this.colorFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sizesGroupBox = new System.Windows.Forms.GroupBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.prizeProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.sizesGroupBox.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeFlowLayout
            // 
            this.sizeFlowLayout.AutoScroll = true;
            this.sizeFlowLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeFlowLayout.Location = new System.Drawing.Point(10, 19);
            this.sizeFlowLayout.Name = "sizeFlowLayout";
            this.sizeFlowLayout.Size = new System.Drawing.Size(178, 66);
            this.sizeFlowLayout.TabIndex = 2;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productPictureBox.Location = new System.Drawing.Point(17, 58);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(181, 136);
            this.productPictureBox.TabIndex = 3;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.Click += new System.EventHandler(this.productPictureBox_Click);
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.productIdLabel.Location = new System.Drawing.Point(14, 211);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(51, 16);
            this.productIdLabel.TabIndex = 4;
            this.productIdLabel.Text = "label1";
            // 
            // nameProductModelLabel
            // 
            this.nameProductModelLabel.AutoSize = true;
            this.nameProductModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProductModelLabel.ForeColor = System.Drawing.Color.Blue;
            this.nameProductModelLabel.Location = new System.Drawing.Point(13, 21);
            this.nameProductModelLabel.Name = "nameProductModelLabel";
            this.nameProductModelLabel.Size = new System.Drawing.Size(66, 24);
            this.nameProductModelLabel.TabIndex = 5;
            this.nameProductModelLabel.Text = "label2";
            // 
            // colorFlowLayout
            // 
            this.colorFlowLayout.Location = new System.Drawing.Point(10, 19);
            this.colorFlowLayout.Name = "colorFlowLayout";
            this.colorFlowLayout.Size = new System.Drawing.Size(178, 70);
            this.colorFlowLayout.TabIndex = 6;
            // 
            // sizesGroupBox
            // 
            this.sizesGroupBox.Controls.Add(this.sizeFlowLayout);
            this.sizesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizesGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.sizesGroupBox.Location = new System.Drawing.Point(238, 58);
            this.sizesGroupBox.Name = "sizesGroupBox";
            this.sizesGroupBox.Size = new System.Drawing.Size(198, 92);
            this.sizesGroupBox.TabIndex = 7;
            this.sizesGroupBox.TabStop = false;
            this.sizesGroupBox.Text = "Sizes";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorFlowLayout);
            this.colorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.colorGroupBox.Location = new System.Drawing.Point(238, 169);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(198, 95);
            this.colorGroupBox.TabIndex = 8;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Colors";
            // 
            // prizeProductLabel
            // 
            this.prizeProductLabel.AutoSize = true;
            this.prizeProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeProductLabel.ForeColor = System.Drawing.Color.Blue;
            this.prizeProductLabel.Location = new System.Drawing.Point(13, 234);
            this.prizeProductLabel.Name = "prizeProductLabel";
            this.prizeProductLabel.Size = new System.Drawing.Size(66, 24);
            this.prizeProductLabel.TabIndex = 9;
            this.prizeProductLabel.Text = "label1";
            // 
            // CatalogProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.prizeProductLabel);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.sizesGroupBox);
            this.Controls.Add(this.nameProductModelLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "CatalogProductsUC";
            this.Size = new System.Drawing.Size(450, 270);
            this.Load += new System.EventHandler(this.CatalogProductsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.sizesGroupBox.ResumeLayout(false);
            this.colorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayout;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label nameProductModelLabel;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayout;
        private System.Windows.Forms.GroupBox sizesGroupBox;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Label prizeProductLabel;
    }
}
