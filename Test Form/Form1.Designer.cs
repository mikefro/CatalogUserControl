
namespace Test_Form
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
            this.catalogProductsUC1 = new CatalogUserControl.CatalogProductsUC();
            this.SuspendLayout();
            // 
            // catalogProductsUC1
            // 
            this.catalogProductsUC1.BackColor = System.Drawing.Color.White;
            this.catalogProductsUC1.Location = new System.Drawing.Point(-1, 0);
            this.catalogProductsUC1.Name = "catalogProductsUC1";
            this.catalogProductsUC1.Size = new System.Drawing.Size(500, 574);
            this.catalogProductsUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 574);
            this.Controls.Add(this.catalogProductsUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CatalogUserControl.CatalogProductsUC catalogProductsUC1;
    }
}

