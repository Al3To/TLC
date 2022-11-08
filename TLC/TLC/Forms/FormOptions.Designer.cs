namespace TLC.Forms
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.labelLanguage = new System.Windows.Forms.Label();
            this.btnApply = new TLC.CustomButton.CustomButton();
            this.SuspendLayout();
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnApply.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnApply.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnApply.BorderRadius = 20;
            this.btnApply.BorderSize = 0;
            this.btnApply.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Name = "btnApply";
            this.btnApply.TextColor = System.Drawing.Color.White;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FormOptions
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.labelLanguage);
            this.Name = "FormOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLanguage;
        private CustomButton.CustomButton btnApply;
    }
}