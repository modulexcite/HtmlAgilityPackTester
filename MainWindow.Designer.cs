namespace HTMLLive
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tsMainToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbNewProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.tsXPath = new System.Windows.Forms.ToolStripButton();
            this.tsRegEx = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripLabel();
            this.tsViewCode = new System.Windows.Forms.ToolStripButton();
            this.tsViewSplit = new System.Windows.Forms.ToolStripButton();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatusBar_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusBar_Status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Workspace = new System.Windows.Forms.SplitContainer();
            this.gbXPath = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTrimResults = new System.Windows.Forms.CheckBox();
            this.rbView_Text = new System.Windows.Forms.RadioButton();
            this.rbView_HTML = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNodeSel_SelectNode = new System.Windows.Forms.RadioButton();
            this.rbNodeSel_SingleNode = new System.Windows.Forms.RadioButton();
            this.txXPath = new System.Windows.Forms.TextBox();
            this.Preview = new System.Windows.Forms.SplitContainer();
            this.txPrevHTML = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsTitlePrev = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsViewInBrowser = new System.Windows.Forms.ToolStripButton();
            this.tsStopPageRefresh = new System.Windows.Forms.ToolStripButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txOrgHTML = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsTitleOrg = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReloadHTML = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMainToolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Workspace.Panel1.SuspendLayout();
            this.Workspace.Panel2.SuspendLayout();
            this.Workspace.SuspendLayout();
            this.gbXPath.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Preview.Panel1.SuspendLayout();
            this.Preview.Panel2.SuspendLayout();
            this.Preview.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainToolbar
            // 
            this.tsMainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewProject,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.tsXPath,
            this.tsRegEx,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.tsViewCode,
            this.tsViewSplit});
            this.tsMainToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsMainToolbar.Name = "tsMainToolbar";
            this.tsMainToolbar.Size = new System.Drawing.Size(784, 25);
            this.tsMainToolbar.TabIndex = 1;
            this.tsMainToolbar.Text = "toolStrip1";
            // 
            // tsbNewProject
            // 
            this.tsbNewProject.Image = global::HTMLLive.Properties.Resources.new16;
            this.tsbNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewProject.Name = "tsbNewProject";
            this.tsbNewProject.Size = new System.Drawing.Size(91, 22);
            this.tsbNewProject.Text = "New Project";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 22);
            this.toolStripButton1.Text = "Tests";
            // 
            // tsXPath
            // 
            this.tsXPath.Checked = true;
            this.tsXPath.CheckOnClick = true;
            this.tsXPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsXPath.Image = global::HTMLLive.Properties.Resources.xpath16;
            this.tsXPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXPath.Name = "tsXPath";
            this.tsXPath.Size = new System.Drawing.Size(58, 22);
            this.tsXPath.Text = "XPath";
            // 
            // tsRegEx
            // 
            this.tsRegEx.CheckOnClick = true;
            this.tsRegEx.Enabled = false;
            this.tsRegEx.Image = ((System.Drawing.Image)(resources.GetObject("tsRegEx.Image")));
            this.tsRegEx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRegEx.Name = "tsRegEx";
            this.tsRegEx.Size = new System.Drawing.Size(58, 22);
            this.tsRegEx.Text = "RegEx";
            this.tsRegEx.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton4.Text = "View";
            // 
            // tsViewCode
            // 
            this.tsViewCode.Checked = true;
            this.tsViewCode.CheckOnClick = true;
            this.tsViewCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsViewCode.Image = global::HTMLLive.Properties.Resources.code16;
            this.tsViewCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsViewCode.Name = "tsViewCode";
            this.tsViewCode.Size = new System.Drawing.Size(55, 22);
            this.tsViewCode.Text = "Code";
            // 
            // tsViewSplit
            // 
            this.tsViewSplit.CheckOnClick = true;
            this.tsViewSplit.Image = global::HTMLLive.Properties.Resources.viewlive16;
            this.tsViewSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsViewSplit.Name = "tsViewSplit";
            this.tsViewSplit.Size = new System.Drawing.Size(126, 22);
            this.tsViewSplit.Text = "Split (Live Preview)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tsStatus_Progress,
            this.tsStatusBar_Status,
            this.tsStatusBar_Status2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus_Progress
            // 
            this.tsStatus_Progress.Name = "tsStatus_Progress";
            this.tsStatus_Progress.Size = new System.Drawing.Size(100, 16);
            // 
            // tsStatusBar_Status
            // 
            this.tsStatusBar_Status.Name = "tsStatusBar_Status";
            this.tsStatusBar_Status.Size = new System.Drawing.Size(38, 17);
            this.tsStatusBar_Status.Text = "Idle ...";
            // 
            // tsStatusBar_Status2
            // 
            this.tsStatusBar_Status2.Name = "tsStatusBar_Status2";
            this.tsStatusBar_Status2.Size = new System.Drawing.Size(84, 17);
            this.tsStatusBar_Status2.Text = "Node Count: 0";
            // 
            // Workspace
            // 
            this.Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workspace.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Workspace.IsSplitterFixed = true;
            this.Workspace.Location = new System.Drawing.Point(0, 25);
            this.Workspace.Name = "Workspace";
            this.Workspace.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Workspace.Panel1
            // 
            this.Workspace.Panel1.Controls.Add(this.gbXPath);
            // 
            // Workspace.Panel2
            // 
            this.Workspace.Panel2.Controls.Add(this.Preview);
            this.Workspace.Size = new System.Drawing.Size(784, 515);
            this.Workspace.SplitterDistance = 121;
            this.Workspace.TabIndex = 1;
            // 
            // gbXPath
            // 
            this.gbXPath.Controls.Add(this.groupBox2);
            this.gbXPath.Controls.Add(this.groupBox1);
            this.gbXPath.Controls.Add(this.txXPath);
            this.gbXPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbXPath.Location = new System.Drawing.Point(0, 0);
            this.gbXPath.Name = "gbXPath";
            this.gbXPath.Size = new System.Drawing.Size(784, 121);
            this.gbXPath.TabIndex = 1;
            this.gbXPath.TabStop = false;
            this.gbXPath.Text = "Test XPath";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbTrimResults);
            this.groupBox2.Controls.Add(this.rbView_Text);
            this.groupBox2.Controls.Add(this.rbView_HTML);
            this.groupBox2.Location = new System.Drawing.Point(669, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result View";
            // 
            // cbTrimResults
            // 
            this.cbTrimResults.AutoSize = true;
            this.cbTrimResults.Checked = true;
            this.cbTrimResults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrimResults.Location = new System.Drawing.Point(18, 65);
            this.cbTrimResults.Name = "cbTrimResults";
            this.cbTrimResults.Size = new System.Drawing.Size(46, 17);
            this.cbTrimResults.TabIndex = 3;
            this.cbTrimResults.Text = "Trim";
            this.cbTrimResults.UseVisualStyleBackColor = true;
            // 
            // rbView_Text
            // 
            this.rbView_Text.AutoSize = true;
            this.rbView_Text.Location = new System.Drawing.Point(18, 42);
            this.rbView_Text.Name = "rbView_Text";
            this.rbView_Text.Size = new System.Drawing.Size(47, 17);
            this.rbView_Text.TabIndex = 2;
            this.rbView_Text.Text = "Text";
            this.rbView_Text.UseVisualStyleBackColor = true;
            // 
            // rbView_HTML
            // 
            this.rbView_HTML.AutoSize = true;
            this.rbView_HTML.Checked = true;
            this.rbView_HTML.Location = new System.Drawing.Point(18, 19);
            this.rbView_HTML.Name = "rbView_HTML";
            this.rbView_HTML.Size = new System.Drawing.Size(51, 17);
            this.rbView_HTML.TabIndex = 2;
            this.rbView_HTML.TabStop = true;
            this.rbView_HTML.Text = "HTML";
            this.rbView_HTML.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbNodeSel_SelectNode);
            this.groupBox1.Controls.Add(this.rbNodeSel_SingleNode);
            this.groupBox1.Location = new System.Drawing.Point(542, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node Selection Type";
            // 
            // rbNodeSel_SelectNode
            // 
            this.rbNodeSel_SelectNode.AutoSize = true;
            this.rbNodeSel_SelectNode.Location = new System.Drawing.Point(6, 42);
            this.rbNodeSel_SelectNode.Name = "rbNodeSel_SelectNode";
            this.rbNodeSel_SelectNode.Size = new System.Drawing.Size(82, 17);
            this.rbNodeSel_SelectNode.TabIndex = 2;
            this.rbNodeSel_SelectNode.Text = "Select Node";
            this.rbNodeSel_SelectNode.UseVisualStyleBackColor = true;
            // 
            // rbNodeSel_SingleNode
            // 
            this.rbNodeSel_SingleNode.AutoSize = true;
            this.rbNodeSel_SingleNode.Checked = true;
            this.rbNodeSel_SingleNode.Location = new System.Drawing.Point(6, 19);
            this.rbNodeSel_SingleNode.Name = "rbNodeSel_SingleNode";
            this.rbNodeSel_SingleNode.Size = new System.Drawing.Size(111, 17);
            this.rbNodeSel_SingleNode.TabIndex = 2;
            this.rbNodeSel_SingleNode.TabStop = true;
            this.rbNodeSel_SingleNode.Text = "Select Singe Node";
            this.rbNodeSel_SingleNode.UseVisualStyleBackColor = true;
            // 
            // txXPath
            // 
            this.txXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txXPath.Location = new System.Drawing.Point(12, 19);
            this.txXPath.Multiline = true;
            this.txXPath.Name = "txXPath";
            this.txXPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txXPath.Size = new System.Drawing.Size(524, 96);
            this.txXPath.TabIndex = 5;
            // 
            // Preview
            // 
            this.Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview.Location = new System.Drawing.Point(0, 0);
            this.Preview.Name = "Preview";
            this.Preview.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Preview.Panel1
            // 
            this.Preview.Panel1.Controls.Add(this.txPrevHTML);
            this.Preview.Panel1.Controls.Add(this.toolStrip3);
            this.Preview.Panel1.Controls.Add(this.webBrowser);
            // 
            // Preview.Panel2
            // 
            this.Preview.Panel2.Controls.Add(this.txOrgHTML);
            this.Preview.Panel2.Controls.Add(this.label2);
            this.Preview.Panel2.Controls.Add(this.toolStrip2);
            this.Preview.Size = new System.Drawing.Size(784, 390);
            this.Preview.SplitterDistance = 188;
            this.Preview.TabIndex = 0;
            // 
            // txPrevHTML
            // 
            this.txPrevHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPrevHTML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPrevHTML.Font = new System.Drawing.Font("Courier New", 8F);
            this.txPrevHTML.Location = new System.Drawing.Point(0, 28);
            this.txPrevHTML.MaxLength = 1000000;
            this.txPrevHTML.Multiline = true;
            this.txPrevHTML.Name = "txPrevHTML";
            this.txPrevHTML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txPrevHTML.Size = new System.Drawing.Size(784, 157);
            this.txPrevHTML.TabIndex = 3;
            this.txPrevHTML.WordWrap = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTitlePrev,
            this.toolStripSeparator2,
            this.tsViewInBrowser,
            this.tsStopPageRefresh});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(784, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsTitlePrev
            // 
            this.tsTitlePrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTitlePrev.Image = ((System.Drawing.Image)(resources.GetObject("tsTitlePrev.Image")));
            this.tsTitlePrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTitlePrev.Name = "tsTitlePrev";
            this.tsTitlePrev.Size = new System.Drawing.Size(48, 22);
            this.tsTitlePrev.Text = "Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsViewInBrowser
            // 
            this.tsViewInBrowser.Image = global::HTMLLive.Properties.Resources.viewindefault16;
            this.tsViewInBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsViewInBrowser.Name = "tsViewInBrowser";
            this.tsViewInBrowser.Size = new System.Drawing.Size(150, 22);
            this.tsViewInBrowser.Text = "View in default browser";
            this.tsViewInBrowser.Click += new System.EventHandler(this.tsViewInBrowser_Click);
            // 
            // tsStopPageRefresh
            // 
            this.tsStopPageRefresh.CheckOnClick = true;
            this.tsStopPageRefresh.Image = global::HTMLLive.Properties.Resources.stop16;
            this.tsStopPageRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStopPageRefresh.Name = "tsStopPageRefresh";
            this.tsStopPageRefresh.Size = new System.Drawing.Size(156, 22);
            this.tsStopPageRefresh.Text = "Stop refreshing the page";
            this.tsStopPageRefresh.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 28);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(784, 157);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // txOrgHTML
            // 
            this.txOrgHTML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txOrgHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txOrgHTML.Font = new System.Drawing.Font("Courier New", 8F);
            this.txOrgHTML.Location = new System.Drawing.Point(0, 38);
            this.txOrgHTML.MaxLength = 1000000;
            this.txOrgHTML.Multiline = true;
            this.txOrgHTML.Name = "txOrgHTML";
            this.txOrgHTML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txOrgHTML.Size = new System.Drawing.Size(784, 160);
            this.txOrgHTML.TabIndex = 0;
            this.txOrgHTML.WordWrap = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip: You can paste HTML codes here and click \"Load to HTMLDocument\"";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTitleOrg,
            this.toolStripButton3,
            this.tsReloadHTML});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsTitleOrg
            // 
            this.tsTitleOrg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTitleOrg.Image = ((System.Drawing.Image)(resources.GetObject("tsTitleOrg.Image")));
            this.tsTitleOrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTitleOrg.Name = "tsTitleOrg";
            this.tsTitleOrg.Size = new System.Drawing.Size(85, 22);
            this.tsTitleOrg.Text = "Original HTML";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsReloadHTML
            // 
            this.tsReloadHTML.Image = global::HTMLLive.Properties.Resources.reload16;
            this.tsReloadHTML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReloadHTML.Name = "tsReloadHTML";
            this.tsReloadHTML.Size = new System.Drawing.Size(159, 22);
            this.tsReloadHTML.Text = "Load to HTMLDocument";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel1.Text = "Pinoy Touch Tech";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Workspace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMainToolbar);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAP Testbed - Html Agility Pack XPath Tester";
            this.tsMainToolbar.ResumeLayout(false);
            this.tsMainToolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Workspace.Panel1.ResumeLayout(false);
            this.Workspace.Panel2.ResumeLayout(false);
            this.Workspace.ResumeLayout(false);
            this.gbXPath.ResumeLayout(false);
            this.gbXPath.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Preview.Panel1.ResumeLayout(false);
            this.Preview.Panel1.PerformLayout();
            this.Preview.Panel2.ResumeLayout(false);
            this.Preview.Panel2.PerformLayout();
            this.Preview.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainToolbar;
        private System.Windows.Forms.ToolStripButton tsbNewProject;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusBar_Status;
        private System.Windows.Forms.ToolStripProgressBar tsStatus_Progress;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusBar_Status2;
        private System.Windows.Forms.SplitContainer Workspace;
        private System.Windows.Forms.SplitContainer Preview;
        private System.Windows.Forms.TextBox txPrevHTML;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel tsTitlePrev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsViewInBrowser;
        private System.Windows.Forms.ToolStripButton tsStopPageRefresh;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsTitleOrg;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsReloadHTML;
        private System.Windows.Forms.TextBox txOrgHTML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsXPath;
        private System.Windows.Forms.ToolStripButton tsRegEx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsViewCode;
        private System.Windows.Forms.ToolStripButton tsViewSplit;
        private System.Windows.Forms.GroupBox gbXPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbView_Text;
        private System.Windows.Forms.RadioButton rbView_HTML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNodeSel_SelectNode;
        private System.Windows.Forms.RadioButton rbNodeSel_SingleNode;
        private System.Windows.Forms.TextBox txXPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTrimResults;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

