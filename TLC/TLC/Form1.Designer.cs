namespace TLC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
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
            this.btnSolve = new TLC.CustomButton.CustomButton();
            this.panelTitle.SuspendLayout();
            this.panelWindowControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTitle.Controls.Add(this.btnSolve);
            this.panelTitle.Controls.Add(this.btnGenerateDGV);
            this.panelTitle.Controls.Add(this.labelRows);
            this.panelTitle.Controls.Add(this.labelColumns);
            this.panelTitle.Controls.Add(this.textBoxRows);
            this.panelTitle.Controls.Add(this.textBoxColumns);
            this.panelTitle.Controls.Add(this.panelLogo);
            this.panelTitle.Controls.Add(this.panelWindowControl);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1024, 99);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnGenerateDGV
            // 
            this.btnGenerateDGV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerateDGV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerateDGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerateDGV.BorderRadius = 20;
            this.btnGenerateDGV.BorderSize = 0;
            this.btnGenerateDGV.FlatAppearance.BorderSize = 0;
            this.btnGenerateDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateDGV.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDGV.Location = new System.Drawing.Point(419, 31);
            this.btnGenerateDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateDGV.Name = "btnGenerateDGV";
            this.btnGenerateDGV.Size = new System.Drawing.Size(150, 41);
            this.btnGenerateDGV.TabIndex = 9;
            this.btnGenerateDGV.Text = "Genera Tabella";
            this.btnGenerateDGV.TextColor = System.Drawing.Color.White;
            this.btnGenerateDGV.UseVisualStyleBackColor = false;
            this.btnGenerateDGV.Click += new System.EventHandler(this.btnGenerateDGV_Click);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRows.Location = new System.Drawing.Point(187, 68);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(67, 16);
            this.labelRows.TabIndex = 8;
            this.labelRows.Text = "Produttori:";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelColumns.Location = new System.Drawing.Point(169, 17);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(85, 16);
            this.labelColumns.TabIndex = 7;
            this.labelColumns.Text = "Consumatori:";
            // 
            // textBoxRows
            // 
            this.textBoxRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBoxRows.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRows.Location = new System.Drawing.Point(281, 66);
            this.textBoxRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.ShortcutsEnabled = false;
            this.textBoxRows.Size = new System.Drawing.Size(131, 22);
            this.textBoxRows.TabIndex = 6;
            this.textBoxRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRows_KeyPress);
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBoxColumns.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxColumns.Location = new System.Drawing.Point(281, 16);
            this.textBoxColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.ShortcutsEnabled = false;
            this.textBoxColumns.Size = new System.Drawing.Size(131, 22);
            this.textBoxColumns.TabIndex = 5;
            this.textBoxColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColumns_KeyPress);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(162, 99);
            this.panelLogo.TabIndex = 4;
            // 
            // panelWindowControl
            // 
            this.panelWindowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWindowControl.Controls.Add(this.pictureClose);
            this.panelWindowControl.Controls.Add(this.pictureMinimize);
            this.panelWindowControl.Controls.Add(this.pictureMaximize);
            this.panelWindowControl.Location = new System.Drawing.Point(930, 0);
            this.panelWindowControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWindowControl.Name = "panelWindowControl";
            this.panelWindowControl.Size = new System.Drawing.Size(91, 27);
            this.panelWindowControl.TabIndex = 3;
            this.panelWindowControl.MouseEnter += new System.EventHandler(this.panelWindowControl_MouseEnter);
            this.panelWindowControl.MouseLeave += new System.EventHandler(this.panelWindowControl_MouseLeave);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(62, 4);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(23, 21);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pictureClose.MouseEnter += new System.EventHandler(this.pictureClose_MouseEnter);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(3, 4);
            this.pictureMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(23, 21);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimize.TabIndex = 1;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            this.pictureMinimize.MouseEnter += new System.EventHandler(this.pictureMinimize_MouseEnter);
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximize.Image")));
            this.pictureMaximize.Location = new System.Drawing.Point(32, 4);
            this.pictureMaximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(23, 21);
            this.pictureMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMaximize.TabIndex = 2;
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
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGV.Location = new System.Drawing.Point(0, 99);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1024, 413);
            this.DGV.TabIndex = 1;
            this.DGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_EditingControlShowing);
            this.DGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_KeyPress);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSolve.BorderRadius = 20;
            this.btnSolve.BorderSize = 0;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Location = new System.Drawing.Point(874, 50);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(150, 41);
            this.btnSolve.TabIndex = 10;
            this.btnSolve.Text = "Trova I Costi";
            this.btnSolve.TextColor = System.Drawing.Color.White;
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelWindowControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
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
    }
}

