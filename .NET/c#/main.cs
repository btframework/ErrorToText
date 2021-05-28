using System;
using System.Net;
using System.Windows.Forms;

using wclCommon;

namespace ErrorToText
{
    public partial class fmMain : Form
    {
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
            Boolean Res;
            String Framework;
            String Category;
            String Constant;
            String Description;

            String ErrStr = edErrorValue.Text;
            if (ErrStr.IndexOf("0x") == 0)
                Err = Convert.ToInt32(ErrStr, 16);
            else
                Err = Convert.ToInt32(ErrStr, 10);

            if (cbUseLocalFile.Checked)
            {
                Res = wclHelpers.GetErrorInfo("..\\..\\..\\..\\errors.xml", Err, out Framework, out Category,
                 out Constant, out Description);
            }
            else
            {
                Res = wclHelpers.GetErrorInfo(Err, out Framework, out Category, out Constant,
                    out Description);
            }

            if (Res)
            {
                lbInfo.Items.Add("Error code: 0x" + Err.ToString("X8"));
                lbInfo.Items.Add("  Framework: " + Framework);
                lbInfo.Items.Add("  Category: " + Category);
                lbInfo.Items.Add("  Constant: " + Constant);
                lbInfo.Items.Add("  Description: " + Description);
            }
            else
                MessageBox.Show("wclGetErrorInfo failed");
        }
    }
}
