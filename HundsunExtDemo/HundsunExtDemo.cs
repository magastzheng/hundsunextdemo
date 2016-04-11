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

        private void HundsunExtDemo_Load(object sender, EventArgs e)
        {
            InitializeCombobox();
        }

        #region combobox
        private void InitializeCombobox()
        {
            var spotBuy = ConfigManager.Instance.GetComboConfig().GetComboOption("spotbuy"); 
            SetComboBox(this.comboBoxSpotBuy, spotBuy);

            var spotSell = ConfigManager.Instance.GetComboConfig().GetComboOption("spotsell"); 
            SetComboBox(this.comboBoxSpotSell, spotSell);

            var futureBuy = ConfigManager.Instance.GetComboConfig().GetComboOption("futurebuy"); 
            SetComboBox(this.comboBoxFutureBuy, futureBuy);

            var futureSell = ConfigManager.Instance.GetComboConfig().GetComboOption("futuresell"); 
            SetComboBox(this.comboBoxFutureSell, futureSell);
        }

        private void SetComboBox(ComboBox comboBox, ComboOption comboOption)
        {
            foreach (var item in comboOption.Items)
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

            ComboOptionItem selectedItem = comboBox.SelectedItem as ComboOptionItem;
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

        private void dataGridViewBuySell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
