using System.Diagnostics;

namespace UtilLib
{
    public static class LogWriter
    {
        private static FileInfo LogFile
        {
            get
            {
                if (LogFolderPath != null && LogFolderPath.Length != 0)
                    return new FileInfo(LogFolderPath + @"\" + DateTime.Now.ToString("yyyyMMdd") + ".log");
                else
                    throw new NotImplementedException("LogFolderPath is null.");
            }
        }
        private static string TimeLogStr { get { return DateTime.Now.ToString("[yy.MM.dd H:mm:ss]"); } }
        private static string ProgramName { get { return Process.GetCurrentProcess().ProcessName; } }
        private static string LogFolderPath { get; set; }

        static LogWriter()
        {
            LogFolderPath = Directory.GetCurrentDirectory() + @"\LOG";
            if (!Directory.Exists(LogFolderPath))
                Directory.CreateDirectory(LogFolderPath);

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
