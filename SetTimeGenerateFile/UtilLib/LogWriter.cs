using System.Diagnostics;

namespace UtilLib
{
    public static class LogWriter
    {
        private static FileInfo LogFile { get; set; }
        private static string TimeLogStr { get { return DateTime.Now.ToString("[yy.MM.dd H:mm:ss]"); } }
        private static string ProgramName { get { return Process.GetCurrentProcess().ProcessName; } }

        static LogWriter()
        {
            string logFolderPath = Directory.GetCurrentDirectory() + @"\LOG";
            if (!Directory.Exists(logFolderPath))
                Directory.CreateDirectory(logFolderPath);

            LogFile = new FileInfo(logFolderPath + @"\" + DateTime.Now.ToString("yyyyMMdd") + ".log");
            if (!LogFile.Exists)
                LogFile.Create();
        }

        public static void Log(string str)
        {
            using StreamWriter sw = new(LogFile.FullName, true);
            sw.WriteLine(TimeLogStr + ProgramName + ":" + str);
            sw.Close();
        }
    }
}
