//-----------------------------------------------------------------------
// <copyright file="Wrapper.cs" company="mutz.it">
//  Copyright (c) mutz.it. All Rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Dottube
{
    using log4net;
    using System.Diagnostics;
    using System.Windows.Forms;

    /// <summary>
    /// Class Wrapper
    /// </summary>
    class Wrapper
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void UpdateExe()
        {
            string result = YoutubeDl("--update", null);
            MessageBox.Show(result);
        }

        public static string YoutubeDl(string strParam, string strURL)
        {
            Process youtubedl = new Process();
            youtubedl.StartInfo.CreateNoWindow = true;         // Do not create a Window
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
