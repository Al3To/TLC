namespace TLC.Forms
{
    partial class FormTotalCosts
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
            this.labelCosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCosts
            // 
            this.labelCosts.AutoSize = true;
            this.labelCosts.Location = new System.Drawing.Point(12, 9);
            this.labelCosts.Name = "labelCosts";
            this.labelCosts.Size = new System.Drawing.Size(0, 16);
            this.labelCosts.TabIndex = 0;
            // 
            // FormTotalCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.labelCosts);
            this.Name = "FormTotalCosts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCosts;
    }
}