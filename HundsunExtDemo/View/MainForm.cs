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

namespace HundsunExtDemo.View
{
    public partial class MainForm : Form
    {
        public MainForm(GridConfig gridConfig)
        {
            _gridConfig = gridConfig;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControl();
            //SetData();
        }

        private void InitializeControl()
        {
            //SetDataGridVieweReadOnly(this.dataGridViewCmdTrading, new List<DataGridViewColumn> { this.tc_selection });
            //SetDataGridVieweReadOnly(this.dataGridViewDealFlow, new List<DataGridViewColumn>());
            //SetDataGridVieweReadOnly(this.dataGridViewBuySell, new List<DataGridViewColumn> { this.bs_selection, this.bs_copies });

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
    }
}
