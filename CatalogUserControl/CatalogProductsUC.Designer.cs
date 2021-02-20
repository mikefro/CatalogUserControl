
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
            this.catalogScrollBar = new System.Windows.Forms.VScrollBar();
            this.sizeFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.productModelIdLabel = new System.Windows.Forms.Label();
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
            // catalogScrollBar
            // 
            this.catalogScrollBar.Location = new System.Drawing.Point(470, 54);
            this.catalogScrollBar.Name = "catalogScrollBar";
            this.catalogScrollBar.Size = new System.Drawing.Size(23, 479);
            this.catalogScrollBar.TabIndex = 1;
            this.catalogScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.catalogScrollBar_Scroll);
            // 
            // sizeFlowLayout
            // 
            this.sizeFlowLayout.AutoScroll = true;
            this.sizeFlowLayout.Location = new System.Drawing.Point(10, 19);
            this.sizeFlowLayout.Name = "sizeFlowLayout";
            this.sizeFlowLayout.Size = new System.Drawing.Size(438, 66);
            this.sizeFlowLayout.TabIndex = 2;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(84, 114);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(285, 162);
            this.productPictureBox.TabIndex = 3;
            this.productPictureBox.TabStop = false;
            // 
            // productModelIdLabel
            // 
            this.productModelIdLabel.AutoSize = true;
            this.productModelIdLabel.Location = new System.Drawing.Point(44, 79);
            this.productModelIdLabel.Name = "productModelIdLabel";
            this.productModelIdLabel.Size = new System.Drawing.Size(35, 13);
            this.productModelIdLabel.TabIndex = 4;
            this.productModelIdLabel.Text = "label1";
            // 
            // nameProductModelLabel
            // 
            this.nameProductModelLabel.AutoSize = true;
            this.nameProductModelLabel.Location = new System.Drawing.Point(205, 79);
            this.nameProductModelLabel.Name = "nameProductModelLabel";
            this.nameProductModelLabel.Size = new System.Drawing.Size(35, 13);
            this.nameProductModelLabel.TabIndex = 5;
            this.nameProductModelLabel.Text = "label2";
            // 
            // colorFlowLayout
            // 
            this.colorFlowLayout.Location = new System.Drawing.Point(10, 19);
            this.colorFlowLayout.Name = "colorFlowLayout";
            this.colorFlowLayout.Size = new System.Drawing.Size(438, 70);
            this.colorFlowLayout.TabIndex = 6;
            // 
            // sizesGroupBox
            // 
            this.sizesGroupBox.Controls.Add(this.sizeFlowLayout);
            this.sizesGroupBox.Location = new System.Drawing.Point(9, 293);
            this.sizesGroupBox.Name = "sizesGroupBox";
            this.sizesGroupBox.Size = new System.Drawing.Size(458, 91);
            this.sizesGroupBox.TabIndex = 7;
            this.sizesGroupBox.TabStop = false;
            this.sizesGroupBox.Text = "Sizes";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorFlowLayout);
            this.colorGroupBox.Location = new System.Drawing.Point(9, 390);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(458, 95);
            this.colorGroupBox.TabIndex = 8;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Colors";
            // 
            // prizeProductLabel
            // 
            this.prizeProductLabel.AutoSize = true;
            this.prizeProductLabel.Location = new System.Drawing.Point(379, 503);
            this.prizeProductLabel.Name = "prizeProductLabel";
            this.prizeProductLabel.Size = new System.Drawing.Size(35, 13);
            this.prizeProductLabel.TabIndex = 9;
            this.prizeProductLabel.Text = "label1";
            // 
            // CatalogProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prizeProductLabel);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.sizesGroupBox);
            this.Controls.Add(this.nameProductModelLabel);
            this.Controls.Add(this.productModelIdLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.catalogScrollBar);
            this.Name = "CatalogProductsUC";
            this.Size = new System.Drawing.Size(493, 533);
            this.Load += new System.EventHandler(this.CatalogProductsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.sizesGroupBox.ResumeLayout(false);
            this.colorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar catalogScrollBar;
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayout;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productModelIdLabel;
        private System.Windows.Forms.Label nameProductModelLabel;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayout;
        private System.Windows.Forms.GroupBox sizesGroupBox;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Label prizeProductLabel;
    }
}
