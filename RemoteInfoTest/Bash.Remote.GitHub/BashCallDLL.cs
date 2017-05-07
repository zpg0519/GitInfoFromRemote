using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bash.Remote.GitHub
{
    public class BashCallDLL
    {
        public static string GetGitRpoInfo(string str)
        {
            try
            {
                string result = string.Empty;
                StartProcess sp = new StartProcess();
                sp._Process.Start();
                //sp._Process.StandardInput.WriteLine(str);
                return AfterGet(sp._Process.StandardOutput);
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public static string AfterGet(StreamReader sr)
        {
            string result = sr.ReadToEnd();
            return result;
        }
    }
}
