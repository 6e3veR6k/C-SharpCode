using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetCommission
{
    public partial class ResultFormTable : Form
    {
        public ResultFormTable()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            minimizeButtonPanel.BackColor = Color.DarkCyan;
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButtonPanel.BackColor = System.Drawing.Color.Gray;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButtonPanel.BackColor = System.Drawing.Color.Transparent;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButtonPanel.BackColor = System.Drawing.Color.Gray;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButtonPanel.BackColor = System.Drawing.Color.Transparent;
        }


        bool togMove;
        int mouseValueX;
        int mouseValueY;
        private void ResultFormTable_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = true;
            mouseValueX = e.X;
            mouseValueY = e.Y;
        }

        private void ResultFormTable_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove)
            {
                this.SetDesktopLocation(MousePosition.X - mouseValueX, MousePosition.Y - mouseValueY);
            }
        }

        private void ResultFormTable_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = false;
        }

        public void Upload_Click(object sender, EventArgs e)
        {
            MainWindowForm.ResultsFileSave();
        }
    }
}
