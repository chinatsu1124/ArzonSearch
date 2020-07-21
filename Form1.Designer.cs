namespace ArzonSearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbxNum = new System.Windows.Forms.ListBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.pbxPost = new System.Windows.Forms.PictureBox();
            this.pgbKeyword = new System.Windows.Forms.ProgressBar();
            this.tbxActor = new System.Windows.Forms.TextBox();
            this.tbxDirector = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxMaker = new System.Windows.Forms.TextBox();
            this.lblMakerlabel = new System.Windows.Forms.Label();
            this.tbxMakerLabel = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxSeries = new System.Windows.Forms.TextBox();
            this.tbxRelease = new System.Windows.Forms.TextBox();
            this.tbxRuntime = new System.Windows.Forms.TextBox();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.tbxTag = new System.Windows.Forms.TextBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.tbxIntroduction = new System.Windows.Forms.TextBox();
            this.lblProxyTip = new System.Windows.Forms.Label();
            this.gbxMagnet = new System.Windows.Forms.GroupBox();
            this.fpnMagnet = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMagnetTitle = new System.Windows.Forms.Label();
            this.tbxMegnetTitle = new System.Windows.Forms.TextBox();
            this.lblMagnetSize = new System.Windows.Forms.Label();
            this.tbxMagnetSize = new System.Windows.Forms.TextBox();
            this.lblMagnetSeeders = new System.Windows.Forms.Label();
            this.tbxMagnetSeeders = new System.Windows.Forms.TextBox();
            this.lblMagnetLeechers = new System.Windows.Forms.Label();
            this.tbxMagnetLeechers = new System.Windows.Forms.TextBox();
            this.lblMagnetCompletes = new System.Windows.Forms.Label();
            this.tbxMagnetCompletes = new System.Windows.Forms.TextBox();
            this.lblMagnetDate = new System.Windows.Forms.Label();
            this.tbxMagnetDate = new System.Windows.Forms.TextBox();
            this.lblMagnetDownload = new System.Windows.Forms.Label();
            this.tbxMagnetDownload = new System.Windows.Forms.TextBox();
            this.lbxMagnet = new System.Windows.Forms.ListBox();
            this.btnMagnet = new System.Windows.Forms.Button();
            this.cbxFBI = new System.Windows.Forms.CheckBox();
            this.gbxNum = new System.Windows.Forms.GroupBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.fpnSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnimeSearch = new System.Windows.Forms.Button();
            this.btnNFO = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tpnInfo = new System.Windows.Forms.TableLayoutPanel();
            this.gbxPoster = new System.Windows.Forms.GroupBox();
            this.panPoster = new System.Windows.Forms.Panel();
            this.panNum = new System.Windows.Forms.Panel();
            this.panSearch = new System.Windows.Forms.Panel();
            this.panInfo = new System.Windows.Forms.Panel();
            this.panMagnet = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPost)).BeginInit();
            this.gbxMagnet.SuspendLayout();
            this.fpnMagnet.SuspendLayout();
            this.gbxNum.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.fpnSearch.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.tpnInfo.SuspendLayout();
            this.gbxPoster.SuspendLayout();
            this.panPoster.SuspendLayout();
            this.panNum.SuspendLayout();
            this.panSearch.SuspendLayout();
            this.panInfo.SuspendLayout();
            this.panMagnet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvSearch
            // 
            this.btnAvSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAvSearch.Location = new System.Drawing.Point(281, 3);
            this.btnAvSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAvSearch.Name = "btnAvSearch";
            this.btnAvSearch.Size = new System.Drawing.Size(94, 29);
            this.btnAvSearch.TabIndex = 0;
            this.btnAvSearch.Text = "有码搜索";
            this.btnAvSearch.UseVisualStyleBackColor = true;
            this.btnAvSearch.Click += new System.EventHandler(this.btnSearch_ClickAsync);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Location = new System.Drawing.Point(136, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // lbxNum
            // 
            this.lbxNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxNum.FormattingEnabled = true;
            this.lbxNum.ItemHeight = 20;
            this.lbxNum.Location = new System.Drawing.Point(10, 28);
            this.lbxNum.Name = "lbxNum";
            this.lbxNum.Size = new System.Drawing.Size(158, 504);
            this.lbxNum.TabIndex = 3;
            this.lbxNum.SelectedIndexChanged += new System.EventHandler(this.lbxOut_SelectedIndexChanged);
            // 
            // lblDirector
            // 
            this.lblDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(167, 67);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(39, 20);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "导演";
            // 
            // lblActor
            // 
            this.lblActor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(10, 67);
            this.lblActor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(39, 20);
            this.lblActor.TabIndex = 5;
            this.lblActor.Text = "演员";
            // 
            // lblMaker
            // 
            this.lblMaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(10, 127);
            this.lblMaker.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(39, 20);
            this.lblMaker.TabIndex = 6;
            this.lblMaker.Text = "公司";
            // 
            // lblRelease
            // 
            this.lblRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(167, 187);
            this.lblRelease.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(54, 20);
            this.lblRelease.TabIndex = 7;
            this.lblRelease.Text = "发售日";
            // 
            // lblRuntime
            // 
            this.lblRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(10, 247);
            this.lblRuntime.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(39, 20);
            this.lblRuntime.TabIndex = 8;
            this.lblRuntime.Text = "片长";
            // 
            // lblNum
            // 
            this.lblNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(167, 247);
            this.lblNum.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(39, 20);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "番号";
            // 
            // pbxPost
            // 
            this.pbxPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPost.Location = new System.Drawing.Point(10, 30);
            this.pbxPost.Name = "pbxPost";
            this.pbxPost.Size = new System.Drawing.Size(835, 502);
            this.pbxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPost.TabIndex = 10;
            this.pbxPost.TabStop = false;
            // 
            // pgbKeyword
            // 
            this.pgbKeyword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pgbKeyword.Location = new System.Drawing.Point(754, 3);
            this.pgbKeyword.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pgbKeyword.Name = "pgbKeyword";
            this.pgbKeyword.Size = new System.Drawing.Size(125, 29);
            this.pgbKeyword.TabIndex = 11;
            // 
            // tbxActor
            // 
            this.tbxActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxActor.Location = new System.Drawing.Point(10, 93);
            this.tbxActor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxActor.Name = "tbxActor";
            this.tbxActor.Size = new System.Drawing.Size(137, 27);
            this.tbxActor.TabIndex = 12;
            // 
            // tbxDirector
            // 
            this.tbxDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDirector.Location = new System.Drawing.Point(167, 93);
            this.tbxDirector.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxDirector.Name = "tbxDirector";
            this.tbxDirector.Size = new System.Drawing.Size(137, 27);
            this.tbxDirector.TabIndex = 13;
            // 
            // tbxTitle
            // 
            this.tpnInfo.SetColumnSpan(this.tbxTitle, 2);
            this.tbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTitle.Location = new System.Drawing.Point(10, 33);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(294, 27);
            this.tbxTitle.TabIndex = 99;
            // 
            // tbxMaker
            // 
            this.tbxMaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMaker.Location = new System.Drawing.Point(10, 153);
            this.tbxMaker.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxMaker.Name = "tbxMaker";
            this.tbxMaker.Size = new System.Drawing.Size(137, 27);
            this.tbxMaker.TabIndex = 14;
            // 
            // lblMakerlabel
            // 
            this.lblMakerlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMakerlabel.AutoSize = true;
            this.lblMakerlabel.Location = new System.Drawing.Point(167, 127);
            this.lblMakerlabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblMakerlabel.Name = "lblMakerlabel";
            this.lblMakerlabel.Size = new System.Drawing.Size(39, 20);
            this.lblMakerlabel.TabIndex = 15;
            this.lblMakerlabel.Text = "厂牌";
            // 
            // tbxMakerLabel
            // 
            this.tbxMakerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMakerLabel.Location = new System.Drawing.Point(167, 153);
            this.tbxMakerLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxMakerLabel.Name = "tbxMakerLabel";
            this.tbxMakerLabel.Size = new System.Drawing.Size(137, 27);
            this.tbxMakerLabel.TabIndex = 16;
            // 
            // lblSeries
            // 
            this.lblSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(10, 187);
            this.lblSeries.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(39, 20);
            this.lblSeries.TabIndex = 17;
            this.lblSeries.Text = "系列";
            // 
            // lblTag
            // 
            this.lblTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(10, 307);
            this.lblTag.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(39, 20);
            this.lblTag.TabIndex = 18;
            this.lblTag.Text = "标签";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 20);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "标题";
            // 
            // tbxSeries
            // 
            this.tbxSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSeries.Location = new System.Drawing.Point(10, 213);
            this.tbxSeries.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxSeries.Name = "tbxSeries";
            this.tbxSeries.Size = new System.Drawing.Size(137, 27);
            this.tbxSeries.TabIndex = 19;
            // 
            // tbxRelease
            // 
            this.tbxRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRelease.Location = new System.Drawing.Point(167, 213);
            this.tbxRelease.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxRelease.Name = "tbxRelease";
            this.tbxRelease.Size = new System.Drawing.Size(137, 27);
            this.tbxRelease.TabIndex = 20;
            // 
            // tbxRuntime
            // 
            this.tbxRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRuntime.Location = new System.Drawing.Point(10, 273);
            this.tbxRuntime.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxRuntime.Name = "tbxRuntime";
            this.tbxRuntime.Size = new System.Drawing.Size(137, 27);
            this.tbxRuntime.TabIndex = 21;
            // 
            // tbxNum
            // 
            this.tbxNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNum.Location = new System.Drawing.Point(167, 273);
            this.tbxNum.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(137, 27);
            this.tbxNum.TabIndex = 22;
            // 
            // tbxTag
            // 
            this.tpnInfo.SetColumnSpan(this.tbxTag, 2);
            this.tbxTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTag.Location = new System.Drawing.Point(10, 333);
            this.tbxTag.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxTag.Name = "tbxTag";
            this.tbxTag.Size = new System.Drawing.Size(294, 27);
            this.tbxTag.TabIndex = 23;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(10, 367);
            this.lblIntroduction.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(39, 20);
            this.lblIntroduction.TabIndex = 25;
            this.lblIntroduction.Text = "简介";
            // 
            // tbxIntroduction
            // 
            this.tpnInfo.SetColumnSpan(this.tbxIntroduction, 2);
            this.tbxIntroduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxIntroduction.Location = new System.Drawing.Point(10, 393);
            this.tbxIntroduction.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbxIntroduction.Multiline = true;
            this.tbxIntroduction.Name = "tbxIntroduction";
            this.tbxIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxIntroduction.Size = new System.Drawing.Size(294, 106);
            this.tbxIntroduction.TabIndex = 26;
            // 
            // lblProxyTip
            // 
            this.lblProxyTip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProxyTip.AutoSize = true;
            this.lblProxyTip.Location = new System.Drawing.Point(899, 8);
            this.lblProxyTip.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblProxyTip.Name = "lblProxyTip";
            this.lblProxyTip.Size = new System.Drawing.Size(423, 20);
            this.lblProxyTip.TabIndex = 27;
            this.lblProxyTip.Text = "建议使用HTTP代理以提高获取速度，磁力获取必须要使用代理";
            // 
            // gbxMagnet
            // 
            this.gbxMagnet.Controls.Add(this.fpnMagnet);
            this.gbxMagnet.Controls.Add(this.lbxMagnet);
            this.gbxMagnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMagnet.Location = new System.Drawing.Point(10, 10);
            this.gbxMagnet.Margin = new System.Windows.Forms.Padding(10);
            this.gbxMagnet.Name = "gbxMagnet";
            this.gbxMagnet.Padding = new System.Windows.Forms.Padding(10);
            this.gbxMagnet.Size = new System.Drawing.Size(1407, 205);
            this.gbxMagnet.TabIndex = 28;
            this.gbxMagnet.TabStop = false;
            this.gbxMagnet.Text = "磁力搜索";
            // 
            // fpnMagnet
            // 
            this.fpnMagnet.Controls.Add(this.lblMagnetTitle);
            this.fpnMagnet.Controls.Add(this.tbxMegnetTitle);
            this.fpnMagnet.Controls.Add(this.lblMagnetSize);
            this.fpnMagnet.Controls.Add(this.tbxMagnetSize);
            this.fpnMagnet.Controls.Add(this.lblMagnetSeeders);
            this.fpnMagnet.Controls.Add(this.tbxMagnetSeeders);
            this.fpnMagnet.Controls.Add(this.lblMagnetLeechers);
            this.fpnMagnet.Controls.Add(this.tbxMagnetLeechers);
            this.fpnMagnet.Controls.Add(this.lblMagnetCompletes);
            this.fpnMagnet.Controls.Add(this.tbxMagnetCompletes);
            this.fpnMagnet.Controls.Add(this.lblMagnetDate);
            this.fpnMagnet.Controls.Add(this.tbxMagnetDate);
            this.fpnMagnet.Controls.Add(this.lblMagnetDownload);
            this.fpnMagnet.Controls.Add(this.tbxMagnetDownload);
            this.fpnMagnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnMagnet.Location = new System.Drawing.Point(170, 30);
            this.fpnMagnet.Name = "fpnMagnet";
            this.fpnMagnet.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fpnMagnet.Size = new System.Drawing.Size(1227, 165);
            this.fpnMagnet.TabIndex = 14;
            // 
            // lblMagnetTitle
            // 
            this.lblMagnetTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetTitle.AutoSize = true;
            this.lblMagnetTitle.Location = new System.Drawing.Point(13, 6);
            this.lblMagnetTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetTitle.Name = "lblMagnetTitle";
            this.lblMagnetTitle.Size = new System.Drawing.Size(39, 20);
            this.lblMagnetTitle.TabIndex = 0;
            this.lblMagnetTitle.Text = "标题";
            // 
            // tbxMegnetTitle
            // 
            this.tbxMegnetTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMegnetTitle.Location = new System.Drawing.Point(58, 3);
            this.tbxMegnetTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMegnetTitle.Name = "tbxMegnetTitle";
            this.tbxMegnetTitle.Size = new System.Drawing.Size(1151, 27);
            this.tbxMegnetTitle.TabIndex = 1;
            // 
            // lblMagnetSize
            // 
            this.lblMagnetSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetSize.AutoSize = true;
            this.lblMagnetSize.Location = new System.Drawing.Point(13, 69);
            this.lblMagnetSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetSize.Name = "lblMagnetSize";
            this.lblMagnetSize.Size = new System.Drawing.Size(39, 20);
            this.lblMagnetSize.TabIndex = 2;
            this.lblMagnetSize.Text = "大小";
            // 
            // tbxMagnetSize
            // 
            this.tbxMagnetSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMagnetSize.Location = new System.Drawing.Point(58, 66);
            this.tbxMagnetSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMagnetSize.Name = "tbxMagnetSize";
            this.tbxMagnetSize.Size = new System.Drawing.Size(125, 27);
            this.tbxMagnetSize.TabIndex = 3;
            // 
            // lblMagnetSeeders
            // 
            this.lblMagnetSeeders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetSeeders.AutoSize = true;
            this.lblMagnetSeeders.Location = new System.Drawing.Point(189, 69);
            this.lblMagnetSeeders.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetSeeders.Name = "lblMagnetSeeders";
            this.lblMagnetSeeders.Size = new System.Drawing.Size(54, 20);
            this.lblMagnetSeeders.TabIndex = 4;
            this.lblMagnetSeeders.Text = "做种数";
            // 
            // tbxMagnetSeeders
            // 
            this.tbxMagnetSeeders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMagnetSeeders.Location = new System.Drawing.Point(249, 66);
            this.tbxMagnetSeeders.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMagnetSeeders.Name = "tbxMagnetSeeders";
            this.tbxMagnetSeeders.Size = new System.Drawing.Size(125, 27);
            this.tbxMagnetSeeders.TabIndex = 5;
            // 
            // lblMagnetLeechers
            // 
            this.lblMagnetLeechers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetLeechers.AutoSize = true;
            this.lblMagnetLeechers.Location = new System.Drawing.Point(380, 69);
            this.lblMagnetLeechers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetLeechers.Name = "lblMagnetLeechers";
            this.lblMagnetLeechers.Size = new System.Drawing.Size(54, 20);
            this.lblMagnetLeechers.TabIndex = 6;
            this.lblMagnetLeechers.Text = "下载数";
            // 
            // tbxMagnetLeechers
            // 
            this.tbxMagnetLeechers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMagnetLeechers.Location = new System.Drawing.Point(440, 66);
            this.tbxMagnetLeechers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMagnetLeechers.Name = "tbxMagnetLeechers";
            this.tbxMagnetLeechers.Size = new System.Drawing.Size(125, 27);
            this.tbxMagnetLeechers.TabIndex = 7;
            // 
            // lblMagnetCompletes
            // 
            this.lblMagnetCompletes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetCompletes.AutoSize = true;
            this.lblMagnetCompletes.Location = new System.Drawing.Point(571, 69);
            this.lblMagnetCompletes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetCompletes.Name = "lblMagnetCompletes";
            this.lblMagnetCompletes.Size = new System.Drawing.Size(84, 20);
            this.lblMagnetCompletes.TabIndex = 8;
            this.lblMagnetCompletes.Text = "下载完成数";
            // 
            // tbxMagnetCompletes
            // 
            this.tbxMagnetCompletes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMagnetCompletes.Location = new System.Drawing.Point(661, 66);
            this.tbxMagnetCompletes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMagnetCompletes.Name = "tbxMagnetCompletes";
            this.tbxMagnetCompletes.Size = new System.Drawing.Size(125, 27);
            this.tbxMagnetCompletes.TabIndex = 9;
            // 
            // lblMagnetDate
            // 
            this.lblMagnetDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetDate.AutoSize = true;
            this.lblMagnetDate.Location = new System.Drawing.Point(792, 69);
            this.lblMagnetDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetDate.Name = "lblMagnetDate";
            this.lblMagnetDate.Size = new System.Drawing.Size(69, 20);
            this.lblMagnetDate.TabIndex = 10;
            this.lblMagnetDate.Text = "上传日期";
            // 
            // tbxMagnetDate
            // 
            this.tbxMagnetDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMagnetDate.Location = new System.Drawing.Point(867, 66);
            this.tbxMagnetDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMagnetDate.Name = "tbxMagnetDate";
            this.tbxMagnetDate.Size = new System.Drawing.Size(342, 27);
            this.tbxMagnetDate.TabIndex = 11;
            // 
            // lblMagnetDownload
            // 
            this.lblMagnetDownload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagnetDownload.AutoSize = true;
            this.lblMagnetDownload.Location = new System.Drawing.Point(13, 132);
            this.lblMagnetDownload.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.lblMagnetDownload.Name = "lblMagnetDownload";
            this.lblMagnetDownload.Size = new System.Drawing.Size(39, 20);
            this.lblMagnetDownload.TabIndex = 12;
            this.lblMagnetDownload.Text = "磁链";
            // 
            // tbxMagnetDownload
            // 
            this.tbxMagnetDownload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMagnetDownload.Location = new System.Drawing.Point(58, 129);
            this.tbxMagnetDownload.Margin = new System.Windows.Forms.Padding(3, 3, 3, 33);
            this.tbxMagnetDownload.Name = "tbxMagnetDownload";
            this.tbxMagnetDownload.Size = new System.Drawing.Size(1151, 27);
            this.tbxMagnetDownload.TabIndex = 13;
            // 
            // lbxMagnet
            // 
            this.lbxMagnet.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbxMagnet.FormattingEnabled = true;
            this.lbxMagnet.ItemHeight = 20;
            this.lbxMagnet.Location = new System.Drawing.Point(10, 30);
            this.lbxMagnet.Name = "lbxMagnet";
            this.lbxMagnet.Size = new System.Drawing.Size(160, 165);
            this.lbxMagnet.TabIndex = 0;
            this.lbxMagnet.SelectedIndexChanged += new System.EventHandler(this.lbxMagnet_SelectedIndexChanged);
            // 
            // btnMagnet
            // 
            this.btnMagnet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMagnet.Location = new System.Drawing.Point(509, 3);
            this.btnMagnet.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnMagnet.Name = "btnMagnet";
            this.btnMagnet.Size = new System.Drawing.Size(94, 29);
            this.btnMagnet.TabIndex = 29;
            this.btnMagnet.Text = "磁力搜索";
            this.btnMagnet.UseVisualStyleBackColor = true;
            this.btnMagnet.Click += new System.EventHandler(this.btnMagnet_Click);
            // 
            // cbxFBI
            // 
            this.cbxFBI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFBI.AutoSize = true;
            this.cbxFBI.Checked = true;
            this.cbxFBI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFBI.Location = new System.Drawing.Point(10, 6);
            this.cbxFBI.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.cbxFBI.Name = "cbxFBI";
            this.cbxFBI.Size = new System.Drawing.Size(106, 24);
            this.cbxFBI.TabIndex = 30;
            this.cbxFBI.Text = "青少年模式";
            this.cbxFBI.UseVisualStyleBackColor = true;
            // 
            // gbxNum
            // 
            this.gbxNum.Controls.Add(this.lbxNum);
            this.gbxNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNum.Location = new System.Drawing.Point(10, 10);
            this.gbxNum.Name = "gbxNum";
            this.gbxNum.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.gbxNum.Size = new System.Drawing.Size(178, 542);
            this.gbxNum.TabIndex = 31;
            this.gbxNum.TabStop = false;
            this.gbxNum.Text = "番号";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.fpnSearch);
            this.gbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSearch.Location = new System.Drawing.Point(10, 10);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(10);
            this.gbxSearch.Size = new System.Drawing.Size(1407, 80);
            this.gbxSearch.TabIndex = 32;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "搜索";
            // 
            // fpnSearch
            // 
            this.fpnSearch.Controls.Add(this.cbxFBI);
            this.fpnSearch.Controls.Add(this.txtSearch);
            this.fpnSearch.Controls.Add(this.btnAvSearch);
            this.fpnSearch.Controls.Add(this.btnAnimeSearch);
            this.fpnSearch.Controls.Add(this.btnMagnet);
            this.fpnSearch.Controls.Add(this.btnNFO);
            this.fpnSearch.Controls.Add(this.pgbKeyword);
            this.fpnSearch.Controls.Add(this.lblProxyTip);
            this.fpnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnSearch.Location = new System.Drawing.Point(10, 30);
            this.fpnSearch.Name = "fpnSearch";
            this.fpnSearch.Size = new System.Drawing.Size(1387, 40);
            this.fpnSearch.TabIndex = 31;
            // 
            // btnAnimeSearch
            // 
            this.btnAnimeSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAnimeSearch.Location = new System.Drawing.Point(395, 3);
            this.btnAnimeSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAnimeSearch.Name = "btnAnimeSearch";
            this.btnAnimeSearch.Size = new System.Drawing.Size(94, 29);
            this.btnAnimeSearch.TabIndex = 31;
            this.btnAnimeSearch.Text = "动画搜索";
            this.btnAnimeSearch.UseVisualStyleBackColor = true;
            this.btnAnimeSearch.Click += new System.EventHandler(this.btnAnimeSearch_ClickAsync);
            // 
            // btnNFO
            // 
            this.btnNFO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNFO.AutoSize = true;
            this.btnNFO.Location = new System.Drawing.Point(623, 3);
            this.btnNFO.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnNFO.Name = "btnNFO";
            this.btnNFO.Size = new System.Drawing.Size(111, 30);
            this.btnNFO.TabIndex = 32;
            this.btnNFO.Text = "生成封面NFO";
            this.btnNFO.UseVisualStyleBackColor = true;
            this.btnNFO.Click += new System.EventHandler(this.btnNFO_Click);
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.tpnInfo);
            this.gbxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInfo.Location = new System.Drawing.Point(10, 10);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(10);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(10);
            this.gbxInfo.Size = new System.Drawing.Size(334, 542);
            this.gbxInfo.TabIndex = 33;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "信息";
            // 
            // tpnInfo
            // 
            this.tpnInfo.ColumnCount = 2;
            this.tpnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnInfo.Controls.Add(this.tbxTag, 0, 11);
            this.tpnInfo.Controls.Add(this.tbxNum, 1, 9);
            this.tpnInfo.Controls.Add(this.tbxRuntime, 0, 9);
            this.tpnInfo.Controls.Add(this.tbxRelease, 1, 7);
            this.tpnInfo.Controls.Add(this.tbxSeries, 0, 7);
            this.tpnInfo.Controls.Add(this.lblTag, 0, 10);
            this.tpnInfo.Controls.Add(this.lblTitle, 0, 0);
            this.tpnInfo.Controls.Add(this.lblSeries, 0, 6);
            this.tpnInfo.Controls.Add(this.tbxMakerLabel, 1, 5);
            this.tpnInfo.Controls.Add(this.lblMakerlabel, 1, 4);
            this.tpnInfo.Controls.Add(this.tbxMaker, 0, 5);
            this.tpnInfo.Controls.Add(this.tbxActor, 0, 3);
            this.tpnInfo.Controls.Add(this.lblMaker, 0, 4);
            this.tpnInfo.Controls.Add(this.lblDirector, 1, 2);
            this.tpnInfo.Controls.Add(this.tbxIntroduction, 0, 13);
            this.tpnInfo.Controls.Add(this.lblIntroduction, 0, 12);
            this.tpnInfo.Controls.Add(this.lblActor, 0, 2);
            this.tpnInfo.Controls.Add(this.tbxDirector, 1, 3);
            this.tpnInfo.Controls.Add(this.tbxTitle, 0, 1);
            this.tpnInfo.Controls.Add(this.lblNum, 1, 8);
            this.tpnInfo.Controls.Add(this.lblRelease, 1, 6);
            this.tpnInfo.Controls.Add(this.lblRuntime, 0, 8);
            this.tpnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnInfo.Location = new System.Drawing.Point(10, 30);
            this.tpnInfo.Name = "tpnInfo";
            this.tpnInfo.RowCount = 4;
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnInfo.Size = new System.Drawing.Size(314, 502);
            this.tpnInfo.TabIndex = 27;
            // 
            // gbxPoster
            // 
            this.gbxPoster.Controls.Add(this.pbxPost);
            this.gbxPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPoster.Location = new System.Drawing.Point(10, 10);
            this.gbxPoster.Name = "gbxPoster";
            this.gbxPoster.Padding = new System.Windows.Forms.Padding(10);
            this.gbxPoster.Size = new System.Drawing.Size(855, 542);
            this.gbxPoster.TabIndex = 34;
            this.gbxPoster.TabStop = false;
            this.gbxPoster.Text = "封面";
            // 
            // panPoster
            // 
            this.panPoster.Controls.Add(this.gbxPoster);
            this.panPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPoster.Location = new System.Drawing.Point(208, 110);
            this.panPoster.Name = "panPoster";
            this.panPoster.Padding = new System.Windows.Forms.Padding(10);
            this.panPoster.Size = new System.Drawing.Size(875, 562);
            this.panPoster.TabIndex = 35;
            // 
            // panNum
            // 
            this.panNum.Controls.Add(this.gbxNum);
            this.panNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panNum.Location = new System.Drawing.Point(10, 110);
            this.panNum.Name = "panNum";
            this.panNum.Padding = new System.Windows.Forms.Padding(10);
            this.panNum.Size = new System.Drawing.Size(198, 562);
            this.panNum.TabIndex = 36;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.gbxSearch);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(10, 10);
            this.panSearch.Name = "panSearch";
            this.panSearch.Padding = new System.Windows.Forms.Padding(10);
            this.panSearch.Size = new System.Drawing.Size(1427, 100);
            this.panSearch.TabIndex = 37;
            // 
            // panInfo
            // 
            this.panInfo.Controls.Add(this.gbxInfo);
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panInfo.Location = new System.Drawing.Point(1083, 110);
            this.panInfo.Name = "panInfo";
            this.panInfo.Padding = new System.Windows.Forms.Padding(10);
            this.panInfo.Size = new System.Drawing.Size(354, 562);
            this.panInfo.TabIndex = 38;
            // 
            // panMagnet
            // 
            this.panMagnet.Controls.Add(this.gbxMagnet);
            this.panMagnet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMagnet.Location = new System.Drawing.Point(10, 672);
            this.panMagnet.Name = "panMagnet";
            this.panMagnet.Padding = new System.Windows.Forms.Padding(10);
            this.panMagnet.Size = new System.Drawing.Size(1427, 225);
            this.panMagnet.TabIndex = 39;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(1447, 907);
            this.Controls.Add(this.panPoster);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.panNum);
            this.Controls.Add(this.panMagnet);
            this.Controls.Add(this.panSearch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1465, 954);
            this.MinimumSize = new System.Drawing.Size(1465, 954);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avsearch";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPost)).EndInit();
            this.gbxMagnet.ResumeLayout(false);
            this.fpnMagnet.ResumeLayout(false);
            this.fpnMagnet.PerformLayout();
            this.gbxNum.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.fpnSearch.ResumeLayout(false);
            this.fpnSearch.PerformLayout();
            this.gbxInfo.ResumeLayout(false);
            this.tpnInfo.ResumeLayout(false);
            this.tpnInfo.PerformLayout();
            this.gbxPoster.ResumeLayout(false);
            this.panPoster.ResumeLayout(false);
            this.panNum.ResumeLayout(false);
            this.panSearch.ResumeLayout(false);
            this.panInfo.ResumeLayout(false);
            this.panMagnet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbxNum;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.PictureBox pbxPost;
        private System.Windows.Forms.TextBox tbxActor;
        private System.Windows.Forms.TextBox tbxDirector;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxMaker;
        private System.Windows.Forms.Label lblMakerlabel;
        private System.Windows.Forms.TextBox tbxMakerLabel;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxSeries;
        private System.Windows.Forms.TextBox tbxRelease;
        private System.Windows.Forms.TextBox tbxRuntime;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.TextBox tbxTag;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.TextBox tbxIntroduction;
        private System.Windows.Forms.Label lblProxyTip;
        private System.Windows.Forms.GroupBox gbxMagnet;
        private System.Windows.Forms.ListBox lbxMagnet;
        private System.Windows.Forms.Button btnMagnet;
        private System.Windows.Forms.ProgressBar pgbKeyword;
        private System.Windows.Forms.Label lblMagnetSize;
        private System.Windows.Forms.Label lblMagnetTitle;
        private System.Windows.Forms.Label lblMagnetSeeders;
        private System.Windows.Forms.TextBox tbxMagnetCompletes;
        private System.Windows.Forms.TextBox tbxMagnetLeechers;
        private System.Windows.Forms.Label lblMagnetDate;
        private System.Windows.Forms.Label lblMagnetCompletes;
        private System.Windows.Forms.Label lblMagnetLeechers;
        private System.Windows.Forms.Label lblMagnetDownload;
        private System.Windows.Forms.TextBox tbxMagnetSeeders;
        private System.Windows.Forms.TextBox tbxMagnetSize;
        private System.Windows.Forms.TextBox tbxMegnetTitle;
        private System.Windows.Forms.TextBox tbxMagnetDownload;
        private System.Windows.Forms.TextBox tbxMagnetDate;
        private System.Windows.Forms.CheckBox cbxFBI;
        private System.Windows.Forms.GroupBox gbxNum;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.GroupBox gbxPoster;
        private System.Windows.Forms.Panel panPoster;
        private System.Windows.Forms.Panel panNum;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.Panel panMagnet;
        private System.Windows.Forms.FlowLayoutPanel fpnSearch;
        private System.Windows.Forms.FlowLayoutPanel fpnMagnet;
        private System.Windows.Forms.TableLayoutPanel tpnInfo;
        private System.Windows.Forms.Button btnAnimeSearch;
        private System.Windows.Forms.Button btnNFO;
    }
}



