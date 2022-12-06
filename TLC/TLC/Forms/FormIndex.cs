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
using System.Threading;
using System.Diagnostics;
using System.IO;
using TLC.Forms;
using System.Globalization;

namespace TLC
{
    public partial class FormIndex : Form
    {
        FormTotalCosts formTotalCosts = null;
        DataGridView DGV_B = new DataGridView();
        public FormIndex()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
                if (DGV[DGV.ColumnCount - 1, DGV.RowCount - 1].Value == null) return;
                else
                {
                    CopyPasteDGV(DGV_B, DGV);
                    btnSolve.Enabled = false;
                    btn_GenerateTblRand.Enabled = false;
                    NordOvest();
                    Thread.Sleep(200);
                    CopyPasteDGV(DGV, DGV_B);
                    DGV.Update();
                    DGV.Refresh();
                    MinimumCost();
                }
            }
            else
                MessageBox.Show("La tabella non è completa o i valori non sono supportati!", "Errore", MessageBoxButtons.OK);
        }
        public bool Check()
        {
            for (int c = 1; c < DGV.ColumnCount; ++c)
                for (int r = 0; r < DGV.RowCount; ++r)
                    if (DGV[c, r].Value == null)
                    {
                        if (c != DGV.ColumnCount && r != DGV.RowCount - 1)
                            return false;
                    }
                    else if (Int32.TryParse(DGV[c, r].Value.ToString(), out Int32 num)){ }
                    else return false;
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
            var nfi = new NumberFormatInfo { NumberDecimalSeparator = ",", NumberGroupSeparator = "." };
            int p; //production
            int n; //needs
            int c = 0; //cost
            string tC; //total Cost
            CallFormWrite("");
            CallFormWrite("---Nord Ovest---" + Environment.NewLine);
            while (DGV.ColumnCount != 2)
            {
                p = Convert.ToInt32(DGV[DGV.ColumnCount - 1, 0].Value.ToString());
                n = Convert.ToInt32(DGV[1, DGV.RowCount - 1].Value.ToString());
                DGV.CurrentCell = DGV[1, 0];
                if (n < p)
                {
                    DGV[1, DGV.RowCount - 1].Value = "0";
                    DGV[DGV.ColumnCount - 1, 0].Value = Convert.ToString(p - n);
                    c += n * Convert.ToInt32(DGV[1, 0].Value);
                    tC = c.ToString("#,##0.00", nfi);
                    CallFormWrite(n.ToString() + " * " + Convert.ToInt32(DGV[1, 0].Value) + " = " + tC + Environment.NewLine);
                }
                else
                {
                    DGV[DGV.ColumnCount - 1, 0].Value = "0";
                    DGV[1, DGV.RowCount - 1].Value = Convert.ToString(n - p);
                    c += p * Convert.ToInt32(DGV[1, 0].Value);
                    tC = c.ToString("#,##0.00", nfi);
                    CallFormWrite(n.ToString() + " * " + Convert.ToInt32(DGV[1, 0].Value) + " = " + tC + Environment.NewLine);
                }
                if (Int32.TryParse(DGV[1, DGV.RowCount - 1].Value.ToString(), out Int32 num))
                    if (num == 0)
                        DGV.Columns.RemoveAt(1);
                if (Int32.TryParse(DGV[DGV.ColumnCount - 1, 0].Value.ToString(), out Int32 num_))
                    if (num_ == 0)
                        DGV.Rows.RemoveAt(0);
                DGV.Update();
                DGV.Refresh();
            }
            tC = c.ToString("#,##0.00", nfi);
            CallFormWrite(Environment.NewLine + "Costo Totale: " + tC + Environment.NewLine);
        }
        public void MinimumCost()
        {
            var nfi = new NumberFormatInfo { NumberDecimalSeparator = ",", NumberGroupSeparator = "." };
            int p;
            int n;
            int c = 0;
            string tC;
            int minCost;
            int minCostIndexC = 0, minCostIndexR = 0;
            minCost = Convert.ToInt32(DGV[1, 0].Value);
            CallFormWrite(Environment.NewLine + "---Minimi Costi---" + Environment.NewLine);
            while (DGV.ColumnCount != 2)
            {
                
                minCost = int.MaxValue;
                for (int k = 1; k < DGV.ColumnCount - 1; ++k)
                    for (int j = 0; j < DGV.RowCount - 1; ++j)
                        if (Convert.ToInt32(DGV[k, j].Value) < minCost)
                        {
                            minCost = Convert.ToInt32(DGV[k, j].Value);
                            minCostIndexC = k;
                            minCostIndexR = j;
                        }
                        else if (Convert.ToInt32(DGV[k, j].Value) == minCost)
                        {
                            if (Convert.ToInt32(DGV[minCostIndexC, DGV.RowCount - 1].Value) < Convert.ToInt32(DGV[k, DGV.RowCount - 1].Value))
                            {
                                minCost = Convert.ToInt32(DGV[k, j].Value);
                                minCostIndexC = k;
                                minCostIndexR = j;
                            }
                        }

                p = Convert.ToInt32(DGV[DGV.ColumnCount - 1, minCostIndexR].Value.ToString());
                n = Convert.ToInt32(DGV[minCostIndexC, DGV.RowCount - 1].Value.ToString());
                if (n < p)
                {
                    DGV[minCostIndexC, DGV.RowCount - 1].Value = "0";
                    DGV[DGV.ColumnCount - 1, minCostIndexR].Value = Convert.ToString(p - n);
                    c += n * Convert.ToInt32(DGV[minCostIndexC, minCostIndexR].Value);
                    tC = c.ToString("#,##0.00", nfi);
                    CallFormWrite(n.ToString() + " * " + Convert.ToInt32(DGV[minCostIndexC, minCostIndexR].Value) + " = " + tC + Environment.NewLine);
                }
                else
                {
                    DGV[DGV.ColumnCount - 1, minCostIndexR].Value = "0";
                    DGV[minCostIndexC, DGV.RowCount - 1].Value = Convert.ToString(n - p);
                    c += p * Convert.ToInt32(DGV[minCostIndexC, minCostIndexR].Value);
                    tC = c.ToString("#,##0.00", nfi);
                    CallFormWrite(n.ToString() + " * " + Convert.ToInt32(DGV[minCostIndexC, minCostIndexR].Value) + " = " + tC + Environment.NewLine);
                }
                RemoveEmptys();
            }
            tC = c.ToString("#,##0.00", nfi);
            CallFormWrite(Environment.NewLine + "Costo Totale: " + tC + Environment.NewLine);
        }

        public void RemoveEmptys()
        {

            int c = DGV.ColumnCount;
            int r = DGV.RowCount;
            for (int n = 1; n < c - 1; ++n)
                if (Int32.TryParse(DGV[n, r - 1].Value.ToString(), out Int32 num))
                    if (num == 0)
                    {
                        DGV.Columns.RemoveAt(n);
                        c--;
                        n--;
                        DGV.Update();
                        DGV.Refresh();
                    }
            for (int n = 0; n < r; ++n)
                if (Int32.TryParse(DGV[c - 1, n].Value.ToString(), out Int32 num))
                    if (num == 0)
                    {
                        DGV.Rows.RemoveAt(n);
                        r--;
                        n--;
                        DGV.Update();
                        DGV.Refresh();
                    }
        }
        public void CallFormWrite(string data)
        {
            
            if (formTotalCosts == null)
            {
                formTotalCosts = new FormTotalCosts();
                formTotalCosts.Show();
                formTotalCosts.FormClosed += new FormClosedEventHandler(Form_Closed);
            }
            else
                formTotalCosts.Write(data);

        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            FormTotalCosts frm = (FormTotalCosts)sender;
            formTotalCosts = null;
        }
        //Generate Table
        private void btnGenerateDGV_Click(object sender, EventArgs e)
        {
            bool a = Int32.TryParse(textBoxColumns.Text, out Int32 c);
            bool b = Int32.TryParse(textBoxRows.Text, out Int32 r);
            if (a && b)
            {
                if (textBoxColumns.Text == "")
                    c = 0;
                if (textBoxRows.Text == "")
                    r = 0;
                if (c > 500)
                    MessageBox.Show("I consumatori non possono essere più di 500", "Errore!");
                else if (r > 500)
                    MessageBox.Show("I produttori non possono essere più di 500", "Errore!");
                else if (c < 2 || r < 2)
                    MessageBox.Show("I Consumatori e i Produttori devono essere minimo 2", "Errore!");
                else
                {
                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    c += 1;
                    r += 1;
                    DGV.ColumnCount = c + 1;
                    DGV.Columns[0].Name = " ";
                    DGV.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                    for (int n = 1; n < DGV.ColumnCount - 1; ++n)
                    {
                        DGV.Columns[n].Name = "Consumatore " + n;
                        DGV.Columns[n].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    DGV.Columns[c].Name = "Produzione";
                    DGV.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;
                    for (int n = 0; n < r - 1; ++n)
                        DGV.Rows.Add("Produttore " + (n + 1));
                    DGV.Rows.Add("Richiesta");
                    DGV[c, r - 1].ReadOnly = true;
                    DGV.Columns[0].ReadOnly = true;
                    DGV.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnSolve.Enabled = true;
                    btn_GenerateTblRand.Enabled = true;
                    DGV.Update();
                    DGV.Refresh();
                    CopyPasteDGV(DGV_B, DGV);
                }
            }
            else
                MessageBox.Show("I valori non sono corretti!", "Errore!");
        }

        private void CopyPasteDGV(DataGridView a /*to paste in*/, DataGridView b /*to copy from*/)
        {
            a.ColumnCount = b.ColumnCount;
            a.RowCount = b.RowCount;
            for (int n = 0; n < b.ColumnCount; ++n)
            {
                a.Columns[n].Name = b.Columns[n].Name;
                a.Columns[n].SortMode = b.Columns[n].SortMode;
                a.Columns[n].ReadOnly = b.Columns[n].ReadOnly;
                a.Columns[n].DefaultCellStyle.Font = b.Columns[n].DefaultCellStyle.Font;
            }
            for (int k = 0; k < b.ColumnCount; ++k)
                for (int j = 0; j < b.RowCount; ++j)
                {
                    a[k, j].Value = b[k, j].Value;
                    a[k, j].ReadOnly = b[k, j].ReadOnly;
                }

        }

        //Auto Generate Numbers
        private void FillTable()
        {
            int c = DGV.ColumnCount-1;
            int r = DGV.RowCount-1;
            int t = 0;
            Random rand = new Random();
            for (int n = 1; n < c; ++n)
                for (int j = 0; j < r; ++j)
                    DGV[n, j].Value = rand.Next(5, 100);
            for (int n = 1; n < c; ++n) {
                DGV[n, r].Value = rand.Next(100, r*50);
                t += Convert.ToInt32(DGV[n, r].Value);
            }
            for (int n = 0; n < r-1; ++n)
            {
                DGV[c, n].Value = rand.Next(1, t/(r-n));
                t -= Convert.ToInt32(DGV[c, n].Value);
            }
            DGV[c, r-1].Value = t;
        }


        //Move Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
                if (e.Clicks > 1)
                    pictureMaximize_Click(this.pictureMaximize, e);
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
            
        }

        //Controls
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.Sizable;
            else
                FormBorderStyle = FormBorderStyle.None;
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
        private void ChangeImage(bool a)
        {
            if (a)
            {
                pictureClose.ImageLocation = @"../../../Images/red_dot_in.png";
                pictureMaximize.ImageLocation = @"../../../Images/yellow_dot_in.png";
                pictureMinimize.ImageLocation = @"../../../Images/green_dot_in.png";
            }
            else
            {
                pictureClose.ImageLocation = @"../../../Images/red_dot.png";
                pictureMaximize.ImageLocation = @"../../../Images/yellow_dot.png";
                pictureMinimize.ImageLocation = @"../../../Images/green_dot.png";
            }
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
                tb.KeyPress += new KeyPressEventHandler(DGV_KeyPress);
        }
        private void DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        //Customize DataGridView
        private void customizeDGV()
        {
            DGV.BorderStyle = BorderStyle.None;
        }
        //Calls
        private void btn_GenerateTblRand_Click(object sender, EventArgs e)
        {
            FillTable();
        }
        private void pictureClose_MouseEnter(object sender, EventArgs e)
        {
            ChangeImage(true);
        }
        private void pictureMaximize_MouseEnter(object sender, EventArgs e)
        {
            ChangeImage(true);
        }

        private void pictureMinimize_MouseEnter(object sender, EventArgs e)
        {
            ChangeImage(true);
        }
        private void panelWindowControl_MouseEnter(object sender, EventArgs e)
        {
            ChangeImage(true);
        }

        private void panelWindowControl_MouseLeave(object sender, EventArgs e)
        {
            ChangeImage(false);
        }

        private void pictureOptions_Click(object sender, EventArgs e)
        {
            FormOptions formOptions = new FormOptions();
            formOptions.StartPosition = FormStartPosition.CenterParent;
            formOptions.ShowDialog();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(pictureBox1, "Inserdendo il numero di consumatori \n" +
                                        "e il numero di produttori, si creerà la tabella \n" +
                                        "da riempire. \n" +
                                        "La somma delle richieste e la somma \n " +
                                        "delle produzioni devono coincidere. \n" +
                                        "Trovando i costi l'interfaccia mostrerà le operazioni \n " +
                                        "che sta eseguendo per poi mostrare il \n " +
                                        "costo finale per ogni metodo utilizzato. \n " +
                                        "I metodi utilizzati saranno:\n" +
                                        "- Nord Ovest \n " +
                                        "- Minimi Costi \n");
        }
    }
}
