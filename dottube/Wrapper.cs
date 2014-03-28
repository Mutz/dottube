//-----------------------------------------------------------------------
// <copyright file="Wrapper.cs" company="mutz.it">
//  Copyright (c) mutz.it. All Rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Dottube
{
    using System.Diagnostics;
    using System.Windows.Forms;
    using log4net;

    /// <summary>
    /// Class Wrapper
    /// </summary>
    class Wrapper
    {
        /// <summary>
        /// log4net init
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Update youtube-dl.exe
        /// </summary>
        public static void UpdateExe()
        {
            string result = YoutubeDl("--update", null);
            MessageBox.Show(result);
        }

        /// <summary>
        /// Calls youtube-dl.exe with the Parameters defined by <paramref name="strParam"/> on the <paramref name="strURL"/>
        /// </summary>
        /// <param name="strParam">Paramters defined by youtube-dl.exe</param>
        /// <param name="strURL">the Streaming Service URL</param>
        /// <returns>Console Output of youtube-dl.exe</returns>
        public static string YoutubeDl(string strParam, string strURL)
        {
            Process youtubedl = new Process();
            youtubedl.StartInfo.CreateNoWindow = true;         // Do not create a Window
            youtubedl.StartInfo.UseShellExecute = false;
            youtubedl.StartInfo.RedirectStandardOutput = true;  // Redirect the StandardOutput
            youtubedl.StartInfo.FileName = "youtube-dl.exe";
            youtubedl.StartInfo.Arguments = strParam + " " + strURL;
            log.Debug(youtubedl.StartInfo.Arguments.ToString());
            youtubedl.Start();

            string strOutput = youtubedl.StandardOutput.ReadToEnd();
            youtubedl.WaitForExit();
            log.Debug(strOutput);
            return strOutput;
        }
    }
}
