namespace TLC
{
    partial class FormIndex
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_GenerateTblRand = new TLC.CustomButton.CustomButton();
            this.btnSolve = new TLC.CustomButton.CustomButton();
            this.btnGenerateDGV = new TLC.CustomButton.CustomButton();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelWindowControl = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.pictureOptions = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelWindowControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.pictureOptions);
            this.panelTitle.Controls.Add(this.btn_GenerateTblRand);
            this.panelTitle.Controls.Add(this.btnSolve);
            this.panelTitle.Controls.Add(this.btnGenerateDGV);
            this.panelTitle.Controls.Add(this.labelRows);
            this.panelTitle.Controls.Add(this.labelColumns);
            this.panelTitle.Controls.Add(this.textBoxRows);
            this.panelTitle.Controls.Add(this.textBoxColumns);
            this.panelTitle.Controls.Add(this.panelLogo);
            this.panelTitle.Controls.Add(this.panelWindowControl);
            resources.ApplyResources(this.panelTitle, "panelTitle");
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btn_GenerateTblRand
            // 
            this.btn_GenerateTblRand.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_GenerateTblRand.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_GenerateTblRand.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_GenerateTblRand.BorderRadius = 20;
            this.btn_GenerateTblRand.BorderSize = 0;
            this.btn_GenerateTblRand.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_GenerateTblRand, "btn_GenerateTblRand");
            this.btn_GenerateTblRand.FlatAppearance.BorderSize = 0;
            this.btn_GenerateTblRand.ForeColor = System.Drawing.Color.White;
            this.btn_GenerateTblRand.Name = "btn_GenerateTblRand";
            this.btn_GenerateTblRand.TextColor = System.Drawing.Color.White;
            this.btn_GenerateTblRand.UseVisualStyleBackColor = false;
            this.btn_GenerateTblRand.Click += new System.EventHandler(this.btn_GenerateTblRand_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSolve.BorderRadius = 20;
            this.btnSolve.BorderSize = 0;
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSolve, "btnSolve");
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.TextColor = System.Drawing.Color.White;
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnGenerateDGV
            // 
            this.btnGenerateDGV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerateDGV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerateDGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerateDGV.BorderRadius = 20;
            this.btnGenerateDGV.BorderSize = 0;
            this.btnGenerateDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateDGV.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnGenerateDGV, "btnGenerateDGV");
            this.btnGenerateDGV.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDGV.Name = "btnGenerateDGV";
            this.btnGenerateDGV.TextColor = System.Drawing.Color.White;
            this.btnGenerateDGV.UseVisualStyleBackColor = false;
            this.btnGenerateDGV.Click += new System.EventHandler(this.btnGenerateDGV_Click);
            // 
            // labelRows
            // 
            resources.ApplyResources(this.labelRows, "labelRows");
            this.labelRows.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRows.Name = "labelRows";
            // 
            // labelColumns
            // 
            resources.ApplyResources(this.labelColumns, "labelColumns");
            this.labelColumns.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelColumns.Name = "labelColumns";
            // 
            // textBoxRows
            // 
            this.textBoxRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBoxRows.ForeColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.textBoxRows, "textBoxRows");
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.ShortcutsEnabled = false;
            this.textBoxRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRows_KeyPress);
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBoxColumns.ForeColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.textBoxColumns, "textBoxColumns");
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.ShortcutsEnabled = false;
            this.textBoxColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColumns_KeyPress);
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // panelWindowControl
            // 
            resources.ApplyResources(this.panelWindowControl, "panelWindowControl");
            this.panelWindowControl.Controls.Add(this.pictureClose);
            this.panelWindowControl.Controls.Add(this.pictureMinimize);
            this.panelWindowControl.Controls.Add(this.pictureMaximize);
            this.panelWindowControl.Name = "panelWindowControl";
            this.panelWindowControl.MouseEnter += new System.EventHandler(this.panelWindowControl_MouseEnter);
            this.panelWindowControl.MouseLeave += new System.EventHandler(this.panelWindowControl_MouseLeave);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureClose, "pictureClose");
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pictureClose.MouseEnter += new System.EventHandler(this.pictureClose_MouseEnter);
            // 
            // pictureMinimize
            // 
            resources.ApplyResources(this.pictureMinimize, "pictureMinimize");
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            this.pictureMinimize.MouseEnter += new System.EventHandler(this.pictureMinimize_MouseEnter);
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureMaximize, "pictureMaximize");
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.TabStop = false;
            this.pictureMaximize.Click += new System.EventHandler(this.pictureMaximize_Click);
            this.pictureMaximize.MouseEnter += new System.EventHandler(this.pictureMaximize_MouseEnter);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.DGV, "DGV");
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGV.Name = "DGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_EditingControlShowing);
            this.DGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_KeyPress);
            // 
            // pictureOptions
            // 
            resources.ApplyResources(this.pictureOptions, "pictureOptions");
            this.pictureOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureOptions.Name = "pictureOptions";
            this.pictureOptions.TabStop = false;
            this.pictureOptions.Click += new System.EventHandler(this.pictureOptions_Click);
            // 
            // FormIndex
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormIndex";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelWindowControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureMaximize;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Panel panelWindowControl;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelRows;
        private CustomButton.CustomButton btnGenerateDGV;
        private CustomButton.CustomButton btnSolve;
        private CustomButton.CustomButton btn_GenerateTblRand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureOptions;
    }
}

