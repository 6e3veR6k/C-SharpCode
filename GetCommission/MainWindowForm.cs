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
using System.Data.SqlClient;
using System.Collections;



namespace GetCommission
{
    public partial class MainWindowForm : Form
    {



        public static DataSet ResultsTable = new DataSet();
        public static string FileName = "";
        public static string ActMonth = "";
        public static int count = 0;




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
            else if (ActClosed.Value.Date > DateTime.Now || ActPeriod.Value.Month > ActClosed.Value.Month)
            {
                MessageBox.Show("Не вірна дата!");
            }
            else
            {
                count++;
                ActMonth = "";
                FileName = "";
                ResultsTable.Clear();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();

                if (ActClosed.Value.Date == DateTime.Now.Date)
                {
                    QueryString text = new QueryString(BrCBList, CommissionTypeCB, ActStatusCB, ActPeriod, ActClosed, AgentChanel);
                    SqlConnection conn = new SqlConnection("server=hq01sdb3;database=Callisto;Trusted_Connection=yes;Integrated Security=true");
                    SQLAdapter = new SqlDataAdapter(text.GetQueryStringToday().ToString(), conn);

                }
                else
                {
                    QueryString text = new QueryString(BrCBList, CommissionTypeCB, ActStatusCB, ActPeriod, ActClosed, AgentChanel);
                    SqlConnection conn = new SqlConnection("server=hq01db05;database=Callisto;Trusted_Connection=yes;Integrated Security=true");
                    SQLAdapter = new SqlDataAdapter(text.GetQueryString().ToString(), conn);
                }
                //SqlCommandBuilder QueryBuilder = new SqlCommandBuilder(SQLAdapter);

                ResultFormTable Result = new ResultFormTable();
                SQLAdapter.Fill(ResultsTable, "AgentsCommission");

                DataTable resultTable = ResultsTable.Tables["AgentsCommission"];

                var query =
                        from Agentline in resultTable.AsEnumerable()
                        group Agentline by Agentline.Field<Int32>(resultTable.Columns[8].ColumnName) into g

                        select new
                        {
                            Id = g.Key,
                            Av = g.Sum(row => row.Field<decimal>(resultTable.Columns[4].ColumnName)),
                            AgentName = g.Max(row => row.Field<string>(resultTable.Columns[1].ColumnName)),
                            AgentINN = g.Max(row => row.Field<string>(resultTable.Columns[0].ColumnName)),
                            DogType = g.Max(row => row.Field<string>(resultTable.Columns[7].ColumnName)),
                            DirCode = g.Max(row => row.Field<string>(resultTable.Columns[5].ColumnName))
                        };

                DataTable resultAvTable = new DataTable();

                resultAvTable.Columns.Add("Дирекція", typeof(string));
                resultAvTable.Columns.Add("Номер акту", typeof(string));
                resultAvTable.Columns.Add("Агент", typeof(string));
                resultAvTable.Columns.Add("ІПН", typeof(string));
                resultAvTable.Columns.Add("Тип договору", typeof(string));
                resultAvTable.Columns.Add("Сума винагороди по акту", typeof(decimal));

                string ChannelPartString = "";
                string channelId = this.AgentChanel.GetItemText(this.AgentChanel.SelectedItem);
                string ChanelQueryPart = new String(channelId.ToCharArray(0, 2));
                if (ChanelQueryPart == "18" || ChanelQueryPart == "22")
                {
                    ChannelPartString = "СПД_";
                }
                else
                {
                    ChannelPartString = ChanelQueryPart;
                }
                List<string> BranchList = new List<string>();

                foreach (var row in query)
                {
                    DataRow workRow = resultAvTable.NewRow();
                    workRow["Дирекція"] = row.DirCode.Substring(0, 2);
                    workRow["Номер акту"] = row.Id;
                    workRow["Сума винагороди по акту"] = row.Av;
                    workRow["Агент"] = row.AgentName;
                    workRow["ІПН"] = row.AgentINN;
                    workRow["Тип договору"] = row.DogType;
                    resultAvTable.Rows.Add(workRow);

                    string AgentFullName = row.AgentName;
                    FileName += (AgentFullName.Split(' ')[0] + '_');
                    BranchList.Add(row.DirCode.Substring(0, 2));
                }
                List<String> uniqueCodes = BranchList.GroupBy(x => x).Where(g => g.Count() >= 1).Select(g => g.Key).ToList();
                if (FileName.Length >= 150)
                {
                    FileName = String.Format("part{0:00}_", count);
                }
                if (QueryString.GetCommissionTypeGuid(CommissionTypeCB.GetItemText(CommissionTypeCB.SelectedItem)) == "BEDED8D6-159C-4DEC-869C-25416FCAD1FF")
                {
                    FileName += (ChannelPartString + "ІКП_" + string.Join("_", uniqueCodes));
                }
                else
                {
                    if (ChanelQueryPart == "18" || ChanelQueryPart == "22")
                    { FileName += (ChannelPartString + string.Join("_", uniqueCodes)); }
                    else
                    { FileName += (ChannelPartString + "к" + "_" + string.Join("_", uniqueCodes)); }
                }
                if (ActPeriod.Value.Month == DateTime.Now.Month)
                {
                    FileName += "дир_дострокова";
                }
                else
                {
                    FileName += "дир";
                }
                FileName += DateTime.Now.Date.ToString(@"_(dd.MM.yyyy)");
                Result.SummInfo.DataSource = resultAvTable;
                ActMonth = ActPeriod.Value.Month.ToString();
                Result.Show();
            }
        }

        public static void ResultsFileSave()
        {
            string path = Directory.GetCurrentDirectory();
            path += String.Format(@"\{0:00}", Int32.Parse(ActMonth));
            try
            {
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }


            path += ("\\" + FileName.ToString() + ".txt");
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (DataRow item in ResultsTable.Tables[0].Rows)
                {
                    sw.WriteLine(String.Join("\t", item.ItemArray));
                }
            }
            MessageBox.Show(FileName.ToString());
        }
    }
}
