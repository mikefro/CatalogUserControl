
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
            this.productIdLabel = new System.Windows.Forms.Label();
            this.nameProductModelLabel = new System.Windows.Forms.Label();
            this.colorFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sizesGroupBox = new System.Windows.Forms.GroupBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.prizeProductLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subcategoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoryComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.frenchRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.sizesGroupBox.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogScrollBar
            // 
            this.catalogScrollBar.Location = new System.Drawing.Point(470, 88);
            this.catalogScrollBar.Name = "catalogScrollBar";
            this.catalogScrollBar.Size = new System.Drawing.Size(23, 471);
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
            this.productPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productPictureBox.Location = new System.Drawing.Point(99, 148);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(285, 162);
            this.productPictureBox.TabIndex = 3;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.Click += new System.EventHandler(this.productPictureBox_Click);
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(19, 112);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(35, 13);
            this.productIdLabel.TabIndex = 4;
            this.productIdLabel.Text = "label1";
            // 
            // nameProductModelLabel
            // 
            this.nameProductModelLabel.AutoSize = true;
            this.nameProductModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProductModelLabel.Location = new System.Drawing.Point(143, 97);
            this.nameProductModelLabel.Name = "nameProductModelLabel";
            this.nameProductModelLabel.Size = new System.Drawing.Size(92, 31);
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
            this.sizesGroupBox.Location = new System.Drawing.Point(12, 326);
            this.sizesGroupBox.Name = "sizesGroupBox";
            this.sizesGroupBox.Size = new System.Drawing.Size(458, 91);
            this.sizesGroupBox.TabIndex = 7;
            this.sizesGroupBox.TabStop = false;
            this.sizesGroupBox.Text = "Sizes";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorFlowLayout);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 423);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(458, 95);
            this.colorGroupBox.TabIndex = 8;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Colors";
            // 
            // prizeProductLabel
            // 
            this.prizeProductLabel.AutoSize = true;
            this.prizeProductLabel.Location = new System.Drawing.Point(349, 536);
            this.prizeProductLabel.Name = "prizeProductLabel";
            this.prizeProductLabel.Size = new System.Drawing.Size(35, 13);
            this.prizeProductLabel.TabIndex = 9;
            this.prizeProductLabel.Text = "label1";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(27, 27);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Category";
            // 
            // subcategoryLabel
            // 
            this.subcategoryLabel.AutoSize = true;
            this.subcategoryLabel.Location = new System.Drawing.Point(9, 59);
            this.subcategoryLabel.Name = "subcategoryLabel";
            this.subcategoryLabel.Size = new System.Drawing.Size(67, 13);
            this.subcategoryLabel.TabIndex = 11;
            this.subcategoryLabel.Text = "Subcategory";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(87, 19);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 12;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged_1);
            // 
            // subcategoryComboBox
            // 
            this.subcategoryComboBox.FormattingEnabled = true;
            this.subcategoryComboBox.Location = new System.Drawing.Point(86, 51);
            this.subcategoryComboBox.Name = "subcategoryComboBox";
            this.subcategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.subcategoryComboBox.TabIndex = 13;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(317, 27);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Language";
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.Location = new System.Drawing.Point(385, 25);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.englishRadioButton.TabIndex = 15;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // frenchRadioButton
            // 
            this.frenchRadioButton.AutoSize = true;
            this.frenchRadioButton.Location = new System.Drawing.Point(385, 52);
            this.frenchRadioButton.Name = "frenchRadioButton";
            this.frenchRadioButton.Size = new System.Drawing.Size(58, 17);
            this.frenchRadioButton.TabIndex = 16;
            this.frenchRadioButton.Text = "French";
            this.frenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // CatalogProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frenchRadioButton);
            this.Controls.Add(this.englishRadioButton);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.subcategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.subcategoryLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.prizeProductLabel);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.sizesGroupBox);
            this.Controls.Add(this.nameProductModelLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.catalogScrollBar);
            this.Name = "CatalogProductsUC";
            this.Size = new System.Drawing.Size(493, 566);
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
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label nameProductModelLabel;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayout;
        private System.Windows.Forms.GroupBox sizesGroupBox;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Label prizeProductLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label subcategoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox subcategoryComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.RadioButton frenchRadioButton;
    }
}
