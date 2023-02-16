﻿
namespace TarkovPriceViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayshow = new System.Windows.Forms.ToolStripMenuItem();
            this.trayexit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.week_price_box = new System.Windows.Forms.CheckBox();
            this.day_price_box = new System.Windows.Forms.CheckBox();
            this.buy_from_trader_box = new System.Windows.Forms.CheckBox();
            this.needs_box = new System.Windows.Forms.CheckBox();
            this.barters_and_crafts_box = new System.Windows.Forms.CheckBox();
            this.sell_to_trader_box = new System.Windows.Forms.CheckBox();
            this.last_price_box = new System.Windows.Forms.CheckBox();
            this.ShowOverlay_Button = new System.Windows.Forms.Button();
            this.ShowOverlay_Desc = new System.Windows.Forms.Label();
            this.TransParent_Text = new System.Windows.Forms.Label();
            this.CloseOverlayWhenMouseMoved = new System.Windows.Forms.CheckBox();
            this.TransParent_Bar = new System.Windows.Forms.TrackBar();
            this.HideOverlay_Desc2 = new System.Windows.Forms.Label();
            this.TransParent_Desc = new System.Windows.Forms.Label();
            this.HideOverlay_Button = new System.Windows.Forms.Button();
            this.HideOverlay_Desc = new System.Windows.Forms.Label();
            this.CheckUpdate = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.Button();
            this.TarkovMarket = new System.Windows.Forms.Button();
            this.TarkovWiki = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Tarkov_Dev = new System.Windows.Forms.Button();
            this.DataProvidedBy = new System.Windows.Forms.Label();
            this.Tarkov_Official = new System.Windows.Forms.Button();
            this.MinimizetoTrayWhenStartup = new System.Windows.Forms.CheckBox();
            this.Version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CompareOverlay_Desc = new System.Windows.Forms.Label();
            this.CompareOverlay_Button = new System.Windows.Forms.Button();
            this.CompareOverlay_Desc2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.RandomItem = new System.Windows.Forms.CheckBox();
            this.ForFunRandom_Desc = new System.Windows.Forms.Label();
            this.check_idle_time = new System.Windows.Forms.Timer(this.components);
            this.refresh_b = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tarkovTrackerApiKey_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TarkovTrackerAPI_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.TarkovTracker_button = new System.Windows.Forms.Button();
            this.hideoutUpgrades_checkBox = new System.Windows.Forms.CheckBox();
            this.TrayMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransParent_Bar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "TarkovPriceViewer";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayshow,
            this.trayexit});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // trayshow
            // 
            this.trayshow.Name = "trayshow";
            this.trayshow.Size = new System.Drawing.Size(103, 22);
            this.trayshow.Text = "Show";
            this.trayshow.Click += new System.EventHandler(this.TrayShow_Click);
            // 
            // trayexit
            // 
            this.trayexit.Name = "trayexit";
            this.trayexit.Size = new System.Drawing.Size(103, 22);
            this.trayexit.Text = "Exit";
            this.trayexit.Click += new System.EventHandler(this.TrayExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hideoutUpgrades_checkBox);
            this.panel1.Controls.Add(this.day_price_box);
            this.panel1.Controls.Add(this.buy_from_trader_box);
            this.panel1.Controls.Add(this.needs_box);
            this.panel1.Controls.Add(this.barters_and_crafts_box);
            this.panel1.Controls.Add(this.sell_to_trader_box);
            this.panel1.Controls.Add(this.last_price_box);
            this.panel1.Controls.Add(this.ShowOverlay_Button);
            this.panel1.Controls.Add(this.ShowOverlay_Desc);
            this.panel1.Location = new System.Drawing.Point(10, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 139);
            this.panel1.TabIndex = 1;
            // 
            // week_price_box
            // 
            this.week_price_box.AutoSize = true;
            this.week_price_box.Location = new System.Drawing.Point(449, 28);
            this.week_price_box.Name = "week_price_box";
            this.week_price_box.Size = new System.Drawing.Size(78, 17);
            this.week_price_box.TabIndex = 7;
            this.week_price_box.TabStop = false;
            this.week_price_box.Text = "week price";
            this.week_price_box.UseVisualStyleBackColor = true;
            this.week_price_box.Visible = false;
            this.week_price_box.CheckedChanged += new System.EventHandler(this.week_price_box_CheckedChanged);
            // 
            // day_price_box
            // 
            this.day_price_box.AutoSize = true;
            this.day_price_box.Location = new System.Drawing.Point(131, 40);
            this.day_price_box.Name = "day_price_box";
            this.day_price_box.Size = new System.Drawing.Size(87, 17);
            this.day_price_box.TabIndex = 7;
            this.day_price_box.TabStop = false;
            this.day_price_box.Text = "24h Average";
            this.day_price_box.UseVisualStyleBackColor = true;
            this.day_price_box.CheckedChanged += new System.EventHandler(this.day_price_box_CheckedChanged);
            // 
            // buy_from_trader_box
            // 
            this.buy_from_trader_box.AutoSize = true;
            this.buy_from_trader_box.Location = new System.Drawing.Point(131, 63);
            this.buy_from_trader_box.Name = "buy_from_trader_box";
            this.buy_from_trader_box.Size = new System.Drawing.Size(101, 17);
            this.buy_from_trader_box.TabIndex = 7;
            this.buy_from_trader_box.TabStop = false;
            this.buy_from_trader_box.Text = "Buy from Trader";
            this.buy_from_trader_box.UseVisualStyleBackColor = true;
            this.buy_from_trader_box.CheckedChanged += new System.EventHandler(this.buy_from_trader_box_CheckedChanged);
            // 
            // needs_box
            // 
            this.needs_box.AutoSize = true;
            this.needs_box.Location = new System.Drawing.Point(8, 86);
            this.needs_box.Name = "needs_box";
            this.needs_box.Size = new System.Drawing.Size(94, 17);
            this.needs_box.TabIndex = 7;
            this.needs_box.TabStop = false;
            this.needs_box.Text = "Used in Tasks";
            this.needs_box.UseVisualStyleBackColor = true;
            this.needs_box.CheckedChanged += new System.EventHandler(this.needs_box_CheckedChanged);
            // 
            // barters_and_crafts_box
            // 
            this.barters_and_crafts_box.AutoSize = true;
            this.barters_and_crafts_box.Location = new System.Drawing.Point(131, 86);
            this.barters_and_crafts_box.Name = "barters_and_crafts_box";
            this.barters_and_crafts_box.Size = new System.Drawing.Size(110, 17);
            this.barters_and_crafts_box.TabIndex = 7;
            this.barters_and_crafts_box.TabStop = false;
            this.barters_and_crafts_box.Text = "Barters and Crafts";
            this.barters_and_crafts_box.UseVisualStyleBackColor = true;
            this.barters_and_crafts_box.CheckedChanged += new System.EventHandler(this.barters_and_crafts_box_CheckedChanged);
            // 
            // sell_to_trader_box
            // 
            this.sell_to_trader_box.AutoSize = true;
            this.sell_to_trader_box.Location = new System.Drawing.Point(8, 63);
            this.sell_to_trader_box.Name = "sell_to_trader_box";
            this.sell_to_trader_box.Size = new System.Drawing.Size(89, 17);
            this.sell_to_trader_box.TabIndex = 7;
            this.sell_to_trader_box.TabStop = false;
            this.sell_to_trader_box.Text = "Sell to Trader";
            this.sell_to_trader_box.UseVisualStyleBackColor = true;
            this.sell_to_trader_box.CheckedChanged += new System.EventHandler(this.sell_to_trader_box_CheckedChanged);
            // 
            // last_price_box
            // 
            this.last_price_box.AutoSize = true;
            this.last_price_box.Location = new System.Drawing.Point(8, 40);
            this.last_price_box.Name = "last_price_box";
            this.last_price_box.Size = new System.Drawing.Size(73, 17);
            this.last_price_box.TabIndex = 7;
            this.last_price_box.TabStop = false;
            this.last_price_box.Text = "Last Price";
            this.last_price_box.UseVisualStyleBackColor = true;
            this.last_price_box.CheckedChanged += new System.EventHandler(this.last_price_box_CheckedChanged);
            // 
            // ShowOverlay_Button
            // 
            this.ShowOverlay_Button.Location = new System.Drawing.Point(131, 9);
            this.ShowOverlay_Button.Name = "ShowOverlay_Button";
            this.ShowOverlay_Button.Size = new System.Drawing.Size(110, 25);
            this.ShowOverlay_Button.TabIndex = 1;
            this.ShowOverlay_Button.TabStop = false;
            this.ShowOverlay_Button.Text = "F9";
            this.ShowOverlay_Button.UseVisualStyleBackColor = true;
            this.ShowOverlay_Button.Click += new System.EventHandler(this.Overlay_Button_Click);
            // 
            // ShowOverlay_Desc
            // 
            this.ShowOverlay_Desc.AutoSize = true;
            this.ShowOverlay_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowOverlay_Desc.Location = new System.Drawing.Point(5, 13);
            this.ShowOverlay_Desc.Name = "ShowOverlay_Desc";
            this.ShowOverlay_Desc.Size = new System.Drawing.Size(120, 15);
            this.ShowOverlay_Desc.TabIndex = 0;
            this.ShowOverlay_Desc.Text = "Show Overlay Key";
            // 
            // TransParent_Text
            // 
            this.TransParent_Text.AutoSize = true;
            this.TransParent_Text.Location = new System.Drawing.Point(214, 39);
            this.TransParent_Text.Name = "TransParent_Text";
            this.TransParent_Text.Size = new System.Drawing.Size(27, 13);
            this.TransParent_Text.TabIndex = 4;
            this.TransParent_Text.Text = "80%";
            // 
            // CloseOverlayWhenMouseMoved
            // 
            this.CloseOverlayWhenMouseMoved.AutoSize = true;
            this.CloseOverlayWhenMouseMoved.Location = new System.Drawing.Point(20, 55);
            this.CloseOverlayWhenMouseMoved.Name = "CloseOverlayWhenMouseMoved";
            this.CloseOverlayWhenMouseMoved.Size = new System.Drawing.Size(194, 17);
            this.CloseOverlayWhenMouseMoved.TabIndex = 6;
            this.CloseOverlayWhenMouseMoved.TabStop = false;
            this.CloseOverlayWhenMouseMoved.Text = "Close Overlay When Mouse Moved";
            this.CloseOverlayWhenMouseMoved.UseVisualStyleBackColor = true;
            this.CloseOverlayWhenMouseMoved.CheckedChanged += new System.EventHandler(this.CloseOverlayWhenMouseMoved_CheckedChanged);
            // 
            // TransParent_Bar
            // 
            this.TransParent_Bar.Location = new System.Drawing.Point(8, 29);
            this.TransParent_Bar.Maximum = 100;
            this.TransParent_Bar.Name = "TransParent_Bar";
            this.TransParent_Bar.Size = new System.Drawing.Size(201, 45);
            this.TransParent_Bar.TabIndex = 3;
            this.TransParent_Bar.TabStop = false;
            this.TransParent_Bar.Value = 80;
            this.TransParent_Bar.Scroll += new System.EventHandler(this.TransParent_Bar_Scroll);
            // 
            // HideOverlay_Desc2
            // 
            this.HideOverlay_Desc2.AutoSize = true;
            this.HideOverlay_Desc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOverlay_Desc2.ForeColor = System.Drawing.Color.Red;
            this.HideOverlay_Desc2.Location = new System.Drawing.Point(29, 39);
            this.HideOverlay_Desc2.Name = "HideOverlay_Desc2";
            this.HideOverlay_Desc2.Size = new System.Drawing.Size(212, 15);
            this.HideOverlay_Desc2.TabIndex = 0;
            this.HideOverlay_Desc2.Text = "※ Tab, Esc Keys are fixed to use";
            // 
            // TransParent_Desc
            // 
            this.TransParent_Desc.AutoSize = true;
            this.TransParent_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TransParent_Desc.Location = new System.Drawing.Point(18, 13);
            this.TransParent_Desc.Name = "TransParent_Desc";
            this.TransParent_Desc.Size = new System.Drawing.Size(104, 15);
            this.TransParent_Desc.TabIndex = 0;
            this.TransParent_Desc.Text = "Control Opacity";
            // 
            // HideOverlay_Button
            // 
            this.HideOverlay_Button.Location = new System.Drawing.Point(136, 9);
            this.HideOverlay_Button.Name = "HideOverlay_Button";
            this.HideOverlay_Button.Size = new System.Drawing.Size(105, 25);
            this.HideOverlay_Button.TabIndex = 1;
            this.HideOverlay_Button.TabStop = false;
            this.HideOverlay_Button.Text = "F10";
            this.HideOverlay_Button.UseVisualStyleBackColor = true;
            this.HideOverlay_Button.Click += new System.EventHandler(this.Overlay_Button_Click);
            // 
            // HideOverlay_Desc
            // 
            this.HideOverlay_Desc.AutoSize = true;
            this.HideOverlay_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOverlay_Desc.Location = new System.Drawing.Point(15, 14);
            this.HideOverlay_Desc.Name = "HideOverlay_Desc";
            this.HideOverlay_Desc.Size = new System.Drawing.Size(115, 15);
            this.HideOverlay_Desc.TabIndex = 0;
            this.HideOverlay_Desc.Text = "Hide Overlay Key";
            // 
            // CheckUpdate
            // 
            this.CheckUpdate.Location = new System.Drawing.Point(3, 3);
            this.CheckUpdate.Name = "CheckUpdate";
            this.CheckUpdate.Size = new System.Drawing.Size(99, 25);
            this.CheckUpdate.TabIndex = 5;
            this.CheckUpdate.TabStop = false;
            this.CheckUpdate.Text = "CheckUpdate";
            this.CheckUpdate.UseVisualStyleBackColor = true;
            this.CheckUpdate.Click += new System.EventHandler(this.CheckUpdate_Click);
            // 
            // Github
            // 
            this.Github.Location = new System.Drawing.Point(417, 4);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(94, 25);
            this.Github.TabIndex = 5;
            this.Github.TabStop = false;
            this.Github.Text = "Github";
            this.Github.UseVisualStyleBackColor = true;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // TarkovMarket
            // 
            this.TarkovMarket.Location = new System.Drawing.Point(219, 4);
            this.TarkovMarket.Name = "TarkovMarket";
            this.TarkovMarket.Size = new System.Drawing.Size(94, 25);
            this.TarkovMarket.TabIndex = 5;
            this.TarkovMarket.TabStop = false;
            this.TarkovMarket.Text = "Tarkov Market";
            this.TarkovMarket.UseVisualStyleBackColor = true;
            this.TarkovMarket.Click += new System.EventHandler(this.TarkovMarket_Click);
            // 
            // TarkovWiki
            // 
            this.TarkovWiki.Location = new System.Drawing.Point(318, 4);
            this.TarkovWiki.Name = "TarkovWiki";
            this.TarkovWiki.Size = new System.Drawing.Size(94, 25);
            this.TarkovWiki.TabIndex = 5;
            this.TarkovWiki.TabStop = false;
            this.TarkovWiki.Text = "Tarkov Wiki";
            this.TarkovWiki.UseVisualStyleBackColor = true;
            this.TarkovWiki.Click += new System.EventHandler(this.TarkovWiki_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TarkovTracker_button);
            this.panel4.Controls.Add(this.Tarkov_Dev);
            this.panel4.Controls.Add(this.Github);
            this.panel4.Controls.Add(this.DataProvidedBy);
            this.panel4.Controls.Add(this.TarkovWiki);
            this.panel4.Controls.Add(this.Tarkov_Official);
            this.panel4.Controls.Add(this.TarkovMarket);
            this.panel4.Location = new System.Drawing.Point(10, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 66);
            this.panel4.TabIndex = 7;
            // 
            // Tarkov_Dev
            // 
            this.Tarkov_Dev.Location = new System.Drawing.Point(119, 35);
            this.Tarkov_Dev.Name = "Tarkov_Dev";
            this.Tarkov_Dev.Size = new System.Drawing.Size(94, 25);
            this.Tarkov_Dev.TabIndex = 7;
            this.Tarkov_Dev.TabStop = false;
            this.Tarkov_Dev.Text = "Tarkov Dev";
            this.Tarkov_Dev.UseVisualStyleBackColor = true;
            this.Tarkov_Dev.Click += new System.EventHandler(this.Tarkov_Dev_Click);
            // 
            // DataProvidedBy
            // 
            this.DataProvidedBy.AutoSize = true;
            this.DataProvidedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DataProvidedBy.Location = new System.Drawing.Point(0, 8);
            this.DataProvidedBy.Name = "DataProvidedBy";
            this.DataProvidedBy.Size = new System.Drawing.Size(116, 15);
            this.DataProvidedBy.TabIndex = 6;
            this.DataProvidedBy.Text = "Data Provided By";
            // 
            // Tarkov_Official
            // 
            this.Tarkov_Official.Location = new System.Drawing.Point(119, 4);
            this.Tarkov_Official.Name = "Tarkov_Official";
            this.Tarkov_Official.Size = new System.Drawing.Size(94, 25);
            this.Tarkov_Official.TabIndex = 5;
            this.Tarkov_Official.TabStop = false;
            this.Tarkov_Official.Text = "Tarkov Official";
            this.Tarkov_Official.UseVisualStyleBackColor = true;
            this.Tarkov_Official.Click += new System.EventHandler(this.Tarkov_Official_Click);
            // 
            // MinimizetoTrayWhenStartup
            // 
            this.MinimizetoTrayWhenStartup.AutoSize = true;
            this.MinimizetoTrayWhenStartup.Location = new System.Drawing.Point(225, 415);
            this.MinimizetoTrayWhenStartup.Name = "MinimizetoTrayWhenStartup";
            this.MinimizetoTrayWhenStartup.Size = new System.Drawing.Size(154, 17);
            this.MinimizetoTrayWhenStartup.TabIndex = 6;
            this.MinimizetoTrayWhenStartup.TabStop = false;
            this.MinimizetoTrayWhenStartup.Text = "Minimize to Tray on Startup";
            this.MinimizetoTrayWhenStartup.UseVisualStyleBackColor = true;
            this.MinimizetoTrayWhenStartup.CheckedChanged += new System.EventHandler(this.MinimizetoTrayWhenStartup_CheckedChanged);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(105, 9);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 9;
            this.Version.Text = "Version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TarkovPriceViewer.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CloseOverlayWhenMouseMoved);
            this.panel2.Controls.Add(this.HideOverlay_Desc);
            this.panel2.Controls.Add(this.HideOverlay_Button);
            this.panel2.Controls.Add(this.HideOverlay_Desc2);
            this.panel2.Location = new System.Drawing.Point(271, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 81);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TransParent_Text);
            this.panel3.Controls.Add(this.TransParent_Desc);
            this.panel3.Controls.Add(this.TransParent_Bar);
            this.panel3.Location = new System.Drawing.Point(10, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 55);
            this.panel3.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Version);
            this.panel5.Controls.Add(this.CheckUpdate);
            this.panel5.Location = new System.Drawing.Point(13, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 30);
            this.panel5.TabIndex = 13;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(458, 410);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(63, 25);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CompareOverlay_Desc);
            this.panel6.Controls.Add(this.CompareOverlay_Button);
            this.panel6.Controls.Add(this.CompareOverlay_Desc2);
            this.panel6.Location = new System.Drawing.Point(271, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 66);
            this.panel6.TabIndex = 14;
            // 
            // CompareOverlay_Desc
            // 
            this.CompareOverlay_Desc.AutoSize = true;
            this.CompareOverlay_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CompareOverlay_Desc.Location = new System.Drawing.Point(15, 13);
            this.CompareOverlay_Desc.Name = "CompareOverlay_Desc";
            this.CompareOverlay_Desc.Size = new System.Drawing.Size(143, 15);
            this.CompareOverlay_Desc.TabIndex = 0;
            this.CompareOverlay_Desc.Text = "Compare Overlay Key";
            // 
            // CompareOverlay_Button
            // 
            this.CompareOverlay_Button.Location = new System.Drawing.Point(164, 9);
            this.CompareOverlay_Button.Name = "CompareOverlay_Button";
            this.CompareOverlay_Button.Size = new System.Drawing.Size(77, 25);
            this.CompareOverlay_Button.TabIndex = 1;
            this.CompareOverlay_Button.TabStop = false;
            this.CompareOverlay_Button.Text = "F8";
            this.CompareOverlay_Button.UseVisualStyleBackColor = true;
            this.CompareOverlay_Button.Click += new System.EventHandler(this.Overlay_Button_Click);
            // 
            // CompareOverlay_Desc2
            // 
            this.CompareOverlay_Desc2.AutoSize = true;
            this.CompareOverlay_Desc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CompareOverlay_Desc2.ForeColor = System.Drawing.Color.Red;
            this.CompareOverlay_Desc2.Location = new System.Drawing.Point(29, 36);
            this.CompareOverlay_Desc2.Name = "CompareOverlay_Desc2";
            this.CompareOverlay_Desc2.Size = new System.Drawing.Size(97, 15);
            this.CompareOverlay_Desc2.TabIndex = 0;
            this.CompareOverlay_Desc2.Text = "※ Experiential";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.RandomItem);
            this.panel7.Controls.Add(this.ForFunRandom_Desc);
            this.panel7.Location = new System.Drawing.Point(10, 289);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 55);
            this.panel7.TabIndex = 15;
            // 
            // RandomItem
            // 
            this.RandomItem.AutoSize = true;
            this.RandomItem.Location = new System.Drawing.Point(27, 29);
            this.RandomItem.Name = "RandomItem";
            this.RandomItem.Size = new System.Drawing.Size(146, 17);
            this.RandomItem.TabIndex = 6;
            this.RandomItem.TabStop = false;
            this.RandomItem.Text = "Show Random Item Price";
            this.RandomItem.UseVisualStyleBackColor = true;
            this.RandomItem.CheckedChanged += new System.EventHandler(this.RandomItem_CheckedChanged);
            // 
            // ForFunRandom_Desc
            // 
            this.ForFunRandom_Desc.AutoSize = true;
            this.ForFunRandom_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForFunRandom_Desc.Location = new System.Drawing.Point(18, 10);
            this.ForFunRandom_Desc.Name = "ForFunRandom_Desc";
            this.ForFunRandom_Desc.Size = new System.Drawing.Size(154, 15);
            this.ForFunRandom_Desc.TabIndex = 0;
            this.ForFunRandom_Desc.Text = "For Fun! Random Item!";
            // 
            // check_idle_time
            // 
            this.check_idle_time.Interval = 60000;
            this.check_idle_time.Tick += new System.EventHandler(this.check_idle_time_Tick);
            // 
            // refresh_b
            // 
            this.refresh_b.Location = new System.Drawing.Point(388, 410);
            this.refresh_b.Name = "refresh_b";
            this.refresh_b.Size = new System.Drawing.Size(64, 25);
            this.refresh_b.TabIndex = 16;
            this.refresh_b.Text = "Apply";
            this.refresh_b.UseVisualStyleBackColor = true;
            this.refresh_b.Click += new System.EventHandler(this.refresh_b_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.checkBox1);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.tarkovTrackerApiKey_textbox);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(271, 305);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(254, 74);
            this.panel8.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use TarkovTracker.io?";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // tarkovTrackerApiKey_textbox
            // 
            this.tarkovTrackerApiKey_textbox.Location = new System.Drawing.Point(78, 30);
            this.tarkovTrackerApiKey_textbox.Name = "tarkovTrackerApiKey_textbox";
            this.tarkovTrackerApiKey_textbox.Size = new System.Drawing.Size(163, 20);
            this.tarkovTrackerApiKey_textbox.TabIndex = 2;
            this.tarkovTrackerApiKey_textbox.MouseHover += new System.EventHandler(this.tarkovTrackerApiKey_textbox_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Key:";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.TabStop = false;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // TarkovTracker_button
            // 
            this.TarkovTracker_button.Location = new System.Drawing.Point(219, 35);
            this.TarkovTracker_button.Name = "TarkovTracker_button";
            this.TarkovTracker_button.Size = new System.Drawing.Size(94, 25);
            this.TarkovTracker_button.TabIndex = 8;
            this.TarkovTracker_button.TabStop = false;
            this.TarkovTracker_button.Text = "Tarkov Tracker";
            this.TarkovTracker_button.UseVisualStyleBackColor = true;
            this.TarkovTracker_button.Click += new System.EventHandler(this.TarkovTracker_button_Click);
            // 
            // hideoutUpgrades_checkBox
            // 
            this.hideoutUpgrades_checkBox.AutoSize = true;
            this.hideoutUpgrades_checkBox.Location = new System.Drawing.Point(8, 109);
            this.hideoutUpgrades_checkBox.Name = "hideoutUpgrades_checkBox";
            this.hideoutUpgrades_checkBox.Size = new System.Drawing.Size(112, 17);
            this.hideoutUpgrades_checkBox.TabIndex = 8;
            this.hideoutUpgrades_checkBox.TabStop = false;
            this.hideoutUpgrades_checkBox.Text = "Hideout Upgrades";
            this.hideoutUpgrades_checkBox.UseVisualStyleBackColor = true;
            this.hideoutUpgrades_checkBox.CheckedChanged += new System.EventHandler(this.hideoutUpgrades_checkBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 445);
            this.Controls.Add(this.week_price_box);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.refresh_b);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.MinimizetoTrayWhenStartup);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TarkovPriceViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_load);
            this.TrayMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransParent_Bar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayshow;
        private System.Windows.Forms.ToolStripMenuItem trayexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ShowOverlay_Desc;
        private System.Windows.Forms.Button CheckUpdate;
        private System.Windows.Forms.Button ShowOverlay_Button;
        private System.Windows.Forms.Button HideOverlay_Button;
        private System.Windows.Forms.Label HideOverlay_Desc;
        private System.Windows.Forms.Label TransParent_Desc;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Button TarkovMarket;
        private System.Windows.Forms.Button TarkovWiki;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DataProvidedBy;
        private System.Windows.Forms.CheckBox MinimizetoTrayWhenStartup;
        private System.Windows.Forms.CheckBox CloseOverlayWhenMouseMoved;
        private System.Windows.Forms.Label HideOverlay_Desc2;
        private System.Windows.Forms.TrackBar TransParent_Bar;
        private System.Windows.Forms.Label TransParent_Text;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox last_price_box;
        private System.Windows.Forms.CheckBox week_price_box;
        private System.Windows.Forms.CheckBox day_price_box;
        private System.Windows.Forms.CheckBox buy_from_trader_box;
        private System.Windows.Forms.CheckBox sell_to_trader_box;
        private System.Windows.Forms.Button Tarkov_Official;
        private System.Windows.Forms.CheckBox needs_box;
        private System.Windows.Forms.CheckBox barters_and_crafts_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label CompareOverlay_Desc;
        private System.Windows.Forms.Button CompareOverlay_Button;
        private System.Windows.Forms.Label CompareOverlay_Desc2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox RandomItem;
        private System.Windows.Forms.Label ForFunRandom_Desc;
        private System.Windows.Forms.Timer check_idle_time;
        private System.Windows.Forms.Button refresh_b;
        private System.Windows.Forms.Button Tarkov_Dev;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tarkovTrackerApiKey_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip TarkovTrackerAPI_tooltip;
        private System.Windows.Forms.Button TarkovTracker_button;
        private System.Windows.Forms.CheckBox hideoutUpgrades_checkBox;
    }
}

