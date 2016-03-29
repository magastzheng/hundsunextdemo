using Config;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundsunExtDemo
{
    public partial class HundsunExtDemo2 : Form
    {
        public HundsunExtDemo2()
        {
            InitializeComponent();
        }

        private void HundsunExtDemo2_Load(object sender, EventArgs e)
        {
            var tcItems = GenerateTestCommandTrading();
            FillCommandTrading(tcItems);

            var dfItems = GenerateDealFlowData();
            FillDealFlow(dfItems);

            var eiItems = GenerateEntrustData();
            FillEntrustGrid(eiItems);


            SetDataGridVieweReadOnly(this.dataGridViewCmdTrading, new List<DataGridViewColumn> { this.tc_selection});
            SetDataGridVieweReadOnly(this.dataGridViewDealFlow, new List<DataGridViewColumn>());
            SetDataGridVieweReadOnly(this.dataGridViewBuySell, new List<DataGridViewColumn> { this.bs_selection, this.bs_copies});

            InitializeCombobox();

        }

        #region combobox
        private void InitializeCombobox()
        {
            var spotBuy = ConfigManager.Instance.GetBuySellConfig().BuySellOption.SpotBuy;
            SetComboBox(this.comboBoxSpotBuy, spotBuy);

            var spotSell = ConfigManager.Instance.GetBuySellConfig().BuySellOption.SpotSell;
            SetComboBox(this.comboBoxSpotSell, spotSell);

            var futureBuy = ConfigManager.Instance.GetBuySellConfig().BuySellOption.FutureBuy;
            SetComboBox(this.comboBoxFutureBuy, futureBuy);

            var futureSell = ConfigManager.Instance.GetBuySellConfig().BuySellOption.FutureSell;
            SetComboBox(this.comboBoxFutureSell, futureSell);
        }

        private void SetComboBox(ComboBox comboBox, List<BuySellItem> items)
        {
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }

            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
                return;

            BuySellItem selectedItem = comboBox.SelectedItem as BuySellItem;
            if (selectedItem == null)
                return;

            Console.WriteLine("Selected: " + comboBox.Name + " " + selectedItem.Id);
            switch (comboBox.Name)
            {
                case "comboBoxSpotBuy":

                    break;
                case "comboBoxSpotSell":
                    break;
                case "comboBoxFutureBuy":
                    break;
                case "comboBoxFutureSell":
                    break;
            }
            if (sender is ComboBox)
            {
                Console.WriteLine("Event: ", sender.ToString());
            }
        }
        #endregion

        #region 填充指令交易

        private List<UITradingCommandItem> GenerateTestCommandTrading()
        {
            List<UITradingCommandItem> tcItems = new List<UITradingCommandItem>();
            UITradingCommandItem item1 = new UITradingCommandItem 
            { 
                Selected = 1,
                CommandNo = 12,
                CommandType = "Test",
                ExecuteType = "Buy",
                CommandNum = 100,
                TargetNum = 150,
                BaisPrice = 0.25,
                LongMoreThan = 0.35,
                BearMoreThan = 0.25,
                LongRatio = 0.35,
                BearRatio = 0.12,
                CommandAmount = 130,
                EntrustedAmount = 120,
                CommandMoney = 154014.00,
                Exposure = 12.0,
                StartDate = "20160321",
                EndDate = "20160321",
                StartTime = "134200",
                EndTime = "134500",
                DispatchTime = "134311",
                ExecutePerson = "Magast",
                DispatchPerson = "Youyo",
                InstanceId = "1120",
                InstanceNo = "A110",
                MonitorUnit = "M10"
            };
            tcItems.Add(item1);


            return tcItems;
        }

        private void FillCommandTrading(List<UITradingCommandItem> tcItems)
        {
            foreach (var dataItem in tcItems)
            {
                int rowIndex = this.dataGridViewCmdTrading.Rows.Add();
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_selection"].Value = dataItem.Selected;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_commandno"].Value = dataItem.CommandNo;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_commandtype"].Value = dataItem.CommandType;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_executetype"].Value = dataItem.ExecuteType;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_commandnum"].Value = dataItem.CommandNum;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_targetnum"].Value = dataItem.TargetNum;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_baisprice"].Value = dataItem.BaisPrice;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_longmorethan"].Value = dataItem.LongMoreThan;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_bearmorethan"].Value = dataItem.BearMoreThan;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_longratio"].Value = dataItem.LongRatio;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_bearratio"].Value = dataItem.BearRatio;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_commandamount"].Value = dataItem.CommandAmount;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_entrustedamount"].Value = dataItem.EntrustedAmount;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_dealamount"].Value = dataItem.DealAmount;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_commandmoney"].Value = dataItem.CommandMoney;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_exposure"].Value = dataItem.Exposure;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_startdate"].Value = dataItem.StartDate;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_enddate"].Value = dataItem.EndDate;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_starttime"].Value = dataItem.StartTime;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_endtime"].Value = dataItem.EndTime;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_dispatchtime"].Value = dataItem.DispatchTime;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_executeperson"].Value = dataItem.ExecutePerson;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_dispatchperson"].Value = dataItem.DispatchPerson;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_instanceid"].Value = dataItem.InstanceId;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_instanceno"].Value = dataItem.InstanceNo;
                this.dataGridViewCmdTrading.Rows[rowIndex].Cells["tc_monitorunit"].Value = dataItem.MonitorUnit;
            }
        }

        #endregion

        #region 成交流水
        private List<UIDealFlowItem> GenerateDealFlowData()
        {
            List<UIDealFlowItem> dfItems = new List<UIDealFlowItem>();

            UIDealFlowItem item = new UIDealFlowItem 
            {
                CommandNo = 112,
                SecurityCode = "600369",
                SecurityName = "从啦",
                FundNo = "A125",
                FundName = "Fund 1",
                PortfolioCode = "P1112",
                PortfolioName = "Portfolio 1",
                PriceType = "dddd",
                EntrustPrice = 12.34,
                EntrustDirection = "Buy",
                DealPrice = 12.20,
                DealAmount = 1200,
                DealMoney = 120045.02,
                DealTime = "124545",
                ShareHolderCode = "S123456",
                DeclareNo = "1234",
                DeclareSeat = "A12345",
                EntrustBatchNo = "45678",
                InstanceId = "45789",
                InstanceNo = "Sdfads",
                EntrustNo = "45789",
                DealNo = "789"
            };

            dfItems.Add(item);
            return dfItems;
        }

        private void FillDealFlow(List<UIDealFlowItem> dfItems)
        {
            foreach (var dataItem in dfItems)
            {
                int rowIndex = this.dataGridViewDealFlow.Rows.Add();

                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_commandno"].Value = dataItem.CommandNo;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_securitycode"].Value = dataItem.SecurityCode;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_securityname"].Value = dataItem.SecurityName;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_fundno"].Value = dataItem.FundNo;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_fundname"].Value = dataItem.FundName;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_portfoliocode"].Value = dataItem.PortfolioCode;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_portfolioname"].Value = dataItem.PortfolioName;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_pricetype"].Value = dataItem.PriceType;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_entrustprice"].Value = dataItem.EntrustPrice;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_entrustdirection"].Value = dataItem.EntrustDirection;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_dealprice"].Value = dataItem.DealPrice;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_dealamount"].Value = dataItem.DealAmount;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_dealmoney"].Value = dataItem.DealMoney;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_dealtime"].Value = dataItem.DealTime;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_stockholdercode"].Value = dataItem.ShareHolderCode;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_declareno"].Value = dataItem.DeclareNo;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_declareseat"].Value = dataItem.DeclareSeat;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_entrustbatchno"].Value = dataItem.EntrustBatchNo;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_instanceid"].Value = dataItem.InstanceId;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_instanceno"].Value = dataItem.InstanceNo;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_entrustno"].Value = dataItem.EntrustNo;
                this.dataGridViewDealFlow.Rows[rowIndex].Cells["df_dealno"].Value = dataItem.DealNo;
            }
        }
        #endregion

        #region 委托

        private List<UIEntrustItem> GenerateEntrustData()
        {
            List<UIEntrustItem> eiItems = new List<UIEntrustItem>();
            UIEntrustItem item = new UIEntrustItem 
            {
                Selected = 2,
                CommandNo = 11111,
                Copies = 0
            };

            eiItems.Add(item);

            return eiItems;
        }

        private void FillEntrustGrid(List<UIEntrustItem> eiItems)
        {
            foreach (var dataItem in eiItems)
            {
                int rowIndex = this.dataGridViewBuySell.Rows.Add();

                this.dataGridViewBuySell.Rows[rowIndex].Cells["bs_selection"].Value = dataItem.Selected;
                this.dataGridViewBuySell.Rows[rowIndex].Cells["bs_commandno"].Value = dataItem.CommandNo;
                this.dataGridViewBuySell.Rows[rowIndex].Cells["bs_copies"].Value = 0;

                Image plusImg = Image.FromFile(@"img\plus.png");
                Bitmap plusBt = new Bitmap(plusImg, new Size(20, 20));
                this.dataGridViewBuySell.Rows[rowIndex].Cells["bs_add"].Value = plusBt;

                Image minusImg = Image.FromFile(@"img\minus.png");
                Bitmap minusBt = new Bitmap(minusImg, new Size(20, 20));
                this.dataGridViewBuySell.Rows[rowIndex].Cells["bs_minus"].Value = minusBt;
            }
        }

        #endregion

        #region set grid readonly

        private void SetDataGridVieweReadOnly(DataGridView dataGridView, List<DataGridViewColumn> editColumns)
        {
            foreach(DataGridViewColumn column in dataGridView.Columns)
            {
                if(!IsEditColumn(editColumns, column.Name))
                {
                    column.ReadOnly = true;
                }
            }
        }

        private bool IsEditColumn(List<DataGridViewColumn> editColumns, string columnName)
        {
            foreach (var column in editColumns)
            {
                if (column.Name == columnName)
                    return true;
            }

            return false;
        }
        #endregion

        #region entrust copies input

        private void DataGridViewBuySell_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv != null && dgv.Columns[e.ColumnIndex].Name == "bs_copies")
            {
                if (e.DesiredType == typeof(int))
                {
                    e.ParsingApplied = true;
                }
                else
                {
                    Console.WriteLine("请输入数字！");
                }
            }
        }

        private void DataGridViewBuySell_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv == null)
                return;

            if (dgv.CurrentCell.ColumnIndex == dgv.Columns["bs_copies"].Index)
            {
                DataGridViewTextBoxEditingControl dgvTxt = e.Control as DataGridViewTextBoxEditingControl;
                dgvTxt.SelectAll();
                dgvTxt.KeyPress += Cells_KeyPress;
            }
        }

        private void Cells_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e, (DataGridViewTextBoxEditingControl)sender);
        }

        private void KeyPress(KeyPressEventArgs e, DataGridViewTextBoxEditingControl dgvTxt)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                //让操作失效
                e.Handled = false;
            }
            else
            {
                Console.WriteLine("输入无效值！");
                e.Handled = true;
            }
        }
        #endregion

        #region 增减委托份数

        private void DataGridViewBuySell_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv == null)
                return;
            int copiesIndex = dgv.Columns["bs_copies"].Index;
            if (e.ColumnIndex == dgv.Columns["bs_add"].Index)
            {
                int oldValue = (int)dgv.Rows[e.RowIndex].Cells["bs_copies"].Value;
                dgv.Rows[e.RowIndex].Cells["bs_copies"].Value = oldValue + 1;
            }
            else if (e.ColumnIndex == dgv.Columns["bs_minus"].Index)
            {
                int oldValue = (int)dgv.Rows[e.RowIndex].Cells["bs_copies"].Value;
                if (oldValue > 0)
                {
                    dgv.Rows[e.RowIndex].Cells["bs_copies"].Value = oldValue - 1;
                }
            }
            else
            { 
                //do nothing
            }
        }

        #endregion
    }
}
