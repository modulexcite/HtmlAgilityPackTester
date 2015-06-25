using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTMLLive
{
    public partial class frmNewProject : Form
    {
        public frmNewProject()
        {
            InitializeComponent();

            //rbUseAuctionID.CheckedChanged += new EventHandler(UseType_CheckedChanged);
            //rbUseAuctionURL.CheckedChanged += new EventHandler(UseType_CheckedChanged);
        }

        private void TestURL()
        {
            try
            {
                Helper.HTMLCode = Helper.webresponse.GetResponse(txAuctionURL.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower() == "Unable to cast object of type 'System.Net.FileWebRequest' to type 'System.Net.HttpWebRequest'.".ToLower())
                {
                    MessageBox.Show("Unable to load local files.\r\n\r\nPlease click 'Cancel' button and load the local HTML or XML file in your favorite editor then copy the entire source and paste it in 'Original HTML'");
                }
            }
            Close();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            if (sender == btnOk)
            {
                TestURL();
            }
            else
            {
                Close();
            }
        }

        private void UseType_CheckedChanged(object sender, EventArgs e)
        {
            //if (sender == rbUseAuctionID)
            //{
            //    groupBox1.Enabled = rbUseAuctionID.Checked;
            //    groupBox2.Enabled = rbUseAuctionURL.Checked;
            //}
            //else if (sender == rbUseAuctionURL)
            //{
            //    groupBox1.Enabled = rbUseAuctionID.Checked;
            //    groupBox2.Enabled = rbUseAuctionURL.Checked;
            //}
        }

        private void frmNewProject_Load(object sender, EventArgs e)
        {

        }
    }
}
