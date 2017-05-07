using Bash.Remote.GitHub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteInfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bascCmd = string.Format("git branch -r");
            string a=BashCallDLL.GetGitRpoInfo(bascCmd);
            MessageBox.Show(a);
        }
    }
}
