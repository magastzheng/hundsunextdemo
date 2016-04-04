using Model.Data;
using Model.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundsunExtDemo.UI
{
    public class HSGridView: DataGridView
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

        public void FillData(DataSet dataSet)
        {
            if (dataSet == null || dataSet.Rows == null)
                return;

            for(int r = 0, count = dataSet.Rows.Count; r < count; r++)
            {
                DataRow dataRow = dataSet.Rows[r];

                int rowIndex = this.Rows.Add();
                DataGridViewRow row = this.Rows[rowIndex];

                foreach(HSGridColumn col in _columns)
                {

                    switch(col.ValueType)
                    {
                        case DataValueType.Int:
                            break;
                        case DataValueType.Float:
                            break;
                        case DataValueType.String:
                            break;
                        default:
                            break;
                    }
                    //row.Cells[col.Name].Value = ;
                }
            }
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
            int cbColIndex = GetCheckBoxColumnIndex();
            if (cbColIndex < 0)
                return;
            DataGridViewRow row = dgv.Rows[e.RowIndex];

            if (e.ColumnIndex == cbColIndex)
            {
                bool currentStatus = (bool)row.Cells[e.ColumnIndex].EditedFormattedValue;
               
                if (currentStatus)
                {
                    row.Cells[e.ColumnIndex].Value = true;
                    SetSelectionRowBackground(e.RowIndex, true);
                    
                    //pass the selected row to entrusted
                    //UIEntrustItem item = new UIEntrustItem
                    //{
                    //    Selected = 0,
                    //    CommandNo = commandNo,
                    //    Copies = 0
                    //};

                    //FillEntrustGrid(new List<UIEntrustItem> { item });
                }
                else
                {
                    row.Cells[e.ColumnIndex].Value = false;
                    SetSelectionRowBackground(e.RowIndex, false);
                    
                    //remove the uncheck rows
                    //RemoveEntrustGrid(commandNo);
                }
            }
        }

        private int GetCheckBoxColumnIndex()
        {
            int index = -1;
            for (int i = 0, count = this.Columns.Count; i < count; i++)
            {
                DataGridViewColumn column = this.Columns[i];
                if (column is DataGridViewCheckBoxColumn)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private DataSet GetSelectionRows()
        {
            DataSet dataSet = new DataSet();
            dataSet.Rows = new List<DataRow>();

            int cbColIndex = GetCheckBoxColumnIndex();
            if (cbColIndex < 0)
                return dataSet;

            int validCount = this._columns.Count - 1;
            foreach (DataGridViewRow row in this.Rows)
            {
                bool isChecked = (bool)row.Cells[cbColIndex].EditedFormattedValue;
                if (!isChecked)
                    continue;

                DataRow dataRow = new DataRow();
                dataRow.Columns = new Dictionary<string, DataValue>();
                for (int i = 0; i < validCount; i++)
                {
                    HSGridColumn column = this._columns[i];

                    DataValue dataValue = new DataValue();
                    dataValue.Type = column.ValueType;
                    if (i == cbColIndex)
                    {
                        dataValue.Value = 1;
                    }
                    else
                    {
                        dataValue.Value = row.Cells[i].Value;
                    }
                    dataRow.Columns[column.Name] = dataValue;
                }

                dataSet.Rows.Add(dataRow);
            }

            return dataSet;
        }

        #region common operation of controls

        private void SetSelectionRowBackground(int rowIndex, bool isSelected)
        {
            if (isSelected)
            {
                this.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Blue;
            }
            else
            {
                this.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        #endregion
    }
}
