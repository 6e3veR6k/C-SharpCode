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

    }

}
