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
    public partial class WarnForm : Form
    {
        private delegate void OnUpdateText(string text);
        public WarnForm()
        {
            InitializeComponent();
        }

        #region

        public void UpdateText(string text)
        {
            BeginInvoke(new OnUpdateText(UpdateRichTextBox), text);
            //UpdateRichTextBox(text);
        }

        private void UpdateRichTextBox(string message)
        {
            this.rtBoxMessage.Text = message;
        }
        #endregion

        #region event handle
        private void ButtonConfirm_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
