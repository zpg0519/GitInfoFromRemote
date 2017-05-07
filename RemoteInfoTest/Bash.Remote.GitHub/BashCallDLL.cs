using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

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
                sp._Process.StandardInput.WriteLine(str);
                sp._Process.OutputDataReceived += AfterGet;
                return "11";


            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        public static void AfterGet(object sender, DataReceivedEventArgs e)
        {
            string result = string.Empty;
            if (e.Data!=null)
            result = e.Data;
        }
    }
}
