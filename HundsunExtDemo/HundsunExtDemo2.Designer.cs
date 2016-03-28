﻿using System;
namespace HundsunExtDemo
{
    partial class HundsunExtDemo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HundsunExtDemo2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tc_commandno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_executetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_targetnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_baisprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_longmorethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_bearmorethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_longratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_bearratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_entrustedamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_dealamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_commandmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlDetailTrading = new System.Windows.Forms.TabControl();
            this.tabPageCommandSecu = new System.Windows.Forms.TabPage();
            this.tabPageEntrustFlow = new System.Windows.Forms.TabPage();
            this.tabPageDialFlow = new System.Windows.Forms.TabPage();
            this.tabPageEntrustFlowParent = new System.Windows.Forms.TabPage();
            this.tabPageDialFlowParent = new System.Windows.Forms.TabPage();
            this.splitContainerMarket = new System.Windows.Forms.SplitContainer();
            this.splitContainerTrading = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelTrading = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewBuySell = new System.Windows.Forms.DataGridView();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commandno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.tableLayoutPanelDealFlow = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDealFlow = new System.Windows.Forms.DataGridView();
            this.df_commandno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_securitycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_securityname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_fundno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_fundname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_portfoliocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_portfolioname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_pricetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_entrustprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_entrustdirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_dealprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_dealamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_dealmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_dealtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_stockholdercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_declareno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_declareseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_entrustbatchno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_instanceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_instanceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_entrustno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.df_dealno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControlDetailTrading.SuspendLayout();
            this.tabPageDialFlowParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMarket)).BeginInit();
            this.splitContainerMarket.Panel2.SuspendLayout();
            this.splitContainerMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTrading)).BeginInit();
            this.splitContainerTrading.Panel2.SuspendLayout();
            this.splitContainerTrading.SuspendLayout();
            this.tableLayoutPanelTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).BeginInit();
            this.buysellPanel.SuspendLayout();
            this.panelEntrust.SuspendLayout();
            this.tableLayoutPanelDealFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.toolStrip, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainerMain, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 549);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(0, 38);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1039, 38);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 35);
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
            this.menuStrip.Size = new System.Drawing.Size(1039, 38);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sysToolStripMenuItem
            // 
            this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
            this.sysToolStripMenuItem.Size = new System.Drawing.Size(38, 34);
            this.sysToolStripMenuItem.Text = "sys";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 34);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 34);
            this.toolToolStripMenuItem.Text = "tool";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 34);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 79);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tabTradingCommand);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerMarket);
            this.splitContainerMain.Size = new System.Drawing.Size(1033, 411);
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
            this.tabTradingCommand.Size = new System.Drawing.Size(769, 407);
            this.tabTradingCommand.TabIndex = 2;
            this.tabTradingCommand.Tag = "";
            // 
            // tabPageCommandTrading
            // 
            this.tabPageCommandTrading.Controls.Add(this.splitContainerTradingCommand);
            this.tabPageCommandTrading.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandTrading.Name = "tabPageCommandTrading";
            this.tabPageCommandTrading.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandTrading.Size = new System.Drawing.Size(761, 381);
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
            this.splitContainerTradingCommand.Size = new System.Drawing.Size(755, 375);
            this.splitContainerTradingCommand.SplitterDistance = 197;
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
            this.tc_targetnum,
            this.tc_baisprice,
            this.tc_longmorethan,
            this.tc_bearmorethan,
            this.tc_longratio,
            this.tc_bearratio,
            this.tc_commandamount,
            this.tc_entrustedamount,
            this.tc_dealamount,
            this.tc_commandmoney});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(755, 197);
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
            // tc_targetnum
            // 
            this.tc_targetnum.HeaderText = "目标份数";
            this.tc_targetnum.Name = "tc_targetnum";
            // 
            // tc_baisprice
            // 
            this.tc_baisprice.HeaderText = "基差|价差";
            this.tc_baisprice.Name = "tc_baisprice";
            // 
            // tc_longmorethan
            // 
            this.tc_longmorethan.HeaderText = "多头委比";
            this.tc_longmorethan.Name = "tc_longmorethan";
            // 
            // tc_bearmorethan
            // 
            this.tc_bearmorethan.HeaderText = "空头委比";
            this.tc_bearmorethan.Name = "tc_bearmorethan";
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
            // tc_dealamount
            // 
            this.tc_dealamount.HeaderText = "已成数量";
            this.tc_dealamount.Name = "tc_dealamount";
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
            this.tabControlDetailTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetailTrading.Location = new System.Drawing.Point(0, 0);
            this.tabControlDetailTrading.Name = "tabControlDetailTrading";
            this.tabControlDetailTrading.SelectedIndex = 0;
            this.tabControlDetailTrading.Size = new System.Drawing.Size(755, 174);
            this.tabControlDetailTrading.TabIndex = 0;
            // 
            // tabPageCommandSecu
            // 
            this.tabPageCommandSecu.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommandSecu.Name = "tabPageCommandSecu";
            this.tabPageCommandSecu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommandSecu.Size = new System.Drawing.Size(747, 148);
            this.tabPageCommandSecu.TabIndex = 0;
            this.tabPageCommandSecu.Text = "指令证券";
            this.tabPageCommandSecu.UseVisualStyleBackColor = true;
            // 
            // tabPageEntrustFlow
            // 
            this.tabPageEntrustFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntrustFlow.Name = "tabPageEntrustFlow";
            this.tabPageEntrustFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntrustFlow.Size = new System.Drawing.Size(747, 148);
            this.tabPageEntrustFlow.TabIndex = 1;
            this.tabPageEntrustFlow.Text = "委托流水";
            this.tabPageEntrustFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageDialFlow
            // 
            this.tabPageDialFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageDialFlow.Name = "tabPageDialFlow";
            this.tabPageDialFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialFlow.Size = new System.Drawing.Size(747, 148);
            this.tabPageDialFlow.TabIndex = 2;
            this.tabPageDialFlow.Text = "成交流水";
            this.tabPageDialFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageEntrustFlowParent
            // 
            this.tabPageEntrustFlowParent.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntrustFlowParent.Name = "tabPageEntrustFlowParent";
            this.tabPageEntrustFlowParent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntrustFlowParent.Size = new System.Drawing.Size(761, 381);
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
            this.tabPageDialFlowParent.Size = new System.Drawing.Size(761, 381);
            this.tabPageDialFlowParent.TabIndex = 2;
            this.tabPageDialFlowParent.Text = "成交流水";
            this.tabPageDialFlowParent.UseVisualStyleBackColor = true;
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
            this.splitContainerMarket.Size = new System.Drawing.Size(256, 411);
            this.splitContainerMarket.SplitterDistance = 63;
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
            this.splitContainerTrading.Size = new System.Drawing.Size(256, 344);
            this.splitContainerTrading.SplitterDistance = 49;
            this.splitContainerTrading.TabIndex = 0;
            // 
            // tableLayoutPanelTrading
            // 
            this.tableLayoutPanelTrading.ColumnCount = 1;
            this.tableLayoutPanelTrading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrading.Controls.Add(this.dataGridViewBuySell, 0, 1);
            this.tableLayoutPanelTrading.Controls.Add(this.buysellPanel, 0, 0);
            this.tableLayoutPanelTrading.Controls.Add(this.panelEntrust, 0, 2);
            this.tableLayoutPanelTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrading.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrading.Name = "tableLayoutPanelTrading";
            this.tableLayoutPanelTrading.RowCount = 3;
            this.tableLayoutPanelTrading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanelTrading.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTrading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelTrading.Size = new System.Drawing.Size(252, 287);
            this.tableLayoutPanelTrading.TabIndex = 0;
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
            this.dataGridViewBuySell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuySell.Location = new System.Drawing.Point(3, 132);
            this.dataGridViewBuySell.Name = "dataGridViewBuySell";
            this.dataGridViewBuySell.RowTemplate.Height = 23;
            this.dataGridViewBuySell.Size = new System.Drawing.Size(246, 106);
            this.dataGridViewBuySell.TabIndex = 9;
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
            // buysellPanel
            // 
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
            this.buysellPanel.Size = new System.Drawing.Size(246, 123);
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
            // panelEntrust
            // 
            this.panelEntrust.Controls.Add(this.btnEntrusting);
            this.panelEntrust.Controls.Add(this.btnCalc);
            this.panelEntrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntrust.Location = new System.Drawing.Point(3, 244);
            this.panelEntrust.Name = "panelEntrust";
            this.panelEntrust.Size = new System.Drawing.Size(246, 40);
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
            this.tableLayoutPanelDealFlow.Size = new System.Drawing.Size(755, 375);
            this.tableLayoutPanelDealFlow.TabIndex = 0;
            // 
            // dataGridViewDealFlow
            // 
            this.dataGridViewDealFlow.AllowUserToAddRows = false;
            this.dataGridViewDealFlow.AllowUserToDeleteRows = false;
            this.dataGridViewDealFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDealFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.df_commandno,
            this.df_securitycode,
            this.df_securityname,
            this.df_fundno,
            this.df_fundname,
            this.df_portfoliocode,
            this.df_portfolioname,
            this.df_pricetype,
            this.df_entrustprice,
            this.df_entrustdirection,
            this.df_dealprice,
            this.df_dealamount,
            this.df_dealmoney,
            this.df_dealtime,
            this.df_stockholdercode,
            this.df_declareno,
            this.df_declareseat,
            this.df_entrustbatchno,
            this.df_instanceid,
            this.df_instanceno,
            this.df_entrustno,
            this.df_dealno});
            this.dataGridViewDealFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDealFlow.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDealFlow.Name = "dataGridViewDealFlow";
            this.dataGridViewDealFlow.RowTemplate.Height = 23;
            this.dataGridViewDealFlow.Size = new System.Drawing.Size(749, 350);
            this.dataGridViewDealFlow.TabIndex = 0;
            // 
            // df_commandno
            // 
            this.df_commandno.HeaderText = "指令序号";
            this.df_commandno.Name = "df_commandno";
            this.df_commandno.Width = 80;
            // 
            // df_securitycode
            // 
            this.df_securitycode.HeaderText = "证券代码";
            this.df_securitycode.Name = "df_securitycode";
            this.df_securitycode.Width = 80;
            // 
            // df_securityname
            // 
            this.df_securityname.HeaderText = "证券名称";
            this.df_securityname.Name = "df_securityname";
            this.df_securityname.Width = 80;
            // 
            // df_fundno
            // 
            this.df_fundno.HeaderText = "基金序号";
            this.df_fundno.Name = "df_fundno";
            this.df_fundno.Width = 80;
            // 
            // df_fundname
            // 
            this.df_fundname.HeaderText = "基金名称";
            this.df_fundname.Name = "df_fundname";
            this.df_fundname.Width = 80;
            // 
            // df_portfoliocode
            // 
            this.df_portfoliocode.HeaderText = "组合代码";
            this.df_portfoliocode.Name = "df_portfoliocode";
            this.df_portfoliocode.Width = 80;
            // 
            // df_portfolioname
            // 
            this.df_portfolioname.HeaderText = "组合名称";
            this.df_portfolioname.Name = "df_portfolioname";
            this.df_portfolioname.Width = 80;
            // 
            // df_pricetype
            // 
            this.df_pricetype.HeaderText = "价格类型";
            this.df_pricetype.Name = "df_pricetype";
            this.df_pricetype.Width = 80;
            // 
            // df_entrustprice
            // 
            this.df_entrustprice.HeaderText = "委托价格";
            this.df_entrustprice.Name = "df_entrustprice";
            this.df_entrustprice.Width = 80;
            // 
            // df_entrustdirection
            // 
            this.df_entrustdirection.HeaderText = "委托方向";
            this.df_entrustdirection.Name = "df_entrustdirection";
            this.df_entrustdirection.Width = 80;
            // 
            // df_dealprice
            // 
            this.df_dealprice.HeaderText = "成交价格";
            this.df_dealprice.Name = "df_dealprice";
            this.df_dealprice.Width = 80;
            // 
            // df_dealamount
            // 
            this.df_dealamount.HeaderText = "成交数量";
            this.df_dealamount.Name = "df_dealamount";
            this.df_dealamount.Width = 80;
            // 
            // df_dealmoney
            // 
            this.df_dealmoney.HeaderText = "成交金额";
            this.df_dealmoney.Name = "df_dealmoney";
            this.df_dealmoney.Width = 80;
            // 
            // df_dealtime
            // 
            this.df_dealtime.HeaderText = "成交时间";
            this.df_dealtime.Name = "df_dealtime";
            this.df_dealtime.Width = 80;
            // 
            // df_stockholdercode
            // 
            this.df_stockholdercode.HeaderText = "股东代码";
            this.df_stockholdercode.Name = "df_stockholdercode";
            this.df_stockholdercode.Width = 80;
            // 
            // df_declareno
            // 
            this.df_declareno.HeaderText = "申报序号";
            this.df_declareno.Name = "df_declareno";
            this.df_declareno.Width = 80;
            // 
            // df_declareseat
            // 
            this.df_declareseat.HeaderText = "申报席位";
            this.df_declareseat.Name = "df_declareseat";
            this.df_declareseat.Width = 80;
            // 
            // df_entrustbatchno
            // 
            this.df_entrustbatchno.HeaderText = "申报批号";
            this.df_entrustbatchno.Name = "df_entrustbatchno";
            this.df_entrustbatchno.Width = 80;
            // 
            // df_instanceid
            // 
            this.df_instanceid.HeaderText = "实例号";
            this.df_instanceid.Name = "df_instanceid";
            this.df_instanceid.Width = 80;
            // 
            // df_instanceno
            // 
            this.df_instanceno.HeaderText = "实例编号";
            this.df_instanceno.Name = "df_instanceno";
            this.df_instanceno.Width = 80;
            // 
            // df_entrustno
            // 
            this.df_entrustno.HeaderText = "委托序号";
            this.df_entrustno.Name = "df_entrustno";
            this.df_entrustno.Width = 80;
            // 
            // df_dealno
            // 
            this.df_dealno.HeaderText = "成交序号";
            this.df_dealno.Name = "df_dealno";
            this.df_dealno.Width = 80;
            // 
            // HundsunExtDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HundsunExtDemo2";
            this.Text = "HundsunExtDemo2";
            this.Load += new System.EventHandler(this.HundsunExtDemo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControlDetailTrading.ResumeLayout(false);
            this.tabPageDialFlowParent.ResumeLayout(false);
            this.splitContainerMarket.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMarket)).EndInit();
            this.splitContainerMarket.ResumeLayout(false);
            this.splitContainerTrading.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTrading)).EndInit();
            this.splitContainerTrading.ResumeLayout(false);
            this.tableLayoutPanelTrading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuySell)).EndInit();
            this.buysellPanel.ResumeLayout(false);
            this.buysellPanel.PerformLayout();
            this.panelEntrust.ResumeLayout(false);
            this.tableLayoutPanelDealFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealFlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_executetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_targetnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_baisprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_longmorethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_bearmorethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_longratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_bearratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_entrustedamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_dealamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_commandmoney;
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
        private System.Windows.Forms.DataGridView dataGridViewBuySell;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandno;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn copies;
        private System.Windows.Forms.DataGridViewImageColumn minus;
        private System.Windows.Forms.ComboBox comboBoxFutureSell;
        private System.Windows.Forms.ComboBox comboBoxFutureBuy;
        private System.Windows.Forms.ComboBox comboBoxSpotSell;
        private System.Windows.Forms.ComboBox comboBoxSpotBuy;
        private System.Windows.Forms.Label lblFuturesSellPrice;
        private System.Windows.Forms.Label lblFuturesBuyPrice;
        private System.Windows.Forms.Label lblSpotSellPrice;
        private System.Windows.Forms.Label lblSpotBuyPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrading;
        private System.Windows.Forms.Panel panelEntrust;
        private System.Windows.Forms.Button btnEntrusting;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDealFlow;
        private System.Windows.Forms.DataGridView dataGridViewDealFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_commandno;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_securitycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_securityname;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_fundno;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_fundname;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_portfoliocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_portfolioname;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_pricetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_entrustprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_entrustdirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_dealprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_dealamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_dealmoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_dealtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_stockholdercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_declareno;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_declareseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_entrustbatchno;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_instanceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_instanceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_entrustno;
        private System.Windows.Forms.DataGridViewTextBoxColumn df_dealno;
    }
}