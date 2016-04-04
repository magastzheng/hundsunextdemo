using Model.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundsunExtDemo.UI
{
    public class HSGridView:DataGridView
    {
        private HSGrid _hsGrid = null;
        private Dictionary<string, int> _columnNameIndex = new Dictionary<string, int>();
        private List<HSGridColumn> _columns = null;

        public HSGridView(HSGrid hsGrid)
        {
            this._hsGrid = hsGrid;
            this._columns = hsGrid.Columns;
            for (int i = 0, count = _columns.Count; i < count; i++)
            {
                _columnNameIndex[_columns[i].Name] = i;
            }

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            AddColumns();

            this.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
        }

        private void AddColumns()
        { 
            DataGridViewColumn[] gridColumns = new DataGridViewColumn[_columns.Count];
            for(int i = 0, count = _columns.Count; i < count; i++)
            {
                HSGridColumn col = _columns[i];
         
                DataGridViewColumn column = null;
                switch (col.ColumnType)
                {
                    case HSGridColumnType.CheckBox:
                        {
                            column = new DataGridViewCheckBoxColumn();
                        }
                        break;
                    case HSGridColumnType.Image:
                        {
                            column = new DataGridViewColumn();
                        }
                        break;
                    case HSGridColumnType.Text:
                        {
                            column = new DataGridViewTextBoxColumn();
                        }
                        break;
                    default:
                        {
                            column = new DataGridViewTextBoxColumn();
                        }
                        break;
                }

                column.HeaderText = col.Text;
                column.Name = col.Name;
                column.Width = col.Width;

                gridColumns[i] = column;
            }

            this.Columns.AddRange(gridColumns);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv == null || e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            //int selectIndex = dgv.Columns["tc_selection"].Index;
            //DataGridViewRow row = dgv.Rows[e.RowIndex];
            //int commandNo = (int)row.Cells["tc_commandno"].Value;
            //if (e.ColumnIndex == selectIndex)
            //{
            //    bool currentStatus = (bool)row.Cells[e.ColumnIndex].EditedFormattedValue;
            //    //bool valueStatus = (bool)row.Cells[e.ColumnIndex].Value;

            //    if (currentStatus)
            //    {
            //        row.Cells[e.ColumnIndex].Value = true;
            //        SetSelectionRowBackground(dgv, e.RowIndex, true);
            //        //dgv.Rows[e.RowIndex].Selected = true;

            //        UIEntrustItem item = new UIEntrustItem
            //        {
            //            Selected = 0,
            //            CommandNo = commandNo,
            //            Copies = 0
            //        };

            //        FillEntrustGrid(new List<UIEntrustItem> { item });
            //    }
            //    else
            //    {
            //        row.Cells[e.ColumnIndex].Value = false;
            //        SetSelectionRowBackground(dgv, e.RowIndex, false);
            //        //dgv.Rows[e.RowIndex].Selected = false;
            //        RemoveEntrustGrid(commandNo);
            //    }
            //}
        }
    }
}
