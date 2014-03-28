//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="mutz.it">
//  Copyright (c) mutz.it. All Rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Dottube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.XmlConfigurator.Configure();
            Application.Run(new formMainForm());
        }
    }
}
