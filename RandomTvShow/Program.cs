using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTvShow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = new LoggingConfiguration();
            var fileTarget = new FileTarget("ErrorLog")
            {
                FileName = "${basedir}/log.txt",
                Layout = @"${longdate} ${level} ${message} ${exception}"
            };
            config.AddTarget(fileTarget);
            config.AddRuleForOneLevel(LogLevel.Error, fileTarget);
            LogManager.Configuration = config;

            Exception fatalError;
            do
            {
                fatalError = RunAndCatchFatalErrors();
            }
            while (fatalError != null);
        }

        static Exception RunAndCatchFatalErrors()
        {
            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                LogManager.GetLogger("RandomTvShow").Error(ex);
                return ex;
            }

            return null;
        }
    }
}
