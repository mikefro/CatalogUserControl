
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
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.sizesGroupBox.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogScrollBar
            // 
            this.catalogScrollBar.Location = new System.Drawing.Point(483, 13);
            this.catalogScrollBar.Name = "catalogScrollBar";
            this.catalogScrollBar.Size = new System.Drawing.Size(23, 467);
            this.catalogScrollBar.TabIndex = 1;
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
            this.productPictureBox.Location = new System.Drawing.Point(97, 109);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(285, 162);
            this.productPictureBox.TabIndex = 3;
            this.productPictureBox.TabStop = false;
            // 
            // productModelIdLabel
            // 
            this.productModelIdLabel.AutoSize = true;
            this.productModelIdLabel.Location = new System.Drawing.Point(57, 74);
            this.productModelIdLabel.Name = "productModelIdLabel";
            this.productModelIdLabel.Size = new System.Drawing.Size(35, 13);
            this.productModelIdLabel.TabIndex = 4;
            this.productModelIdLabel.Text = "label1";
            // 
            // nameProductModelLabel
            // 
            this.nameProductModelLabel.AutoSize = true;
            this.nameProductModelLabel.Location = new System.Drawing.Point(218, 74);
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
            this.sizesGroupBox.Location = new System.Drawing.Point(22, 288);
            this.sizesGroupBox.Name = "sizesGroupBox";
            this.sizesGroupBox.Size = new System.Drawing.Size(458, 91);
            this.sizesGroupBox.TabIndex = 7;
            this.sizesGroupBox.TabStop = false;
            this.sizesGroupBox.Text = "Sizes";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorFlowLayout);
            this.colorGroupBox.Location = new System.Drawing.Point(22, 385);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(458, 95);
            this.colorGroupBox.TabIndex = 8;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Colors";
            // 
            // CatalogProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.sizesGroupBox);
            this.Controls.Add(this.nameProductModelLabel);
            this.Controls.Add(this.productModelIdLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.catalogScrollBar);
            this.Name = "CatalogProductsUC";
            this.Size = new System.Drawing.Size(518, 533);
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
    }
}
