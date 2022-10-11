using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            customizeDGV();
        }

        //Resolution Methods
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                CalculateTotal();
                if (DGV[DGV.ColumnCount - 1, DGV.RowCount - 1].Value == null)
                    return;
                else
                {
                    NordOvest();
                    MinimumCost();
                }
            }
            else
            {
                MessageBox.Show("La tabella non è completa!", "Errore", MessageBoxButtons.OK);
            }
        }
        public bool Check()
        {
            for (int c = 0; c < DGV.ColumnCount; ++c)
            {
                for (int r = 0; r < DGV.RowCount; ++r)
                {
                    if (DGV[c, r].Value == null)
                    {
                        if (c != DGV.ColumnCount && r != DGV.RowCount - 1)
                            return false;
                    }
                }
            }
            return true;
        }
        public void CalculateTotal()
        {
            int sumC = 0, sumR = 0;
            for (int c = 1; c < DGV.ColumnCount; ++c)
                if (c != DGV.ColumnCount)
                    sumC += Convert.ToInt32(DGV[c, DGV.RowCount-1].Value);
            for (int r = 0; r < DGV.RowCount; ++r)
                if (r != DGV.RowCount)
                    sumR += Convert.ToInt32(DGV[DGV.ColumnCount-1, r].Value);
            if (sumC == sumR)
                DGV[DGV.ColumnCount-1, DGV.RowCount-1].Value = sumC;
            else
                MessageBox.Show("Il totale dei prodotti richiesti non coincide con il totale dei prodotti disponibili!", "Errore", MessageBoxButtons.OK);
        }
        public void NordOvest()
        {

        }
        public void MinimumCost()
        {

        }

        //Generate Table
        private void btnGenerateDGV_Click(object sender, EventArgs e)
        {
            if(textBoxColumns.Text != "" && textBoxRows.Text != "" && textBoxColumns.Text != "1" && textBoxRows.Text != "1")
            {
                DGV.DataSource = null;
                DGV.Rows.Clear();
                int c = Convert.ToInt32(textBoxColumns.Text) + 1;
                int r = Convert.ToInt32(textBoxRows.Text) + 1;
                DGV.ColumnCount = c+1;
                DGV.Columns[0].Name = " ";
                for(int n = 1; n<DGV.ColumnCount-1; ++n)
                {
                    DGV.Columns[n].Name = "Consumatore " + n;
                    DGV.Columns[n].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                DGV.Columns[c].Name = "Produzione";
                DGV.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;
                for(int n = 0; n < r-1; ++n)
                {
                    DGV.Rows.Add("Produttore " + (n+1));
                }
                DGV.Rows.Add("Richiesta");
                DGV[c, r-1].ReadOnly = true;
                DGV.Columns[0].ReadOnly = true;
                DGV.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
            else
            {
                MessageBox.Show("I Consumatori e i Produttori devono essere minimo 2", "Errore!");
            }
        }

        //Move Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
            }
        }


        //Controls
        private void panelWindowControl_MouseEnter(object sender, EventArgs e)
        {
            pictureClose.ImageLocation = @"../../../Images/red_dot_in.png";
            pictureMaximize.ImageLocation = @"../../../Images/yellow_dot_in.png";
            pictureMinimize.ImageLocation = @"../../../Images/green_dot_in.png";
        }

        private void panelWindowControl_MouseLeave(object sender, EventArgs e)
        {
            pictureClose.ImageLocation = @"../../../Images/red_dot.png";
            pictureMaximize.ImageLocation = @"../../../Images/yellow_dot.png";
            pictureMinimize.ImageLocation = @"../../../Images/green_dot.png";
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
                
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureClose_MouseEnter(object sender, EventArgs e)
        {
            pictureClose.ImageLocation = @"../../../Images/red_dot_in.png";
            pictureMaximize.ImageLocation = @"../../../Images/yellow_dot_in.png";
            pictureMinimize.ImageLocation = @"../../../Images/green_dot_in.png";
        }

        private void pictureMaximize_MouseEnter(object sender, EventArgs e)
        {
            pictureClose.ImageLocation = @"../../../Images/red_dot_in.png";
            pictureMaximize.ImageLocation = @"../../../Images/yellow_dot_in.png";
            pictureMinimize.ImageLocation = @"../../../Images/green_dot_in.png";
        }

        private void pictureMinimize_MouseEnter(object sender, EventArgs e)
        {
            pictureClose.ImageLocation = @"../../../Images/red_dot_in.png";
            pictureMaximize.ImageLocation = @"../../../Images/yellow_dot_in.png";
            pictureMinimize.ImageLocation = @"../../../Images/green_dot_in.png";
        }
        //Block Letters 
        private void textBoxColumns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)13)
                btnGenerateDGV.PerformClick();
        }

        private void textBoxRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)13)
                btnGenerateDGV.PerformClick();
        }

        private void DGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(DGV_KeyPress);
            TextBox tb = e.Control as TextBox;
            tb.ShortcutsEnabled = false;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(DGV_KeyPress);
            }
        }
        private void DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Customize DataGridView
        private void customizeDGV()
        {
            DGV.BorderStyle = BorderStyle.None;
        }

        
    }
}
