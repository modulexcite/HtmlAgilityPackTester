using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace HTMLLive
{
    public partial class MainWindow : Form
    {
        public string OrgHTMLBkup = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            InitializeControls();
            InitializeControlEvents();
        }

        public void InitializeControls()
        {
            timer1.Interval = 5000;
            timer1.Stop();
            timer1.Enabled = false;

            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;



            this.Text = "HAP Testbed v" + Application.ProductVersion + " - Html Agility Pack XPath Tester";
        }

        public void InitializeControlEvents()
        {
            this.Shown += new EventHandler(MainWindow_Shown);

            this.webBrowser.StatusTextChanged += new EventHandler(webBrowser_StatusTextChanged);
            this.webBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser_ProgressChanged);

            this.tsbNewProject.Click += new System.EventHandler(this.tsbNewProject_Click);
            this.tsReloadHTML.Click += new System.EventHandler(this.tsReloadHTML_Click);
            this.txXPath.TextChanged += new EventHandler(txXPath_TextChanged);
            this.txXPath.KeyDown += new KeyEventHandler(txXPath_KeyDown);
            this.txOrgHTML.KeyDown += new KeyEventHandler(txOrgHTML_KeyDown);
            this.txPrevHTML.KeyDown += txPrevHTML_KeyDown;
            this.txOrgHTML.TextChanged += txOrgHTML_TextChanged;

            this.rbNodeSel_SingleNode.CheckedChanged += new EventHandler(NodeSelection_CheckedChanged);
            this.rbNodeSel_SelectNode.CheckedChanged += new EventHandler(NodeSelection_CheckedChanged);

            this.rbView_Text.CheckedChanged += new EventHandler(ResultView_CheckedChanged);
            this.rbView_HTML.CheckedChanged += new EventHandler(ResultView_CheckedChanged);
            
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.tsViewCode.Click += new EventHandler(tsViewCode_Click);
            this.tsViewSplit.Click += new EventHandler(tsViewSplit_Click);
            
            this.tsStopPageRefresh.Click += new System.EventHandler(this.tsStopPageRefresh_Click);
            this.tsViewInBrowser.Click += new EventHandler(tsViewInBrowser_Click);

            this.cbTrimResults.CheckedChanged += cbTrimResults_CheckedChanged;
        }
        
        #region control events

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            tsStatus_Progress.Maximum = int.Parse(e.MaximumProgress.ToString());
            tsStatus_Progress.Value = int.Parse(e.CurrentProgress.ToString());
        }

        private void webBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            tsStatusBar_Status.Text = webBrowser.StatusText.Replace("file:///C:/", string.Empty);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            NewProject(null);
        }

        private void tsbNewProject_Click(object sender, EventArgs e)
        {
            NewProject(sender);
        }

        private void tsReloadHTML_Click(object sender, EventArgs e)
        {
            Helper.htmldoc.LoadHtml(txOrgHTML.Text);
            Helper.HTMLCode = txOrgHTML.Text;

            //MessageBox.Show("Done");
        }

        private void txXPath_TextChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        void txXPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txXPath.SelectAll();
            }
        }

        void txPrevHTML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txPrevHTML.SelectAll();
            }
        }

        void txOrgHTML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txOrgHTML.SelectAll();
            }
        }

        void txOrgHTML_TextChanged(object sender, EventArgs e)
        {
            tsReloadHTML_Click(this, null);
        }

        private void NodeSelection_CheckedChanged(object sender, EventArgs e)
        {
            txXPath_TextChanged(txXPath, e);
        }

        private void ResultView_CheckedChanged(object sender, EventArgs e)
        {
            txXPath_TextChanged(txXPath, e);
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("dumping xpath result");
                Helper.Save(Helper.defaultSavePath, txOrgHTML.Text);

                System.Diagnostics.Debug.WriteLine("rendering");
                webBrowser.Navigate(Helper.defaultSavePath);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error at bgWorker_DoWork: " + ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("stoping main thread timer");
            timer1.Stop();

            System.Diagnostics.Debug.WriteLine("running background async worker");
            bgWorker.RunWorkerAsync();

            System.Diagnostics.Debug.WriteLine("starting main thread timer");
            timer1.Start();
        }

        private void tsViewCode_Click(object sender, EventArgs e)
        {
            tsViewCode.Checked = true;
            tsViewSplit.Checked = false;
            tsStopPageRefresh.Visible = false;

            txPrevHTML.Visible = true;
            txOrgHTML.Visible = true;
            webBrowser.Visible = false;
            tsTitleOrg.Text = "Orginal HTML";
            timer1.Enabled = false;
            timer1.Stop();
            bgWorker.CancelAsync();

            DoWork();
        }

        private void tsViewSplit_Click(object sender, EventArgs e)
        {
            tsViewCode.Checked = false;
            tsViewSplit.Checked = true;
            tsStopPageRefresh.Visible = true;

            txPrevHTML.Visible = false;
            txOrgHTML.Visible = true;
            webBrowser.Visible = true;
            tsTitleOrg.Text = "Preview HTML";

            if (tsStopPageRefresh.Checked == false)
            {
                timer1.Enabled = true;
                timer1.Start();
            }

            DoWork();
        }

        private void tsStopPageRefresh_Click(object sender, EventArgs e)
        {
            if (!tsStopPageRefresh.Checked) { timer1.Start(); tsStopPageRefresh.Image = Properties.Resources.stop16; }
            if (tsStopPageRefresh.Checked) { timer1.Stop(); tsStopPageRefresh.Image = Properties.Resources.go16; }
        }

        private void tsViewInBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                bgWorker.CancelAsync();

                if (tsViewCode.Checked)
                {
                    Helper.Save(Helper.defaultSavePath, txPrevHTML.Text);
                }
                else if (tsViewSplit.Checked)
                {
                    Helper.Save(Helper.defaultSavePath, txOrgHTML.Text);
                }

                Process p = new Process();
                p.StartInfo.FileName = Helper.defaultSavePath;
                p.Start();
            }
            catch
            {

            }
        }

        void cbTrimResults_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        #endregion

        #region ud methods

        private void NewProject(object sender)
        {
            DialogResult dr;

            if (sender == tsbNewProject)
            {
                dr = MessageBox.Show("Do you want to create new project window", "HTMLLive", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process p = new Process();
                    System.Diagnostics.ProcessStartInfo psi = new ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = Application.ExecutablePath;
                    p.StartInfo = psi;
                    p.Start();
                }
                else if (dr == DialogResult.No)
                {
                    frmNewProject frm = new frmNewProject();
                    frm.ShowDialog();

                    string title = string.Empty;

                    if (Helper.HTMLCode != string.Empty)
                    {
                        //title = string.Format("Project: ({0}) - {1}", string.Empty, string.Empty);
                        txOrgHTML.Text = Helper.HTMLCode;

                        //tabControl1.TabPages[0].Text = title;
                        //this.Text = "HTMLLive - " + title;

                        tsReloadHTML_Click(tsReloadHTML, null);
                    }
                    else
                    {
                        //title = "Project *";
                    }
                }
            }
            else if (sender == null) // when window just loaded .. check form Shown event
            {
                frmNewProject frm = new frmNewProject();
                frm.ShowDialog();

                string title = string.Empty;

                if (Helper.HTMLCode != string.Empty)
                {
                    //title = string.Format("Project: ({0}) - {1}", string.Empty, string.Empty);
                    txOrgHTML.Text = Helper.HTMLCode;

                    //tabControl1.TabPages[0].Text = title;
                    //this.Text = "HTMLLive - " + title;

                    tsReloadHTML_Click(tsReloadHTML, null);
                }
                else
                {
                    MessageBox.Show("You can paste your HTML codes on 'Original HTML'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DoWork()
        {
            Debug.WriteLine(tsXPath.Text);
            if (tsViewCode.Checked)
            {
                txOrgHTML.Text = Helper.HTMLCode;
                txPrevHTML.Text = ShowXPathHTMLResult();
            }
            else if (tsViewSplit.Checked)
            {
                if (txXPath.Text == string.Empty)
                {
                    txXPath.Text = "/";
                }

                txOrgHTML.Text = ShowXPathHTMLResult();
            }
        }

        private string ShowXPathHTMLResult()
        {
            string ret = string.Empty;

            try
            {
                if (rbNodeSel_SingleNode.Checked)
                {
                    Helper.htmlnode = Helper.htmldoc.DocumentNode.SelectSingleNode(txXPath.Text);
                    if (Helper.htmlnode != null)
                    {
                        tsStatusBar_Status2.Text = string.Empty;
                        if (rbView_HTML.Checked)
                        {
                            ret = Helper.htmlnode.InnerHtml;
                        }
                        else if (rbView_Text.Checked)
                        {
                            ret = Helper.htmlnode.InnerText;
                        }
                    }
                    else
                    {
                        ret = "NULL";
                    }
                }
                else if (rbNodeSel_SelectNode.Checked)
                {
                    Helper.htmlnodecol = Helper.htmldoc.DocumentNode.SelectNodes(txXPath.Text);
                    if (Helper.htmlnodecol != null)
                    {
                        string result = string.Empty;
                        int cnt = 0;
                        tsStatusBar_Status2.Text = "Node Count: " + Helper.htmlnodecol.Count.ToString();

                        foreach (HtmlAgilityPack.HtmlNode thisNode in Helper.htmlnodecol)
                        {
                            string html = string.Empty;

                            if (rbView_HTML.Checked)
                            {
                                html = thisNode.InnerHtml;
                            }
                            else if (rbView_Text.Checked)
                            {
                                html = thisNode.InnerText;
                            }

                            cnt++;
                            result += string.Format("Node Result: {0}\r\n-----------------\r\n{1}\r\n-----------------\r\n\r\n", cnt, html);
                        }

                        ret = result;
                    }
                    else
                    {
                        ret = "NULL";
                    }
                }
            }
            catch (Exception ex)
            {
                ret = "Error in your expression:\r\n" + ex.Message;
            }

            if (cbTrimResults.Checked) ret = ret.Trim();

            return ret;
        }

        #endregion

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("http:\\jaysonsblog.azurewebsites.net");
        }
    }
}
