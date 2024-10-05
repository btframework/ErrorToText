using System;
using System.Net;
using System.Windows.Forms;

using wclCommon;

namespace ErrorToText
{
    public partial class fmMain : Form
    {
        private wclErrorInformation ErrorInfo = new wclErrorInformation();

        public fmMain()
        {
            // Allows to access errors.xml from our site.
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            InitializeComponent();
        }

        private void btGetErrorInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();

            Int32 Err;
            String ErrStr = edErrorValue.Text;
            if (ErrStr.IndexOf("0x") == 0)
                Err = Convert.ToInt32(ErrStr, 16);
            else
                Err = Convert.ToInt32(ErrStr, 10);

            String Path;
            if (cbUseLocalFile.Checked)
                Path = "..\\..\\..\\..\\errors.xml";
            else
                Path = "https://www.btframework.com/errors.xml";

            if (ErrorInfo.Open(Path))
            {
                wclErrorDetails Details = new wclErrorDetails();
                if (ErrorInfo.GetDetails(Err, ref Details))
                {
                    lbInfo.Items.Add("Error code: 0x" + Err.ToString("X8"));
                    lbInfo.Items.Add("  Framework: " + Details.Framework);
                    lbInfo.Items.Add("  Category: " + Details.Category);
                    lbInfo.Items.Add("  Constant: " + Details.Constant);
                    lbInfo.Items.Add("  Description: " + Details.Description);
                }
                else
                    lbInfo.Items.Add("Get error details failed");
                ErrorInfo.Close();
            }
            else
                MessageBox.Show("wclGetErrorInfo failed");
        }
    }
}
