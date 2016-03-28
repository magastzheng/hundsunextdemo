using System;
namespace HundsunExtDemo
{
    partial class hundsunExtDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hundsunExtDemo));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTradingCommand = new System.Windows.Forms.TabControl();
            this.tabPageCommandTrading = new System.Windows.Forms.TabPage();
            this.splitContainerTradingCommand = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tc_commandno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_executetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_missionnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_baisprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_buymorethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_sellmorethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_longratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_bearratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_entrustedamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_dialamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlDetailTrading = new System.Windows.Forms.TabControl();
            this.tabPageCommandSecu = new System.Windows.Forms.TabPage();
            this.tabPageEntrustFlow = new System.Windows.Forms.TabPage();
            this.tabPageDialFlow = new System.Windows.Forms.TabPage();
            this.tabPageEntrustFlowParent = new System.Windows.Forms.TabPage();
            this.tabPageDialFlowParent = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tpSplitContainer = new System.Windows.Forms.SplitContainer();
            this.buysellPanel = new System.Windows.Forms.Panel();
            this.btnEntrust = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dataGridViewBuySell = new System.Windows.Forms.DataGridView();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commandno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus = new System.Windows.Forms.DataGridViewImageColumn();
            this.comboBoxFutureSell = new System.Windows.Forms.ComboBox();
            this.comboBoxFutureBuy = new System.Windows.Forms.ComboBox();
            this.comboBoxSpotSell = new System.Windows.Forms.ComboBox();
            this.comboBoxSpotBuy = new System.Windows.Forms.ComboBox();
            this.lblFuturesSellPrice = new System.Windows.Forms.Label();
            this.lblFuturesBuyPrice = new System.Windows.Forms.Label();
            this.lblSpotSellPrice = new System.Windows.Forms.Label();
            this.lblSpotBuyPrice = new System.Windows.Forms.Label();
            this.tradingInfoPanel = new System.Windows.Forms.Panel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabTradingCommand.SuspendLayout();
            this.tabPageCommandTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTradingCommand)).BeginInit();
            this.splitContainerTradingCommand.Panel1.SuspendLayout();
            this.splitContainerTradingCommand.Panel2.SuspendLayout();
            this.splitContainerTradingCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControlDetailTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpSplitContainer)).BeginInit();
            this.tpSplitContainer.Panel2.SuspendLayout();
            this.tpSplitContainer.SuspendLayout();
            this.buysellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1000, 48);
            this.toolStripContainer1.Location = new System.Drawing.Point(2, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1000, 73);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(7, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(104, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sysToolStripMenuItem
            // 
            this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
            this.sysToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.sysToolStripMenuItem.Text = "sys";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.toolToolStripMenuItem.Text = "tool";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // tabTradingCommand
            // 
            this.tabTradingCommand.Controls.Add(this.tabPageCommandTrading);
            this.tabTradingCommand.Controls.Add(this.tabPageEntrustFlowParent);
            this.tabTradingCommand.Controls.Add(this.tabPageDialFlowParent);
            this.tabTradingCommand.Location = new System.Drawing.Point(3, 3);
            this.tabTradingCommand.Name = "tabTradingCommand";
            this.tabTradingCommand.SelectedIndex = 0;
            this.tabTradingCommand.Size = new System.Drawing.Size(698, 441);
            this.tabTradingCommand.TabIndex = 1;
            this.tabTradingCommand.Tag = "";
            // 
            // tabPageCommandTrading
            // 
            this.tabPageCommandTrading.Controls.Add(this.splitContainerTradingCommand);
            this.tabPageCommandTrading.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandTrading.Name = "tabPageCommandTrading";
            this.tabPageCommandTrading.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandTrading.Size = new System.Drawing.Size(690, 415);
            this.tabPageCommandTrading.TabIndex = 0;
            this.tabPageCommandTrading.Text = "指令交易";
            this.tabPageCommandTrading.UseVisualStyleBackColor = true;
            // 
            // splitContainerTradingCommand
            // 
            this.splitContainerTradingCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTradingCommand.Location = new System.Drawing.Point(3, 3);
            this.splitContainerTradingCommand.Name = "splitContainerTradingCommand";
            this.splitContainerTradingCommand.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTradingCommand.Panel1
            // 
            this.splitContainerTradingCommand.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainerTradingCommand.Panel2
            // 
            this.splitContainerTradingCommand.Panel2.Controls.Add(this.tabControlDetailTrading);
            this.splitContainerTradingCommand.Size = new System.Drawing.Size(684, 409);
            this.splitContainerTradingCommand.SplitterDistance = 216;
            this.splitContainerTradingCommand.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc_commandno,
            this.tc_commandtype,
            this.tc_executetype,
            this.tc_commandnum,
            this.tc_missionnum,
            this.tc_baisprice,
            this.tc_buymorethan,
            this.tc_sellmorethan,
            this.tc_longratio,
            this.tc_bearratio,
            this.tc_commandamount,
            this.tc_entrustedamount,
            this.tc_dialamount,
            this.tc_commandmoney});
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(674, 171);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.VirtualMode = true;
            // 
            // tc_commandno
            // 
            this.tc_commandno.HeaderText = "指令序号";
            this.tc_commandno.Name = "tc_commandno";
            // 
            // tc_commandtype
            // 
            this.tc_commandtype.HeaderText = "指令类型";
            this.tc_commandtype.Name = "tc_commandtype";
            // 
            // tc_executetype
            // 
            this.tc_executetype.HeaderText = "执行类型";
            this.tc_executetype.Name = "tc_executetype";
            // 
            // tc_commandnum
            // 
            this.tc_commandnum.HeaderText = "指令份数";
            this.tc_commandnum.Name = "tc_commandnum";
            // 
            // tc_missionnum
            // 
            this.tc_missionnum.HeaderText = "目标份数";
            this.tc_missionnum.Name = "tc_missionnum";
            // 
            // tc_baisprice
            // 
            this.tc_baisprice.HeaderText = "基差|价差";
            this.tc_baisprice.Name = "tc_baisprice";
            // 
            // tc_buymorethan
            // 
            this.tc_buymorethan.HeaderText = "多头委比";
            this.tc_buymorethan.Name = "tc_buymorethan";
            // 
            // tc_sellmorethan
            // 
            this.tc_sellmorethan.HeaderText = "空头委比";
            this.tc_sellmorethan.Name = "tc_sellmorethan";
            // 
            // tc_longratio
            // 
            this.tc_longratio.HeaderText = "多头成比";
            this.tc_longratio.Name = "tc_longratio";
            // 
            // tc_bearratio
            // 
            this.tc_bearratio.HeaderText = "空头成比";
            this.tc_bearratio.Name = "tc_bearratio";
            // 
            // tc_commandamount
            // 
            this.tc_commandamount.HeaderText = "指令数量";
            this.tc_commandamount.Name = "tc_commandamount";
            // 
            // tc_entrustedamount
            // 
            this.tc_entrustedamount.HeaderText = "已委托数量";
            this.tc_entrustedamount.Name = "tc_entrustedamount";
            // 
            // tc_dialamount
            // 
            this.tc_dialamount.HeaderText = "已成数量";
            this.tc_dialamount.Name = "tc_dialamount";
            // 
            // tc_commandmoney
            // 
            this.tc_commandmoney.HeaderText = "指令金额";
            this.tc_commandmoney.Name = "tc_commandmoney";
            // 
            // tabControlDetailTrading
            // 
            this.tabControlDetailTrading.Controls.Add(this.tabPageCommandSecu);
            this.tabControlDetailTrading.Controls.Add(this.tabPageEntrustFlow);
            this.tabControlDetailTrading.Controls.Add(this.tabPageDialFlow);
            this.tabControlDetailTrading.Location = new System.Drawing.Point(4, 4);
            this.tabControlDetailTrading.Name = "tabControlDetailTrading";
            this.tabControlDetailTrading.SelectedIndex = 0;
            this.tabControlDetailTrading.Size = new System.Drawing.Size(677, 182);
            this.tabControlDetailTrading.TabIndex = 0;
            // 
            // tabPageCommandSecu
            // 
            this.tabPageCommandSecu.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandSecu.Name = "tabPageCommandSecu";
            this.tabPageCommandSecu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandSecu.Size = new System.Drawing.Size(669, 156);
            this.tabPageCommandSecu.TabIndex = 0;
            this.tabPageCommandSecu.Text = "指令证券";
            this.tabPageCommandSecu.UseVisualStyleBackColor = true;
            // 
            // tabPageEntrustFlow
            // 
            this.tabPageEntrustFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntrustFlow.Name = "tabPageEntrustFlow";
            this.tabPageEntrustFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntrustFlow.Size = new System.Drawing.Size(669, 156);
            this.tabPageEntrustFlow.TabIndex = 1;
            this.tabPageEntrustFlow.Text = "委托流水";
            this.tabPageEntrustFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageDialFlow
            // 
            this.tabPageDialFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageDialFlow.Name = "tabPageDialFlow";
            this.tabPageDialFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialFlow.Size = new System.Drawing.Size(669, 156);
            this.tabPageDialFlow.TabIndex = 2;
            this.tabPageDialFlow.Text = "成交流水";
            this.tabPageDialFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageEntrustFlowParent
            // 
            this.tabPageEntrustFlowParent.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntrustFlowParent.Name = "tabPageEntrustFlowParent";
            this.tabPageEntrustFlowParent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntrustFlowParent.Size = new System.Drawing.Size(690, 415);
            this.tabPageEntrustFlowParent.TabIndex = 1;
            this.tabPageEntrustFlowParent.Text = "委托流水";
            this.tabPageEntrustFlowParent.UseVisualStyleBackColor = true;
            // 
            // tabPageDialFlowParent
            // 
            this.tabPageDialFlowParent.Location = new System.Drawing.Point(4, 22);
            this.tabPageDialFlowParent.Name = "tabPageDialFlowParent";
            this.tabPageDialFlowParent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialFlowParent.Size = new System.Drawing.Size(690, 415);
            this.tabPageDialFlowParent.TabIndex = 2;
            this.tabPageDialFlowParent.Text = "成交流水";
            this.tabPageDialFlowParent.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(2, 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabTradingCommand);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tpSplitContainer);
            this.splitContainer1.Size = new System.Drawing.Size(992, 446);
            this.splitContainer1.SplitterDistance = 705;
            this.splitContainer1.TabIndex = 2;
            // 
            // tpSplitContainer
            // 
            this.tpSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tpSplitContainer.Name = "tpSplitContainer";
            this.tpSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tpSplitContainer.Panel2
            // 
            this.tpSplitContainer.Panel2.Controls.Add(this.buysellPanel);
            this.tpSplitContainer.Panel2.Controls.Add(this.tradingInfoPanel);
            this.tpSplitContainer.Size = new System.Drawing.Size(283, 446);
            this.tpSplitContainer.SplitterDistance = 52;
            this.tpSplitContainer.TabIndex = 0;
            // 
            // buysellPanel
            // 
            this.buysellPanel.Controls.Add(this.btnEntrust);
            this.buysellPanel.Controls.Add(this.btnCalculate);
            this.buysellPanel.Controls.Add(this.dataGridViewBuySell);
            this.buysellPanel.Controls.Add(this.comboBoxFutureSell);
            this.buysellPanel.Controls.Add(this.comboBoxFutureBuy);
            this.buysellPanel.Controls.Add(this.comboBoxSpotSell);
            this.buysellPanel.Controls.Add(this.comboBoxSpotBuy);
            this.buysellPanel.Controls.Add(this.lblFuturesSellPrice);
            this.buysellPanel.Controls.Add(this.lblFuturesBuyPrice);
            this.buysellPanel.Controls.Add(this.lblSpotSellPrice);
            this.buysellPanel.Controls.Add(this.lblSpotBuyPrice);
            this.buysellPanel.Location = new System.Drawing.Point(4, 59);
            this.buysellPanel.Name = "buysellPanel";
            this.buysellPanel.Size = new System.Drawing.Size(272, 324);
            this.buysellPanel.TabIndex = 1;
            // 
            // btnEntrust
            // 
            this.btnEntrust.Location = new System.Drawing.Point(148, 287);
            this.btnEntrust.Name = "btnEntrust";
            this.btnEntrust.Size = new System.Drawing.Size(75, 23);
            this.btnEntrust.TabIndex = 11;
            this.btnEntrust.Text = "委托";
            this.btnEntrust.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 287);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuySell
            // 
            this.dataGridViewBuySell.AllowUserToAddRows = false;
            this.dataGridViewBuySell.AllowUserToDeleteRows = false;
            this.dataGridViewBuySell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuySell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuySell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selection,
            this.commandno,
            this.add,
            this.copies,
            this.minus});
            this.dataGridViewBuySell.Location = new System.Drawing.Point(6, 119);
            this.dataGridViewBuySell.Name = "dataGridViewBuySell";
            this.dataGridViewBuySell.RowTemplate.Height = 23;
            this.dataGridViewBuySell.Size = new System.Drawing.Size(263, 149);
            this.dataGridViewBuySell.TabIndex = 9;
            this.dataGridViewBuySell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuySell_CellContentClick);
            // 
            // selection
            // 
            this.selection.HeaderText = "选择";
            this.selection.Name = "selection";
            // 
            // commandno
            // 
            this.commandno.HeaderText = "指令序号";
            this.commandno.Name = "commandno";
            this.commandno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.commandno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // add
            // 
            this.add.HeaderText = "增加";
            this.add.Name = "add";
            // 
            // copies
            // 
            this.copies.HeaderText = "份数";
            this.copies.Name = "copies";
            // 
            // minus
            // 
            this.minus.HeaderText = "减少";
            this.minus.Name = "minus";
            // 
            // comboBoxFutureSell
            // 
            this.comboBoxFutureSell.FormattingEnabled = true;
            this.comboBoxFutureSell.Location = new System.Drawing.Point(102, 93);
            this.comboBoxFutureSell.Name = "comboBoxFutureSell";
            this.comboBoxFutureSell.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFutureSell.TabIndex = 8;
            this.comboBoxFutureSell.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxFutureBuy
            // 
            this.comboBoxFutureBuy.FormattingEnabled = true;
            this.comboBoxFutureBuy.Location = new System.Drawing.Point(102, 67);
            this.comboBoxFutureBuy.Name = "comboBoxFutureBuy";
            this.comboBoxFutureBuy.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFutureBuy.TabIndex = 7;
            this.comboBoxFutureBuy.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxSpotSell
            // 
            this.comboBoxSpotSell.FormattingEnabled = true;
            this.comboBoxSpotSell.Location = new System.Drawing.Point(102, 41);
            this.comboBoxSpotSell.Name = "comboBoxSpotSell";
            this.comboBoxSpotSell.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSpotSell.TabIndex = 6;
            this.comboBoxSpotSell.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxSpotBuy
            // 
            this.comboBoxSpotBuy.FormattingEnabled = true;
            this.comboBoxSpotBuy.Location = new System.Drawing.Point(102, 12);
            this.comboBoxSpotBuy.Name = "comboBoxSpotBuy";
            this.comboBoxSpotBuy.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSpotBuy.TabIndex = 5;
            this.comboBoxSpotBuy.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lblFuturesSellPrice
            // 
            this.lblFuturesSellPrice.AutoSize = true;
            this.lblFuturesSellPrice.Location = new System.Drawing.Point(4, 93);
            this.lblFuturesSellPrice.Name = "lblFuturesSellPrice";
            this.lblFuturesSellPrice.Size = new System.Drawing.Size(65, 12);
            this.lblFuturesSellPrice.TabIndex = 3;
            this.lblFuturesSellPrice.Text = "期货委卖价";
            // 
            // lblFuturesBuyPrice
            // 
            this.lblFuturesBuyPrice.AutoSize = true;
            this.lblFuturesBuyPrice.Location = new System.Drawing.Point(4, 68);
            this.lblFuturesBuyPrice.Name = "lblFuturesBuyPrice";
            this.lblFuturesBuyPrice.Size = new System.Drawing.Size(65, 12);
            this.lblFuturesBuyPrice.TabIndex = 2;
            this.lblFuturesBuyPrice.Text = "期货委买价";
            // 
            // lblSpotSellPrice
            // 
            this.lblSpotSellPrice.AutoSize = true;
            this.lblSpotSellPrice.Location = new System.Drawing.Point(4, 41);
            this.lblSpotSellPrice.Name = "lblSpotSellPrice";
            this.lblSpotSellPrice.Size = new System.Drawing.Size(65, 12);
            this.lblSpotSellPrice.TabIndex = 1;
            this.lblSpotSellPrice.Text = "现货委卖价";
            // 
            // lblSpotBuyPrice
            // 
            this.lblSpotBuyPrice.AutoSize = true;
            this.lblSpotBuyPrice.Location = new System.Drawing.Point(4, 14);
            this.lblSpotBuyPrice.Name = "lblSpotBuyPrice";
            this.lblSpotBuyPrice.Size = new System.Drawing.Size(65, 12);
            this.lblSpotBuyPrice.TabIndex = 0;
            this.lblSpotBuyPrice.Text = "现货委买价";
            // 
            // tradingInfoPanel
            // 
            this.tradingInfoPanel.Location = new System.Drawing.Point(4, 4);
            this.tradingInfoPanel.Name = "tradingInfoPanel";
            this.tradingInfoPanel.Size = new System.Drawing.Size(272, 56);
            this.tradingInfoPanel.TabIndex = 0;
            // 
            // hundsunExtDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 536);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "hundsunExtDemo";
            this.Text = "HundsunExtDemo";
            this.Load += new System.EventHandler(this.HundsunExtDemo_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabTradingCommand.ResumeLayout(false);
            this.tabPageCommandTrading.ResumeLayout(false);
            this.splitContainerTradingCommand.Panel1.ResumeLayout(false);
            this.splitContainerTradingCommand.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTradingCommand)).EndInit();
            this.splitContainerTradingCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControlDetailTrading.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tpSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpSplitContainer)).EndInit();
            this.tpSplitContainer.ResumeLayout(false);
            this.buysellPanel.ResumeLayout(false);
            this.buysellPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTradingCommand;
        private System.Windows.Forms.TabPage tabPageCommandTrading;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPageEntrustFlowParent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer tpSplitContainer;
        private System.Windows.Forms.Panel buysellPanel;
        private System.Windows.Forms.Label lblFuturesSellPrice;
        private System.Windows.Forms.Label lblFuturesBuyPrice;
        private System.Windows.Forms.Label lblSpotSellPrice;
        private System.Windows.Forms.Label lblSpotBuyPrice;
        private System.Windows.Forms.Panel tradingInfoPanel;
        private System.Windows.Forms.DataGridView dataGridViewBuySell;
        private System.Windows.Forms.ComboBox comboBoxFutureSell;
        private System.Windows.Forms.ComboBox comboBoxFutureBuy;
        private System.Windows.Forms.ComboBox comboBoxSpotSell;
        private System.Windows.Forms.ComboBox comboBoxSpotBuy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandno;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn copies;
        private System.Windows.Forms.DataGridViewImageColumn minus;
        private System.Windows.Forms.Button btnEntrust;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TabPage tabPageDialFlowParent;
        private System.Windows.Forms.SplitContainer splitContainerTradingCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_executetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_missionnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_baisprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_buymorethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_sellmorethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_longratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_bearratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_entrustedamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_dialamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandmoney;
        private System.Windows.Forms.TabControl tabControlDetailTrading;
        private System.Windows.Forms.TabPage tabPageCommandSecu;
        private System.Windows.Forms.TabPage tabPageEntrustFlow;
        private System.Windows.Forms.TabPage tabPageDialFlow;
    }
}

