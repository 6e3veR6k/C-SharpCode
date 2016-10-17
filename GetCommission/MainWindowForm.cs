using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


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
            if (CommissionTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Не вибрано тип комісійної винагороди!");
            }
            else if (ActStatusCB.SelectedIndex == -1)
            {
                MessageBox.Show("Не вибрано статус актів!");
            }
            else if (AgentChanel.SelectedIndex == -1)
            {
                MessageBox.Show("Не вибрано канал агента!");
            }
            else if (BrCBList.SelectedIndex == -1)
            {
                MessageBox.Show("Не вибрано відділення!");
            }
            else if (ActClosed.Value.Date > DateTime.Now || ActPeriod.Value.Date > ActClosed.Value.Date)
            {
                MessageBox.Show("Не вірна дата!");
            }
            else
            {
                QueryString text = new QueryString(BrCBList, CommissionTypeCB, ActStatusCB, ActPeriod, ActClosed, AgentChanel);
                SqlConnection conn = new SqlConnection("server=hq01db05;database=Callisto;Trusted_Connection=yes;Integrated Security=true");
                SqlCommand cmd = new SqlCommand(text.GetQueryString().ToString(), conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                string CommissionOut = "";
                while (reader.Read())
                {
                    string newRaw = reader[0].ToString()
                        + '\t' + reader[1].ToString()
                        + '\t' + reader[2].ToString()
                        + '\t' + reader[3].ToString()
                        + '\t' + reader[4].ToString()
                        + '\t' + reader[5].ToString()
                        + '\t' + reader[6].ToString()
                        + '\t' + reader[7].ToString()
                        + '\t' + reader[8].ToString();
                    
                    CommissionOut += (newRaw + '\n');
                }
                string path = @"d:\Documents\fromGit\C-SharpCode\result.txt";
                if (!System.IO.File.Exists(path))
                {
                    using (System.IO.StreamWriter sw = System.IO.File.CreateText(path))
                    {
                        sw.Write(CommissionOut);
                    }
                }
                MessageBox.Show(CommissionOut);
            }


        }

        //
        //
        //

    }
}
