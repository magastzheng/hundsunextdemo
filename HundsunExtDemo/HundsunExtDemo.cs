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
    public partial class hundsunExtDemo : Form
    {
        public hundsunExtDemo()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
    }
}
