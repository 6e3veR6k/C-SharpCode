using System;
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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void minimizeButtonPanel_MouseHover(object sender, EventArgs e)
        {
            minimizeButtonPanel.BackColor = System.Drawing.Color.Gray;
        }

        private void minimizeButtonPanel_MouseLeave(object sender, EventArgs e)
        {
            minimizeButtonPanel.BackColor = System.Drawing.Color.Transparent;
        }

        private void closeButtonPanel_MouseHover(object sender, EventArgs e)
        {
            closeButtonPanel.BackColor = System.Drawing.Color.Gray;
        }

        private void closeButtonPanel_MouseLeave(object sender, EventArgs e)
        {
            closeButtonPanel.BackColor = System.Drawing.Color.Transparent;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeButtonPanel.BackColor = Color.DarkCyan;
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeButtonPanel_Click(object sender, EventArgs e)
        {
            minimizeButtonPanel.BackColor = Color.DarkCyan;
            this.WindowState = FormWindowState.Minimized;
        }

        //
        // Moving window form
        //
        bool togMove;
        int mouseValueX;
        int mouseValueY;

        private void MainWindowForm_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = true;
            mouseValueX = e.X;
            mouseValueY = e.Y;

        }

        private void MainWindowForm_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = false; 
        }

        private void MainWindowForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove)
            {
                this.SetDesktopLocation(MousePosition.X - mouseValueX, MousePosition.Y - mouseValueY);
            }
        }
        //
        // Create fromated string for query
        //
        private void QueryStart_Click(object sender, EventArgs e)
        {

            string BranchQueryPart = GetCommission.QueryBuilder.GetBranchQueryPart(BrCBList);
            string t = AgentChanel.GetItemText(AgentChanel.SelectedItem);
            string ChanelQueryPart = new String(t.ToCharArray(0, 2));


            string formatedText = String.Format("@CommissionTypeGID - '{0}'\n@Period - '{1}'\n@StartDate - '{2}'\n@EndDate - '{3}'\n@StatusGID - '{4}'\n@Chanel - '{5}'\n@BranchCode: (LEFT(B.BranchCode, 2) = '100' {6})", 
                0,
                1,
                2,
                3,
                4,
                ChanelQueryPart,
                BranchQueryPart
                );
            MessageBox.Show(formatedText);
        }


        //
        //
        //

    }
}
