﻿using Config;
using Controls;
namespace HundsunExtDemo.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private GridConfig _gridConfig = null;
        private const string GridCMDTrading = "cmdtrading";
        private const string GridEntrustFlow = "entrustflow";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.sysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabParentCmdTrading = new System.Windows.Forms.TabPage();
            this.spContainerParentCmdTrading = new System.Windows.Forms.SplitContainer();
            this.spContainerChildCmdTrading = new System.Windows.Forms.SplitContainer();
            this.tlPanelParentCommand = new System.Windows.Forms.TableLayoutPanel();
            //this.dataGridViewCmdTrading = new System.Windows.Forms.DataGridView();
            this.toolStripCmdTrading = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tabControlCmdDetail = new System.Windows.Forms.TabControl();
            this.tabChildCmdSecurity = new System.Windows.Forms.TabPage();
            this.tlPanelChildCmdSecurity = new System.Windows.Forms.TableLayoutPanel();
            //this.dataGridViewCmdSecurity = new System.Windows.Forms.DataGridView();
            this.tabChildEntrustFlow = new System.Windows.Forms.TabPage();
            this.tlPanelChildEntrustFlow = new System.Windows.Forms.TableLayoutPanel();
            this.tabChildDealFlow = new System.Windows.Forms.TabPage();
            this.tlPanelChildDealFlow = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerChildMarket = new System.Windows.Forms.SplitContainer();
            this.splitContainerChildEntrust = new System.Windows.Forms.SplitContainer();
            this.tlPanelCalcEntrust = new System.Windows.Forms.TableLayoutPanel();
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
            this.panelEntrust = new System.Windows.Forms.Panel();
            this.btnEntrusting = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            //this.dataGridViewBuySell = new System.Windows.Forms.DataGridView();
            this.tabParentEntrustFlow = new System.Windows.Forms.TabPage();
            this.tlPanelParentEntrustFlow = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            //this.dataGridViewEntrustFlow = new System.Windows.Forms.DataGridView();
            this.panelParentEntrustFlow = new System.Windows.Forms.Panel();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.tabParentDealFlow = new System.Windows.Forms.TabPage();
            this.tlPanelParentDealFlow = new System.Windows.Forms.TableLayoutPanel();
            //this.dataGridViewDealFlow = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();

            //
            //GridView
            //
            this.dataGridViewCmdTrading = new HSGridView(_gridConfig.GetGid(GridCMDTrading));
            this.dataGridViewCmdSecurity = new HSGridView(_gridConfig.GetGid(GridCMDSecurity));
            this.dataGridViewBuySell = new HSGridView(_gridConfig.GetGid(GridBuySell));
            this.dataGridViewEntrustFlow = new HSGridView(_gridConfig.GetGid(GridEntrustFlow));
            this.dataGridViewDealFlow = new HSGridView(_gridConfig.GetGid(GridDealFlow));

            this.tlPanelMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabParentCmdTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerParentCmdTrading)).BeginInit();
            this.spContainerParentCmdTrading.Panel1.SuspendLayout();
            this.spContainerParentCmdTrading.Panel2.SuspendLayout();
            this.spContainerParentCmdTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerChildCmdTrading)).BeginInit();
            this.spContainerChildCmdTrading.Panel1.SuspendLayout();
            this.spContainerChildCmdTrading.Panel2.SuspendLayout();
            this.spContainerChildCmdTrading.SuspendLayout();
            this.tlPanelParentCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdTrading)).BeginInit();
            this.toolStripCmdTrading.SuspendLayout();
            this.tabControlCmdDetail.SuspendLayout();
            this.tabChildCmdSecurity.SuspendLayout();
            this.tlPanelChildCmdSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdSecurity)).BeginInit();
            this.tabChildEntrustFlow.SuspendLayout();
            this.tabChildDealFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChildMarket)).BeginInit();
            this.splitContainerChildMarket.Panel2.SuspendLayout();
            this.splitContainerChildMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChildEntrust)).BeginInit();
            this.splitContainerChildEntrust.Panel2.SuspendLayout();
            this.splitContainerChildEntrust.SuspendLayout();
            this.tlPanelCalcEntrust.SuspendLayout();
            this.buysellPanel.SuspendLayout();
            this.panelEntrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).BeginInit();
            this.tabParentEntrustFlow.SuspendLayout();
            this.tlPanelParentEntrustFlow.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrustFlow)).BeginInit();
            this.panelParentEntrustFlow.SuspendLayout();
            this.tabParentDealFlow.SuspendLayout();
            this.tlPanelParentDealFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealFlow)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanelMain
            // 
            this.tlPanelMain.ColumnCount = 1;
            this.tlPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelMain.Controls.Add(this.toolStripMain, 0, 1);
            this.tlPanelMain.Controls.Add(this.menuStripMain, 0, 0);
            this.tlPanelMain.Controls.Add(this.tabControlMain, 0, 2);
            this.tlPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tlPanelMain.Name = "tlPanelMain";
            this.tlPanelMain.RowCount = 4;
            this.tlPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlPanelMain.Size = new System.Drawing.Size(1033, 536);
            this.tlPanelMain.TabIndex = 0;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStripMain.Location = new System.Drawing.Point(0, 26);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1033, 26);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1033, 26);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // sysToolStripMenuItem
            // 
            this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
            this.sysToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.sysToolStripMenuItem.Text = "系统";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "视图";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.toolToolStripMenuItem.Text = "工具";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabParentCmdTrading);
            this.tabControlMain.Controls.Add(this.tabParentEntrustFlow);
            this.tabControlMain.Controls.Add(this.tabParentDealFlow);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(3, 55);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1027, 449);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabParentCmdTrading
            // 
            this.tabParentCmdTrading.Controls.Add(this.spContainerParentCmdTrading);
            this.tabParentCmdTrading.Location = new System.Drawing.Point(4, 22);
            this.tabParentCmdTrading.Name = "tabParentCmdTrading";
            this.tabParentCmdTrading.Padding = new System.Windows.Forms.Padding(3);
            this.tabParentCmdTrading.Size = new System.Drawing.Size(1019, 423);
            this.tabParentCmdTrading.TabIndex = 0;
            this.tabParentCmdTrading.Text = "指令交易";
            this.tabParentCmdTrading.UseVisualStyleBackColor = true;
            // 
            // spContainerParentCmdTrading
            // 
            this.spContainerParentCmdTrading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainerParentCmdTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerParentCmdTrading.Location = new System.Drawing.Point(3, 3);
            this.spContainerParentCmdTrading.Name = "spContainerParentCmdTrading";
            // 
            // spContainerParentCmdTrading.Panel1
            // 
            this.spContainerParentCmdTrading.Panel1.Controls.Add(this.spContainerChildCmdTrading);
            // 
            // spContainerParentCmdTrading.Panel2
            // 
            this.spContainerParentCmdTrading.Panel2.Controls.Add(this.splitContainerChildMarket);
            this.spContainerParentCmdTrading.Size = new System.Drawing.Size(1013, 417);
            this.spContainerParentCmdTrading.SplitterDistance = 778;
            this.spContainerParentCmdTrading.TabIndex = 0;
            // 
            // spContainerChildCmdTrading
            // 
            this.spContainerChildCmdTrading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainerChildCmdTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerChildCmdTrading.Location = new System.Drawing.Point(0, 0);
            this.spContainerChildCmdTrading.Name = "spContainerChildCmdTrading";
            this.spContainerChildCmdTrading.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerChildCmdTrading.Panel1
            // 
            this.spContainerChildCmdTrading.Panel1.Controls.Add(this.tlPanelParentCommand);
            // 
            // spContainerChildCmdTrading.Panel2
            // 
            this.spContainerChildCmdTrading.Panel2.Controls.Add(this.tabControlCmdDetail);
            this.spContainerChildCmdTrading.Size = new System.Drawing.Size(778, 417);
            this.spContainerChildCmdTrading.SplitterDistance = 267;
            this.spContainerChildCmdTrading.TabIndex = 0;
            // 
            // tlPanelParentCommand
            // 
            this.tlPanelParentCommand.ColumnCount = 1;
            this.tlPanelParentCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelParentCommand.Controls.Add(this.dataGridViewCmdTrading, 0, 1);
            this.tlPanelParentCommand.Controls.Add(this.toolStripCmdTrading, 0, 0);
            this.tlPanelParentCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelParentCommand.Location = new System.Drawing.Point(0, 0);
            this.tlPanelParentCommand.Name = "tlPanelParentCommand";
            this.tlPanelParentCommand.RowCount = 3;
            this.tlPanelParentCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlPanelParentCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlPanelParentCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlPanelParentCommand.Size = new System.Drawing.Size(774, 263);
            this.tlPanelParentCommand.TabIndex = 0;
            // 
            // dataGridViewCmdTrading
            // 
            this.dataGridViewCmdTrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCmdTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCmdTrading.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewCmdTrading.Name = "dataGridViewCmdTrading";
            this.dataGridViewCmdTrading.RowTemplate.Height = 23;
            this.dataGridViewCmdTrading.Size = new System.Drawing.Size(768, 204);
            this.dataGridViewCmdTrading.TabIndex = 0;
            // 
            // toolStripCmdTrading
            // 
            this.toolStripCmdTrading.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStripCmdTrading.Location = new System.Drawing.Point(0, 0);
            this.toolStripCmdTrading.Name = "toolStripCmdTrading";
            this.toolStripCmdTrading.Size = new System.Drawing.Size(774, 25);
            this.toolStripCmdTrading.TabIndex = 1;
            this.toolStripCmdTrading.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "刷新";
            // 
            // tabControlCmdDetail
            // 
            this.tabControlCmdDetail.Controls.Add(this.tabChildCmdSecurity);
            this.tabControlCmdDetail.Controls.Add(this.tabChildEntrustFlow);
            this.tabControlCmdDetail.Controls.Add(this.tabChildDealFlow);
            this.tabControlCmdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCmdDetail.Location = new System.Drawing.Point(0, 0);
            this.tabControlCmdDetail.Name = "tabControlCmdDetail";
            this.tabControlCmdDetail.SelectedIndex = 0;
            this.tabControlCmdDetail.Size = new System.Drawing.Size(774, 142);
            this.tabControlCmdDetail.TabIndex = 0;
            this.tabControlCmdDetail.SelectedIndexChanged += new System.EventHandler(this.TabControlCmdDetail_SelectedIndexChanged);
            // 
            // tabChildCmdSecurity
            // 
            this.tabChildCmdSecurity.Controls.Add(this.tlPanelChildCmdSecurity);
            this.tabChildCmdSecurity.Location = new System.Drawing.Point(4, 22);
            this.tabChildCmdSecurity.Name = "tabChildCmdSecurity";
            this.tabChildCmdSecurity.Padding = new System.Windows.Forms.Padding(3);
            this.tabChildCmdSecurity.Size = new System.Drawing.Size(770, 120);
            this.tabChildCmdSecurity.TabIndex = 0;
            this.tabChildCmdSecurity.Text = "指令证券";
            this.tabChildCmdSecurity.UseVisualStyleBackColor = true;
            // 
            // tlPanelChildCmdSecurity
            // 
            this.tlPanelChildCmdSecurity.ColumnCount = 1;
            this.tlPanelChildCmdSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelChildCmdSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanelChildCmdSecurity.Controls.Add(this.dataGridViewCmdSecurity, 0, 0);
            this.tlPanelChildCmdSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelChildCmdSecurity.Location = new System.Drawing.Point(3, 3);
            this.tlPanelChildCmdSecurity.Name = "tlPanelChildCmdSecurity";
            this.tlPanelChildCmdSecurity.RowCount = 2;
            this.tlPanelChildCmdSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlPanelChildCmdSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlPanelChildCmdSecurity.Size = new System.Drawing.Size(764, 114);
            this.tlPanelChildCmdSecurity.TabIndex = 0;
            // 
            // dataGridViewCmdSecurity
            // 
            this.dataGridViewCmdSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCmdSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCmdSecurity.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCmdSecurity.Name = "dataGridViewCmdSecurity";
            this.dataGridViewCmdSecurity.RowTemplate.Height = 23;
            this.dataGridViewCmdSecurity.Size = new System.Drawing.Size(758, 96);
            this.dataGridViewCmdSecurity.TabIndex = 0;
            // 
            // tabChildEntrustFlow
            // 
            this.tabChildEntrustFlow.Controls.Add(this.tlPanelChildEntrustFlow);
            this.tabChildEntrustFlow.Location = new System.Drawing.Point(4, 22);
            this.tabChildEntrustFlow.Name = "tabChildEntrustFlow";
            this.tabChildEntrustFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabChildEntrustFlow.Size = new System.Drawing.Size(766, 116);
            this.tabChildEntrustFlow.TabIndex = 1;
            this.tabChildEntrustFlow.Text = "委托流水";
            this.tabChildEntrustFlow.UseVisualStyleBackColor = true;
            // 
            // tlPanelChildEntrustFlow
            // 
            this.tlPanelChildEntrustFlow.ColumnCount = 1;
            this.tlPanelChildEntrustFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelChildEntrustFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanelChildEntrustFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelChildEntrustFlow.Location = new System.Drawing.Point(3, 3);
            this.tlPanelChildEntrustFlow.Name = "tlPanelChildEntrustFlow";
            this.tlPanelChildEntrustFlow.RowCount = 2;
            this.tlPanelChildEntrustFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlPanelChildEntrustFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlPanelChildEntrustFlow.Size = new System.Drawing.Size(760, 110);
            this.tlPanelChildEntrustFlow.TabIndex = 0;
            // 
            // tabChildDealFlow
            // 
            this.tabChildDealFlow.Controls.Add(this.tlPanelChildDealFlow);
            this.tabChildDealFlow.Location = new System.Drawing.Point(4, 22);
            this.tabChildDealFlow.Name = "tabChildDealFlow";
            this.tabChildDealFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabChildDealFlow.Size = new System.Drawing.Size(770, 120);
            this.tabChildDealFlow.TabIndex = 2;
            this.tabChildDealFlow.Text = "成交流水";
            this.tabChildDealFlow.UseVisualStyleBackColor = true;
            // 
            // tlPanelChildDealFlow
            // 
            this.tlPanelChildDealFlow.ColumnCount = 1;
            this.tlPanelChildDealFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelChildDealFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanelChildDealFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelChildDealFlow.Location = new System.Drawing.Point(3, 3);
            this.tlPanelChildDealFlow.Name = "tlPanelChildDealFlow";
            this.tlPanelChildDealFlow.RowCount = 2;
            this.tlPanelChildDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlPanelChildDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlPanelChildDealFlow.Size = new System.Drawing.Size(764, 114);
            this.tlPanelChildDealFlow.TabIndex = 0;
            // 
            // splitContainerChildMarket
            // 
            this.splitContainerChildMarket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChildMarket.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChildMarket.Name = "splitContainerChildMarket";
            this.splitContainerChildMarket.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChildMarket.Panel2
            // 
            this.splitContainerChildMarket.Panel2.Controls.Add(this.splitContainerChildEntrust);
            this.splitContainerChildMarket.Size = new System.Drawing.Size(227, 413);
            this.splitContainerChildMarket.SplitterDistance = 57;
            this.splitContainerChildMarket.TabIndex = 0;
            // 
            // splitContainerChildEntrust
            // 
            this.splitContainerChildEntrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChildEntrust.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChildEntrust.Name = "splitContainerChildEntrust";
            this.splitContainerChildEntrust.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChildEntrust.Panel2
            // 
            this.splitContainerChildEntrust.Panel2.Controls.Add(this.tlPanelCalcEntrust);
            this.splitContainerChildEntrust.Size = new System.Drawing.Size(227, 352);
            this.splitContainerChildEntrust.SplitterDistance = 58;
            this.splitContainerChildEntrust.TabIndex = 0;
            // 
            // tlPanelCalcEntrust
            // 
            this.tlPanelCalcEntrust.ColumnCount = 1;
            this.tlPanelCalcEntrust.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelCalcEntrust.Controls.Add(this.buysellPanel, 0, 0);
            this.tlPanelCalcEntrust.Controls.Add(this.panelEntrust, 0, 2);
            this.tlPanelCalcEntrust.Controls.Add(this.dataGridViewBuySell, 0, 1);
            this.tlPanelCalcEntrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelCalcEntrust.Location = new System.Drawing.Point(0, 0);
            this.tlPanelCalcEntrust.Name = "tlPanelCalcEntrust";
            this.tlPanelCalcEntrust.RowCount = 3;
            this.tlPanelCalcEntrust.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPanelCalcEntrust.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlPanelCalcEntrust.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlPanelCalcEntrust.Size = new System.Drawing.Size(227, 290);
            this.tlPanelCalcEntrust.TabIndex = 0;
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
            this.buysellPanel.Size = new System.Drawing.Size(221, 124);
            this.buysellPanel.TabIndex = 3;
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
            // 
            // comboBoxFutureBuy
            // 
            this.comboBoxFutureBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureBuy.FormattingEnabled = true;
            this.comboBoxFutureBuy.Location = new System.Drawing.Point(102, 67);
            this.comboBoxFutureBuy.Name = "comboBoxFutureBuy";
            this.comboBoxFutureBuy.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFutureBuy.TabIndex = 7;
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
            // panelEntrust
            // 
            this.panelEntrust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelEntrust.Controls.Add(this.btnEntrusting);
            this.panelEntrust.Controls.Add(this.btnCalc);
            this.panelEntrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntrust.Location = new System.Drawing.Point(3, 249);
            this.panelEntrust.Name = "panelEntrust";
            this.panelEntrust.Size = new System.Drawing.Size(221, 38);
            this.panelEntrust.TabIndex = 11;
            // 
            // btnEntrusting
            // 
            this.btnEntrusting.Location = new System.Drawing.Point(148, 10);
            this.btnEntrusting.Name = "btnEntrusting";
            this.btnEntrusting.Size = new System.Drawing.Size(75, 23);
            this.btnEntrusting.TabIndex = 1;
            this.btnEntrusting.Text = "委托";
            this.btnEntrusting.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(42, 10);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuySell
            // 
            this.dataGridViewBuySell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuySell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuySell.Location = new System.Drawing.Point(3, 133);
            this.dataGridViewBuySell.Name = "dataGridViewBuySell";
            this.dataGridViewBuySell.RowTemplate.Height = 23;
            this.dataGridViewBuySell.Size = new System.Drawing.Size(221, 110);
            this.dataGridViewBuySell.TabIndex = 12;
            this.dataGridViewBuySell.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(DataGridViewBuySell_CellMouseClick);
            this.dataGridViewBuySell.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(DataGridViewBuySell_EditingControlShowing); 
            // 
            // tabParentEntrustFlow
            // 
            this.tabParentEntrustFlow.Controls.Add(this.tlPanelParentEntrustFlow);
            this.tabParentEntrustFlow.Location = new System.Drawing.Point(4, 22);
            this.tabParentEntrustFlow.Name = "tabParentEntrustFlow";
            this.tabParentEntrustFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabParentEntrustFlow.Size = new System.Drawing.Size(1019, 423);
            this.tabParentEntrustFlow.TabIndex = 1;
            this.tabParentEntrustFlow.Text = "委托流水";
            this.tabParentEntrustFlow.UseVisualStyleBackColor = true;
            // 
            // tlPanelParentEntrustFlow
            // 
            this.tlPanelParentEntrustFlow.ColumnCount = 1;
            this.tlPanelParentEntrustFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelParentEntrustFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanelParentEntrustFlow.Controls.Add(this.toolStrip1, 0, 0);
            this.tlPanelParentEntrustFlow.Controls.Add(this.dataGridViewEntrustFlow, 0, 1);
            this.tlPanelParentEntrustFlow.Controls.Add(this.panelParentEntrustFlow, 0, 2);
            this.tlPanelParentEntrustFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelParentEntrustFlow.Location = new System.Drawing.Point(3, 3);
            this.tlPanelParentEntrustFlow.Name = "tlPanelParentEntrustFlow";
            this.tlPanelParentEntrustFlow.RowCount = 3;
            this.tlPanelParentEntrustFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlPanelParentEntrustFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlPanelParentEntrustFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlPanelParentEntrustFlow.Size = new System.Drawing.Size(1013, 417);
            this.tlPanelParentEntrustFlow.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // dataGridViewEntrustFlow
            // 
            this.dataGridViewEntrustFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrustFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEntrustFlow.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewEntrustFlow.Name = "dataGridViewEntrustFlow";
            this.dataGridViewEntrustFlow.RowTemplate.Height = 23;
            this.dataGridViewEntrustFlow.Size = new System.Drawing.Size(1007, 327);
            this.dataGridViewEntrustFlow.TabIndex = 0;
            // 
            // panelParentEntrustFlow
            // 
            this.panelParentEntrustFlow.Controls.Add(this.btnCancelAdd);
            this.panelParentEntrustFlow.Controls.Add(this.btnCancelSelect);
            this.panelParentEntrustFlow.Controls.Add(this.btnUnselectAll);
            this.panelParentEntrustFlow.Controls.Add(this.btnSelectAll);
            this.panelParentEntrustFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParentEntrustFlow.Location = new System.Drawing.Point(3, 377);
            this.panelParentEntrustFlow.Name = "panelParentEntrustFlow";
            this.panelParentEntrustFlow.Size = new System.Drawing.Size(1007, 37);
            this.panelParentEntrustFlow.TabIndex = 2;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(248, 4);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdd.TabIndex = 3;
            this.btnCancelAdd.Text = "撤补";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancelSelect
            // 
            this.btnCancelSelect.Location = new System.Drawing.Point(166, 2);
            this.btnCancelSelect.Name = "btnCancelSelect";
            this.btnCancelSelect.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSelect.TabIndex = 2;
            this.btnCancelSelect.Text = "撤单";
            this.btnCancelSelect.UseVisualStyleBackColor = true;
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(84, 3);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(75, 23);
            this.btnUnselectAll.TabIndex = 1;
            this.btnUnselectAll.Text = "反选";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(3, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // tabParentDealFlow
            // 
            this.tabParentDealFlow.Controls.Add(this.tlPanelParentDealFlow);
            this.tabParentDealFlow.Location = new System.Drawing.Point(4, 22);
            this.tabParentDealFlow.Name = "tabParentDealFlow";
            this.tabParentDealFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabParentDealFlow.Size = new System.Drawing.Size(1019, 423);
            this.tabParentDealFlow.TabIndex = 2;
            this.tabParentDealFlow.Text = "成交流水";
            this.tabParentDealFlow.UseVisualStyleBackColor = true;
            // 
            // tlPanelParentDealFlow
            // 
            this.tlPanelParentDealFlow.ColumnCount = 1;
            this.tlPanelParentDealFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelParentDealFlow.Controls.Add(this.dataGridViewDealFlow, 0, 1);
            this.tlPanelParentDealFlow.Controls.Add(this.toolStrip2, 0, 0);
            this.tlPanelParentDealFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelParentDealFlow.Location = new System.Drawing.Point(3, 3);
            this.tlPanelParentDealFlow.Name = "tlPanelParentDealFlow";
            this.tlPanelParentDealFlow.RowCount = 3;
            this.tlPanelParentDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlPanelParentDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlPanelParentDealFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlPanelParentDealFlow.Size = new System.Drawing.Size(1013, 417);
            this.tlPanelParentDealFlow.TabIndex = 0;
            // 
            // dataGridViewDealFlow
            // 
            this.dataGridViewDealFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDealFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDealFlow.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewDealFlow.Name = "dataGridViewDealFlow";
            this.dataGridViewDealFlow.RowTemplate.Height = 23;
            this.dataGridViewDealFlow.Size = new System.Drawing.Size(1007, 327);
            this.dataGridViewDealFlow.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "toolStripButton11";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 536);
            this.Controls.Add(this.tlPanelMain);
            this.Name = "MainForm";
            this.Text = "策略交易";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlPanelMain.ResumeLayout(false);
            this.tlPanelMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabParentCmdTrading.ResumeLayout(false);
            this.spContainerParentCmdTrading.Panel1.ResumeLayout(false);
            this.spContainerParentCmdTrading.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerParentCmdTrading)).EndInit();
            this.spContainerParentCmdTrading.ResumeLayout(false);
            this.spContainerChildCmdTrading.Panel1.ResumeLayout(false);
            this.spContainerChildCmdTrading.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerChildCmdTrading)).EndInit();
            this.spContainerChildCmdTrading.ResumeLayout(false);
            this.tlPanelParentCommand.ResumeLayout(false);
            this.tlPanelParentCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdTrading)).EndInit();
            this.toolStripCmdTrading.ResumeLayout(false);
            this.toolStripCmdTrading.PerformLayout();
            this.tabControlCmdDetail.ResumeLayout(false);
            this.tabChildCmdSecurity.ResumeLayout(false);
            this.tlPanelChildCmdSecurity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmdSecurity)).EndInit();
            this.tabChildEntrustFlow.ResumeLayout(false);
            this.tabChildDealFlow.ResumeLayout(false);
            this.splitContainerChildMarket.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChildMarket)).EndInit();
            this.splitContainerChildMarket.ResumeLayout(false);
            this.splitContainerChildEntrust.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChildEntrust)).EndInit();
            this.splitContainerChildEntrust.ResumeLayout(false);
            this.tlPanelCalcEntrust.ResumeLayout(false);
            this.buysellPanel.ResumeLayout(false);
            this.buysellPanel.PerformLayout();
            this.panelEntrust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).EndInit();
            this.tabParentEntrustFlow.ResumeLayout(false);
            this.tlPanelParentEntrustFlow.ResumeLayout(false);
            this.tlPanelParentEntrustFlow.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrustFlow)).EndInit();
            this.panelParentEntrustFlow.ResumeLayout(false);
            this.tabParentDealFlow.ResumeLayout(false);
            this.tlPanelParentDealFlow.ResumeLayout(false);
            this.tlPanelParentDealFlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealFlow)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanelMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabParentCmdTrading;
        private System.Windows.Forms.SplitContainer spContainerParentCmdTrading;
        private System.Windows.Forms.TabPage tabParentEntrustFlow;
        private System.Windows.Forms.TabPage tabParentDealFlow;
        private System.Windows.Forms.SplitContainer spContainerChildCmdTrading;
        private System.Windows.Forms.SplitContainer splitContainerChildMarket;
        private System.Windows.Forms.SplitContainer splitContainerChildEntrust;
        private System.Windows.Forms.TableLayoutPanel tlPanelParentCommand;
        private System.Windows.Forms.TabControl tabControlCmdDetail;
        private System.Windows.Forms.TabPage tabChildCmdSecurity;
        private System.Windows.Forms.TableLayoutPanel tlPanelChildCmdSecurity;
        private System.Windows.Forms.TabPage tabChildEntrustFlow;
        private System.Windows.Forms.TabPage tabChildDealFlow;
        private System.Windows.Forms.TableLayoutPanel tlPanelParentEntrustFlow;
        private System.Windows.Forms.TableLayoutPanel tlPanelParentDealFlow;
        private System.Windows.Forms.TableLayoutPanel tlPanelCalcEntrust;
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
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem sysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;

        private HSGridView dataGridViewCmdTrading;
        private HSGridView dataGridViewCmdSecurity;
        private HSGridView dataGridViewBuySell;
        private HSGridView dataGridViewEntrustFlow;
        private HSGridView dataGridViewDealFlow;

        //private System.Windows.Forms.DataGridView dataGridViewCmdTrading;
        //private System.Windows.Forms.DataGridView dataGridViewCmdSecurity;
        //private System.Windows.Forms.DataGridView dataGridViewBuySell;
        //private System.Windows.Forms.DataGridView dataGridViewEntrustFlow;
        //private System.Windows.Forms.DataGridView dataGridViewDealFlow;

        private System.Windows.Forms.ToolStrip toolStripCmdTrading;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.Panel panelParentEntrustFlow;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.TableLayoutPanel tlPanelChildEntrustFlow;
        private System.Windows.Forms.TableLayoutPanel tlPanelChildDealFlow;
    }
}