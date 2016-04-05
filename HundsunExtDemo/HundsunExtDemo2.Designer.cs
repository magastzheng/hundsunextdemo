using Config;
using Controls;
using Model.UI;
using System;
namespace HundsunExtDemo
{
    partial class HundsunExtDemo2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GridConfig _gridConfig = null;
        private const string GridCMDTrading = "cmdtrading";
        private const string GridDealFlow = "dealflow";
        private const string GridCMDSecurity = "cmdsecurity";
        private const string GridBuySell = "buysell";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HundsunExtDemo2));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tabTradingCommand = new System.Windows.Forms.TabControl();
            this.tabPageCommandTrading = new System.Windows.Forms.TabPage();
            this.splitContainerTradingCommand = new System.Windows.Forms.SplitContainer();
            this.tabControlDetailTrading = new System.Windows.Forms.TabControl();
            this.tabPageCommandSecu = new System.Windows.Forms.TabPage();
            this.tabPageEntrustFlow = new System.Windows.Forms.TabPage();
            this.tabPageDialFlow = new System.Windows.Forms.TabPage();
            this.tabPageEntrustFlowParent = new System.Windows.Forms.TabPage();
            this.tabPageDialFlowParent = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelDealFlow = new System.Windows.Forms.TableLayoutPanel();
            
            this.splitContainerMarket = new System.Windows.Forms.SplitContainer();
            this.splitContainerTrading = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelTrading = new System.Windows.Forms.TableLayoutPanel();
            this.panelEntrust = new System.Windows.Forms.Panel();
            this.btnEntrusting = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            
            //this.dataGridViewBuySell = new System.Windows.Forms.DataGridView();
            this.buysellPanel = new System.Windows.Forms.Panel();
            this.btnEntrust = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.comboBoxFutureSell = new System.Windows.Forms.ComboBox();
            this.comboBoxFutureBuy = new System.Windows.Forms.ComboBox();
            this.comboBoxSpotSell = new System.Windows.Forms.ComboBox();
            this.comboBoxSpotBuy = new System.Windows.Forms.ComboBox();
            this.lblFuturesSellPrice = new System.Windows.Forms.Label();
            this.lblFuturesBuyPrice = new System.Windows.Forms.Label();
            this.lblSpotSellPrice = new System.Windows.Forms.Label();
            this.lblSpotBuyPrice = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusLabelOrg = new System.Windows.Forms.ToolStripStatusLabel();

            this.dataGridViewCmdTrading = new HSGridView(_gridConfig.GetGid(GridCMDTrading));
            this.dataGridViewCmdSecurity = new HSGridView(_gridConfig.GetGid(GridCMDSecurity));
            this.dataGridViewDealFlow = new HSGridView(_gridConfig.GetGid(GridDealFlow));
            this.dataGridViewBuySell = new HSGridView(_gridConfig.GetGid(GridBuySell));
            
            this.tableLayoutPanelMain.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabTradingCommand.SuspendLayout();
            this.tabPageCommandTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTradingCommand)).BeginInit();
            this.splitContainerTradingCommand.Panel1.SuspendLayout();
            this.splitContainerTradingCommand.Panel2.SuspendLayout();
            this.splitContainerTradingCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdTrading)).BeginInit();
            this.tabControlDetailTrading.SuspendLayout();
            this.tabPageCommandSecu.SuspendLayout();
            this.tabPageDialFlowParent.SuspendLayout();
            this.tableLayoutPanelDealFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMarket)).BeginInit();
            this.splitContainerMarket.Panel2.SuspendLayout();
            this.splitContainerMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTrading)).BeginInit();
            this.splitContainerTrading.Panel2.SuspendLayout();
            this.splitContainerTrading.SuspendLayout();
            this.tableLayoutPanelTrading.SuspendLayout();
            this.panelEntrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).BeginInit();
            this.buysellPanel.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.toolStrip, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.splitContainerMain, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.statusStripMain, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1039, 549);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(0, 27);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1039, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1039, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sysToolStripMenuItem
            // 
            this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
            this.sysToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.sysToolStripMenuItem.Text = "系统";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.viewToolStripMenuItem.Text = "视图";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.toolToolStripMenuItem.Text = "工具";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 57);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tabTradingCommand);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerMarket);
            this.splitContainerMain.Size = new System.Drawing.Size(1033, 460);
            this.splitContainerMain.SplitterDistance = 773;
            this.splitContainerMain.TabIndex = 3;
            // 
            // tabTradingCommand
            // 
            this.tabTradingCommand.Controls.Add(this.tabPageCommandTrading);
            this.tabTradingCommand.Controls.Add(this.tabPageEntrustFlowParent);
            this.tabTradingCommand.Controls.Add(this.tabPageDialFlowParent);
            this.tabTradingCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTradingCommand.Location = new System.Drawing.Point(0, 0);
            this.tabTradingCommand.Name = "tabTradingCommand";
            this.tabTradingCommand.SelectedIndex = 0;
            this.tabTradingCommand.Size = new System.Drawing.Size(769, 456);
            this.tabTradingCommand.TabIndex = 2;
            this.tabTradingCommand.Tag = "";
            this.tabTradingCommand.SelectedIndexChanged += new System.EventHandler(this.TabControlTradingCommand_SelectedIndexChanged);
            // 
            // tabPageCommandTrading
            // 
            this.tabPageCommandTrading.Controls.Add(this.splitContainerTradingCommand);
            this.tabPageCommandTrading.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandTrading.Name = "tabPageCommandTrading";
            this.tabPageCommandTrading.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandTrading.Size = new System.Drawing.Size(761, 430);
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
            this.splitContainerTradingCommand.Panel1.Controls.Add(this.dataGridViewCmdTrading);
            // 
            // splitContainerTradingCommand.Panel2
            // 
            this.splitContainerTradingCommand.Panel2.Controls.Add(this.tabControlDetailTrading);
            this.splitContainerTradingCommand.Size = new System.Drawing.Size(755, 424);
            this.splitContainerTradingCommand.SplitterDistance = 222;
            this.splitContainerTradingCommand.TabIndex = 1;
            // 
            // dataGridViewCmdTrading
            // 
            this.dataGridViewCmdTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCmdTrading.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCmdTrading.Name = "dataGridViewCmdTrading";
            this.dataGridViewCmdTrading.RowTemplate.Height = 23;
            this.dataGridViewCmdTrading.Size = new System.Drawing.Size(755, 222);
            this.dataGridViewCmdTrading.TabIndex = 0;
            this.dataGridViewCmdTrading.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCmdTrading_CellClick);
            this.dataGridViewCmdTrading.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCmdTrading_CellContentClick);
            // 
            // tabControlDetailTrading
            // 
            this.tabControlDetailTrading.Controls.Add(this.tabPageCommandSecu);
            this.tabControlDetailTrading.Controls.Add(this.tabPageEntrustFlow);
            this.tabControlDetailTrading.Controls.Add(this.tabPageDialFlow);
            this.tabControlDetailTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetailTrading.Location = new System.Drawing.Point(0, 0);
            this.tabControlDetailTrading.Name = "tabControlDetailTrading";
            this.tabControlDetailTrading.SelectedIndex = 0;
            this.tabControlDetailTrading.Size = new System.Drawing.Size(755, 198);
            this.tabControlDetailTrading.TabIndex = 0;
            this.tabControlDetailTrading.SelectedIndexChanged += new System.EventHandler(this.TabControlDetailTrading_SelectedIndexChanged);
            // 
            // tabPageCommandSecu
            // 
            this.tabPageCommandSecu.Controls.Add(this.dataGridViewCmdSecurity);
            this.tabPageCommandSecu.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandSecu.Name = "tabPageCommandSecu";
            this.tabPageCommandSecu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandSecu.Size = new System.Drawing.Size(747, 172);
            this.tabPageCommandSecu.TabIndex = 0;
            this.tabPageCommandSecu.Text = "指令证券";
            this.tabPageCommandSecu.UseVisualStyleBackColor = true;
            // 
            // tabPageEntrustFlow
            // 
            this.tabPageEntrustFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntrustFlow.Name = "tabPageEntrustFlow";
            this.tabPageEntrustFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntrustFlow.Size = new System.Drawing.Size(747, 172);
            this.tabPageEntrustFlow.TabIndex = 1;
            this.tabPageEntrustFlow.Text = "委托流水";
            this.tabPageEntrustFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageDialFlow
            // 
            this.tabPageDialFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageDialFlow.Name = "tabPageDialFlow";
            this.tabPageDialFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialFlow.Size = new System.Drawing.Size(747, 172);
            this.tabPageDialFlow.TabIndex = 2;
            this.tabPageDialFlow.Text = "成交流水";
            this.tabPageDialFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageEntrustFlowParent
            // 
            this.tabPageEntrustFlowParent.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntrustFlowParent.Name = "tabPageEntrustFlowParent";
            this.tabPageEntrustFlowParent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntrustFlowParent.Size = new System.Drawing.Size(761, 430);
            this.tabPageEntrustFlowParent.TabIndex = 1;
            this.tabPageEntrustFlowParent.Text = "委托流水";
            this.tabPageEntrustFlowParent.UseVisualStyleBackColor = true;
            // 
            // tabPageDialFlowParent
            // 
            this.tabPageDialFlowParent.Controls.Add(this.tableLayoutPanelDealFlow);
            this.tabPageDialFlowParent.Location = new System.Drawing.Point(4, 22);
            this.tabPageDialFlowParent.Name = "tabPageDialFlowParent";
            this.tabPageDialFlowParent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialFlowParent.Size = new System.Drawing.Size(761, 430);
            this.tabPageDialFlowParent.TabIndex = 2;
            this.tabPageDialFlowParent.Text = "成交流水";
            this.tabPageDialFlowParent.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelDealFlow
            // 
            this.tableLayoutPanelDealFlow.ColumnCount = 1;
            this.tableLayoutPanelDealFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDealFlow.Controls.Add(this.dataGridViewDealFlow, 0, 0);
            this.tableLayoutPanelDealFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDealFlow.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDealFlow.Name = "tableLayoutPanelDealFlow";
            this.tableLayoutPanelDealFlow.RowCount = 2;
            this.tableLayoutPanelDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanelDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelDealFlow.Size = new System.Drawing.Size(755, 424);
            this.tableLayoutPanelDealFlow.TabIndex = 0;
            // 
            // dataGridViewDealFlow
            // 
            this.dataGridViewDealFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDealFlow.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDealFlow.Name = "dataGridViewDealFlow";
            this.dataGridViewDealFlow.RowTemplate.Height = 23;
            this.dataGridViewDealFlow.Size = new System.Drawing.Size(749, 396);
            this.dataGridViewDealFlow.TabIndex = 0;
            // 
            // splitContainerMarket
            // 
            this.splitContainerMarket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMarket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMarket.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMarket.Name = "splitContainerMarket";
            this.splitContainerMarket.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMarket.Panel2
            // 
            this.splitContainerMarket.Panel2.Controls.Add(this.splitContainerTrading);
            this.splitContainerMarket.Size = new System.Drawing.Size(256, 460);
            this.splitContainerMarket.SplitterDistance = 70;
            this.splitContainerMarket.TabIndex = 0;
            // 
            // splitContainerTrading
            // 
            this.splitContainerTrading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTrading.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTrading.Name = "splitContainerTrading";
            this.splitContainerTrading.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTrading.Panel2
            // 
            this.splitContainerTrading.Panel2.Controls.Add(this.tableLayoutPanelTrading);
            this.splitContainerTrading.Size = new System.Drawing.Size(256, 386);
            this.splitContainerTrading.SplitterDistance = 54;
            this.splitContainerTrading.TabIndex = 0;
            // 
            // tableLayoutPanelTrading
            // 
            this.tableLayoutPanelTrading.ColumnCount = 1;
            this.tableLayoutPanelTrading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTrading.Controls.Add(this.panelEntrust, 0, 2);
            this.tableLayoutPanelTrading.Controls.Add(this.dataGridViewBuySell, 0, 1);
            this.tableLayoutPanelTrading.Controls.Add(this.buysellPanel, 0, 0);
            this.tableLayoutPanelTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrading.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrading.Name = "tableLayoutPanelTrading";
            this.tableLayoutPanelTrading.RowCount = 3;
            this.tableLayoutPanelTrading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanelTrading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.83951F));
            this.tableLayoutPanelTrading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.58025F));
            this.tableLayoutPanelTrading.Size = new System.Drawing.Size(252, 324);
            this.tableLayoutPanelTrading.TabIndex = 0;
            // 
            // panelEntrust
            // 
            this.panelEntrust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelEntrust.Controls.Add(this.btnEntrusting);
            this.panelEntrust.Controls.Add(this.btnCalc);
            this.panelEntrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntrust.Location = new System.Drawing.Point(3, 282);
            this.panelEntrust.Name = "panelEntrust";
            this.panelEntrust.Size = new System.Drawing.Size(246, 39);
            this.panelEntrust.TabIndex = 10;
            // 
            // btnEntrusting
            // 
            this.btnEntrusting.Location = new System.Drawing.Point(148, 10);
            this.btnEntrusting.Name = "btnEntrusting";
            this.btnEntrusting.Size = new System.Drawing.Size(75, 23);
            this.btnEntrusting.TabIndex = 1;
            this.btnEntrusting.Text = "委托";
            this.btnEntrusting.UseVisualStyleBackColor = true;
            this.btnEntrusting.Click += new System.EventHandler(this.ButtonEntrusting_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(42, 10);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // dataGridViewBuySell
            // 
            this.dataGridViewBuySell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuySell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuySell.Location = new System.Drawing.Point(3, 128);
            this.dataGridViewBuySell.Name = "dataGridViewBuySell";
            this.dataGridViewBuySell.RowTemplate.Height = 23;
            this.dataGridViewBuySell.Size = new System.Drawing.Size(246, 148);
            this.dataGridViewBuySell.TabIndex = 9;
            this.dataGridViewBuySell.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewBuySell_CellMouseClick);
            this.dataGridViewBuySell.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGridViewBuySell_CellParsing);
            this.dataGridViewBuySell.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridViewBuySell_EditingControlShowing);
            // 
            // buysellPanel
            // 
            this.buysellPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buysellPanel.Controls.Add(this.btnEntrust);
            this.buysellPanel.Controls.Add(this.btnCalculate);
            this.buysellPanel.Controls.Add(this.comboBoxFutureSell);
            this.buysellPanel.Controls.Add(this.comboBoxFutureBuy);
            this.buysellPanel.Controls.Add(this.comboBoxSpotSell);
            this.buysellPanel.Controls.Add(this.comboBoxSpotBuy);
            this.buysellPanel.Controls.Add(this.lblFuturesSellPrice);
            this.buysellPanel.Controls.Add(this.lblFuturesBuyPrice);
            this.buysellPanel.Controls.Add(this.lblSpotSellPrice);
            this.buysellPanel.Controls.Add(this.lblSpotBuyPrice);
            this.buysellPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buysellPanel.Location = new System.Drawing.Point(3, 3);
            this.buysellPanel.Name = "buysellPanel";
            this.buysellPanel.Size = new System.Drawing.Size(246, 119);
            this.buysellPanel.TabIndex = 2;
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
            // comboBoxFutureSell
            // 
            this.comboBoxFutureSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureSell.FormattingEnabled = true;
            this.comboBoxFutureSell.Location = new System.Drawing.Point(102, 93);
            this.comboBoxFutureSell.Name = "comboBoxFutureSell";
            this.comboBoxFutureSell.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFutureSell.TabIndex = 8;
            this.comboBoxFutureSell.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxFutureBuy
            // 
            this.comboBoxFutureBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureBuy.FormattingEnabled = true;
            this.comboBoxFutureBuy.Location = new System.Drawing.Point(102, 67);
            this.comboBoxFutureBuy.Name = "comboBoxFutureBuy";
            this.comboBoxFutureBuy.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFutureBuy.TabIndex = 7;
            this.comboBoxFutureBuy.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxSpotSell
            // 
            this.comboBoxSpotSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpotSell.FormattingEnabled = true;
            this.comboBoxSpotSell.Location = new System.Drawing.Point(102, 41);
            this.comboBoxSpotSell.Name = "comboBoxSpotSell";
            this.comboBoxSpotSell.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSpotSell.TabIndex = 6;
            // 
            // comboBoxSpotBuy
            // 
            this.comboBoxSpotBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelOrg});
            this.statusStripMain.Location = new System.Drawing.Point(0, 527);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1039, 22);
            this.statusStripMain.TabIndex = 4;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // statusLabelOrg
            // 
            this.statusLabelOrg.Name = "statusLabelOrg";
            this.statusLabelOrg.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridViewCmdSecurity
            // 
            this.dataGridViewCmdSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCmdSecurity.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCmdSecurity.Name = "dataGridViewCmdSecurity";
            this.dataGridViewCmdSecurity.RowTemplate.Height = 23;
            this.dataGridViewCmdSecurity.Size = new System.Drawing.Size(741, 166);
            this.dataGridViewCmdSecurity.TabIndex = 0;
            // 
            // HundsunExtDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 549);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "HundsunExtDemo2";
            this.Text = "HundsunExtDemo2";
            this.Load += new System.EventHandler(this.HundsunExtDemo2_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabTradingCommand.ResumeLayout(false);
            this.tabPageCommandTrading.ResumeLayout(false);
            this.splitContainerTradingCommand.Panel1.ResumeLayout(false);
            this.splitContainerTradingCommand.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTradingCommand)).EndInit();
            this.splitContainerTradingCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdTrading)).EndInit();
            this.tabControlDetailTrading.ResumeLayout(false);
            this.tabPageCommandSecu.ResumeLayout(false);
            this.tabPageDialFlowParent.ResumeLayout(false);
            this.tableLayoutPanelDealFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealFlow)).EndInit();
            this.splitContainerMarket.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMarket)).EndInit();
            this.splitContainerMarket.ResumeLayout(false);
            this.splitContainerTrading.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTrading)).EndInit();
            this.splitContainerTrading.ResumeLayout(false);
            this.tableLayoutPanelTrading.ResumeLayout(false);
            this.panelEntrust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).EndInit();
            this.buysellPanel.ResumeLayout(false);
            this.buysellPanel.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdSecurity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TabControl tabTradingCommand;
        private System.Windows.Forms.TabPage tabPageCommandTrading;
        private System.Windows.Forms.SplitContainer splitContainerTradingCommand;
        private System.Windows.Forms.TabControl tabControlDetailTrading;
        private System.Windows.Forms.TabPage tabPageCommandSecu;
        private System.Windows.Forms.TabPage tabPageEntrustFlow;
        private System.Windows.Forms.TabPage tabPageDialFlow;
        private System.Windows.Forms.TabPage tabPageEntrustFlowParent;
        private System.Windows.Forms.TabPage tabPageDialFlowParent;
        private System.Windows.Forms.SplitContainer splitContainerMarket;
        private System.Windows.Forms.SplitContainer splitContainerTrading;
        private System.Windows.Forms.Panel buysellPanel;
        private System.Windows.Forms.Button btnEntrust;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox comboBoxFutureSell;
        private System.Windows.Forms.ComboBox comboBoxFutureBuy;
        private System.Windows.Forms.ComboBox comboBoxSpotSell;
        private System.Windows.Forms.ComboBox comboBoxSpotBuy;
        private System.Windows.Forms.Label lblFuturesSellPrice;
        private System.Windows.Forms.Label lblFuturesBuyPrice;
        private System.Windows.Forms.Label lblSpotSellPrice;
        private System.Windows.Forms.Label lblSpotBuyPrice;
        private System.Windows.Forms.Panel panelEntrust;
        private System.Windows.Forms.Button btnEntrusting;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDealFlow;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelOrg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrading;

        private HSGridView dataGridViewCmdTrading;
        private HSGridView dataGridViewDealFlow;
        private HSGridView dataGridViewCmdSecurity;
        private HSGridView dataGridViewBuySell;
    }
}