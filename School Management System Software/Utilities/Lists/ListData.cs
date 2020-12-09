using SMDBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System_Software.Utilities.Lists
{
   public class ListData
    {
        public static void LoadDataIntoDataGridView(DataGridView dgv, string StoredProceName)
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = db.GetDataList(StoredProceName);
            if (dgv.Name == "DuesDataGridView".ToString() || dgv.Name == "AnnualDuesDataGridView".ToString())
            {
                dgv.MultiSelect = true;
            }
            else
            {
                dgv.MultiSelect = false;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        public static void LoadDataIntoComboBox(ComboBox cb, DBParameter parameter)
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList("usp_ListTypesDataGetDataByListTypeId", parameter);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";

            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
