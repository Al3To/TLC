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

        
    }
}
