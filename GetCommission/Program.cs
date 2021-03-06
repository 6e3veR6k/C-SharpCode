﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetCommission
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowForm());
        }

    }

    public class QueryString
    {
        CheckedListBox BranchList;
        ComboBox CommissionType;
        ComboBox ActStatus;
        DateTimePicker DatePeriod;
        DateTimePicker DateClosed;
        ComboBox AgentChanel;

        public QueryString(CheckedListBox BranchList, ComboBox CommissionType, ComboBox ActStatus, DateTimePicker DatePeriod, DateTimePicker DateClosed, ComboBox AgentChanel)
        {
            this.BranchList = BranchList;
            this.CommissionType = CommissionType;
            this.ActStatus = ActStatus;
            this.DatePeriod = DatePeriod;
            this.DateClosed = DateClosed;
            this.AgentChanel = AgentChanel;
        }

        private string GetBranchQueryPart(System.Windows.Forms.CheckedListBox CheckBoxList)
        {
            string BranchQueryPart = null;
            for (int i = 0; i < CheckBoxList.Items.Count; i++)
            {
                if (CheckBoxList.GetItemChecked(i))
                    BranchQueryPart += String.Format(" OR LEFT(B.BranchCode, 2)='{0:00}'", i + 1);
            }
            return BranchQueryPart;
        }

        private string GetBranchQueryPartToday(System.Windows.Forms.CheckedListBox CheckBoxList)
        {
            string BranchQueryPart = null;
            for (int i = 0; i < CheckBoxList.Items.Count; i++)
            {
                if (CheckBoxList.GetItemChecked(i))
                    BranchQueryPart += String.Format(" OR LEFT(B.BranchCode, 2)=''{0:00}''", i + 1);
            }
            return BranchQueryPart;
        }

        public static string GetCommissionTypeGuid(string CheckedLine)
        {
            //    1: ('BEDED8D6-159C-4DEC-869C-25416FCAD1FF', "ІКП"),
            //    2: ('8CC6A11E-9E88-48A3-9C8C-3F3EC92E16AD', "Агент"),
            //    3: ('307AE0E6-5D38-42B8-A576-6C9619837AF9', "Автор угоди")
            switch (CheckedLine)
            {
                case "АВ за надання ІКП":
                    return "BEDED8D6-159C-4DEC-869C-25416FCAD1FF";
                case "Агентська винагорода":
                    return "8CC6A11E-9E88-48A3-9C8C-3F3EC92E16AD";
                case "Автор угоди":
                    return "307AE0E6-5D38-42B8-A576-6C9619837AF9";
                default:
                    return "8CC6A11E-9E88-48A3-9C8C-3F3EC92E16AD";
            }

        }

        private string GetActStatusGuid(string CheckedLine)
        {
            //  1: ("22C7D1EF-CFCF-4F37-8959-003C6669830A", "Затверджений"),
            //  2: ("6A328C2F-E582-4334-A6EA-57A1CE6E4D0F", "На узгодженні"),
            //  3: ("52AE0988-A1AA-4DDD-AF55-E10B7A067EEB", "Новий"),
            //  4: ("8E8AD750-E856-4CB6-B788-F9C0A8321EF9", "Сторно")
            switch (CheckedLine)
            {
                case "Затверджений": return "22C7D1EF-CFCF-4F37-8959-003C6669830A";
                case "На узгодженні": return "6A328C2F-E582-4334-A6EA-57A1CE6E4D0F";
                case "Новий": return "52AE0988-A1AA-4DDD-AF55-E10B7A067EEB";
                case "Сторно": return "8E8AD750-E856-4CB6-B788-F9C0A8321EF9";
                default: return "22C7D1EF-CFCF-4F37-8959-003C6669830A";
            }
        }


        public string GetQueryString()
        {
            string rawText = System.IO.File.ReadAllText(@"d:\Documents\fromGit\C-SharpCode\sql_query_commission_4 - копия.txt");
            //string rawText = "@CommissionTypeGID - '{0}'\n@Period - '{1}'\n@StartDate - '{2}'\n@EndDate - '{3}'\n@StatusGID - '{4}'\n@Chanel - '{5}'\n@BranchCode: (LEFT(B.BranchCode, 2) = '100' {6})";
            string BranchQueryPart = this.GetBranchQueryPart(BranchList);
            string channelId = this.AgentChanel.GetItemText(this.AgentChanel.SelectedItem);
            string ChanelQueryPart = new String(channelId.ToCharArray(0, 2));

            string CommissiontypeGuid = CommissionType.GetItemText(CommissionType.SelectedItem);
            string ActStatusText = ActStatus.GetItemText(ActStatus.SelectedItem);
            DateTime ActPeriodDate = new DateTime(DatePeriod.Value.Year, DatePeriod.Value.Month, 01);


            string formatedText = String.Format(rawText,
                GetCommissionTypeGuid(CommissiontypeGuid),
                ActPeriodDate.ToString("MM.dd.yyyy"),
                DateClosed.Value.ToString("MM.dd.yyyy 00:00"),
                DateTime.Now.ToString("MM.dd.yyyy H:mm"),
                GetActStatusGuid(ActStatusText),
                ChanelQueryPart,
                BranchQueryPart
                );
            return formatedText;
        }

        public string GetQueryStringToday()
        {
            string rawText = System.IO.File.ReadAllText(@"d:\Documents\fromGit\C-SharpCode\sql_query_commission_5.txt");
            //string rawText = "@CommissionTypeGID - '{0}'\n@Period - '{1}'\n@StartDate - '{2}'\n@EndDate - '{3}'\n@StatusGID - '{4}'\n@Chanel - '{5}'\n@BranchCode: (LEFT(B.BranchCode, 2) = '100' {6})";
            string BranchQueryPart = this.GetBranchQueryPartToday(BranchList);
            string channelId = this.AgentChanel.GetItemText(this.AgentChanel.SelectedItem);
            string ChanelQueryPart = new String(channelId.ToCharArray(0, 2));

            string CommissiontypeGuid = CommissionType.GetItemText(CommissionType.SelectedItem);
            string ActStatusText = ActStatus.GetItemText(ActStatus.SelectedItem);
            DateTime ActPeriodDate = new DateTime(DatePeriod.Value.Year, DatePeriod.Value.Month, 01);


            string formatedText = String.Format(rawText,
                GetCommissionTypeGuid(CommissiontypeGuid),
                ActPeriodDate.ToString("MM.dd.yyyy"),
                DateClosed.Value.ToString("MM.dd.yyyy 00:00"),
                DateTime.Now.ToString("MM.dd.yyyy H:mm"),
                GetActStatusGuid(ActStatusText),
                ChanelQueryPart,
                BranchQueryPart
                );
            return formatedText;
        }

    }

}
