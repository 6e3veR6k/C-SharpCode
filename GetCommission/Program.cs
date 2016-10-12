using System;
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

    static public class QueryBuilder
    {
        static public string GetBranchQueryPart(System.Windows.Forms.CheckedListBox CheckBoxList)
        {
            string BranchQueryPart = null;
            for (int i = 0; i < CheckBoxList.Items.Count; i++)
            {
                if (CheckBoxList.GetItemChecked(i))
                    BranchQueryPart += String.Format(" OR LEFT(B.BranchCode, 2)='{0:00}'", i + 1);
            }
            return BranchQueryPart;
        }

        static public string GetCommissionTypeGuid(string CheckedLine)
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

        static public string GetActStatusGuid(string CheckedLine)
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

    }

}
