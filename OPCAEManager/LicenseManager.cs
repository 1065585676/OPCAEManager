using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CShapTest
{
    public partial class LicenseManager : Form
    {
        public LicenseManager()
        {
            InitializeComponent();
        }

        private void OKLicense_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./Config/License.config", licenseContent.Text.Trim());
            MessageBox.Show("已写入Licens序列号：" + licenseContent.Text.Trim(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
