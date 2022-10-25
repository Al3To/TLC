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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTotalCosts));
            this.labelCosts = new System.Windows.Forms.Label();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCosts
            // 
            this.labelCosts.AutoSize = true;
            this.labelCosts.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCosts.Location = new System.Drawing.Point(12, 9);
            this.labelCosts.Name = "labelCosts";
            this.labelCosts.Size = new System.Drawing.Size(0, 16);
            this.labelCosts.TabIndex = 0;
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureClose.Location = new System.Drawing.Point(393, 4);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(23, 21);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pictureClose.MouseEnter += new System.EventHandler(this.pictureClose_MouseEnter);
            this.pictureClose.MouseLeave += new System.EventHandler(this.pictureClose_MouseLeave);
            // 
            // FormTotalCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.labelCosts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTotalCosts";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTotalCosts_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCosts;
        private System.Windows.Forms.PictureBox pictureClose;
    }
}