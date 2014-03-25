using System.Diagnostics;
using log4net;

namespace dottube
{
    class Wrapper
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string YoutubeDl(string strParam, string strURL)
        {
            Process youtubedl = new Process();
            youtubedl.StartInfo.CreateNoWindow = false;         // Do not create a Window
            youtubedl.StartInfo.UseShellExecute = false;
            youtubedl.StartInfo.RedirectStandardOutput = true;  // Redirect the StandardOutput
            youtubedl.StartInfo.FileName = "youtube-dl.exe";
            youtubedl.StartInfo.Arguments = strParam +" "+ strURL;
            log.Debug(youtubedl.StartInfo.Arguments.ToString());
            youtubedl.Start();

            string strOutput = youtubedl.StandardOutput.ReadToEnd();
            youtubedl.WaitForExit();
            log.Debug(strOutput);
            return strOutput;
        }
    }
}
