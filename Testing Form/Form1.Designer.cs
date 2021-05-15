
namespace CatalogUserControl
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
            this.frenchRadioButton = new System.Windows.Forms.RadioButton();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.languageLabel = new System.Windows.Forms.Label();
            this.subcategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoryLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.catalogFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.positionscrollTextBox = new System.Windows.Forms.TextBox();
            this.catalogProductsUC1 = new CatalogUserControl.CatalogProductsUC();
            this.catalogFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // frenchRadioButton
            // 
            this.frenchRadioButton.AutoSize = true;
            this.frenchRadioButton.ForeColor = System.Drawing.Color.Navy;
            this.frenchRadioButton.Location = new System.Drawing.Point(465, 68);
            this.frenchRadioButton.Name = "frenchRadioButton";
            this.frenchRadioButton.Size = new System.Drawing.Size(58, 17);
            this.frenchRadioButton.TabIndex = 23;
            this.frenchRadioButton.Text = "French";
            this.frenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.ForeColor = System.Drawing.Color.Navy;
            this.englishRadioButton.Location = new System.Drawing.Point(465, 41);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.englishRadioButton.TabIndex = 22;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.Navy;
            this.languageLabel.Location = new System.Drawing.Point(397, 43);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(63, 13);
            this.languageLabel.TabIndex = 21;
            this.languageLabel.Text = "Language";
            // 
            // subcategoryComboBox
            // 
            this.subcategoryComboBox.ForeColor = System.Drawing.Color.Navy;
            this.subcategoryComboBox.FormattingEnabled = true;
            this.subcategoryComboBox.Location = new System.Drawing.Point(166, 67);
            this.subcategoryComboBox.Name = "subcategoryComboBox";
            this.subcategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.subcategoryComboBox.TabIndex = 20;
            this.subcategoryComboBox.SelectedValueChanged += new System.EventHandler(this.subcategoryComboBox_SelectedValueChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.ForeColor = System.Drawing.Color.Navy;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(167, 35);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 19;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            // 
            // subcategoryLabel
            // 
            this.subcategoryLabel.AutoSize = true;
            this.subcategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcategoryLabel.ForeColor = System.Drawing.Color.Navy;
            this.subcategoryLabel.Location = new System.Drawing.Point(89, 75);
            this.subcategoryLabel.Name = "subcategoryLabel";
            this.subcategoryLabel.Size = new System.Drawing.Size(78, 13);
            this.subcategoryLabel.TabIndex = 18;
            this.subcategoryLabel.Text = "Subcategory";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.Navy;
            this.categoryLabel.Location = new System.Drawing.Point(107, 43);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 13);
            this.categoryLabel.TabIndex = 17;
            this.categoryLabel.Text = "Category";
            // 
            // catalogFlowLayout
            // 
            this.catalogFlowLayout.AutoScroll = true;
            this.catalogFlowLayout.Controls.Add(this.catalogProductsUC1);
            this.catalogFlowLayout.Location = new System.Drawing.Point(30, 137);
            this.catalogFlowLayout.Name = "catalogFlowLayout";
            this.catalogFlowLayout.Size = new System.Drawing.Size(873, 297);
            this.catalogFlowLayout.TabIndex = 24;
            this.catalogFlowLayout.Scroll += new System.Windows.Forms.ScrollEventHandler(this.catalogFlowLayout_Scroll);
            // 
            // positionscrollTextBox
            // 
            this.positionscrollTextBox.Location = new System.Drawing.Point(694, 41);
            this.positionscrollTextBox.Name = "positionscrollTextBox";
            this.positionscrollTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionscrollTextBox.TabIndex = 25;
            // 
            // catalogProductsUC1
            // 
            this.catalogProductsUC1.BackColor = System.Drawing.Color.White;
            this.catalogProductsUC1.Location = new System.Drawing.Point(3, 3);
            this.catalogProductsUC1.Name = "catalogProductsUC1";
            this.catalogProductsUC1.Size = new System.Drawing.Size(464, 288);
            this.catalogProductsUC1.TabIndex = 0;
            this.catalogProductsUC1.Load += new System.EventHandler(this.catalogProductsUC1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 514);
            this.Controls.Add(this.positionscrollTextBox);
            this.Controls.Add(this.catalogFlowLayout);
            this.Controls.Add(this.frenchRadioButton);
            this.Controls.Add(this.englishRadioButton);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.subcategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.subcategoryLabel);
            this.Controls.Add(this.categoryLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.catalogFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton frenchRadioButton;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox subcategoryComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label subcategoryLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.FlowLayoutPanel catalogFlowLayout;
        private System.Windows.Forms.TextBox positionscrollTextBox;
        private CatalogUserControl.CatalogProductsUC catalogProductsUC1;
    }
}

