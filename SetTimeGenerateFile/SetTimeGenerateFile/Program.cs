using System.Diagnostics;
using UtilLib;

namespace SetTimeGenerateFile
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogWriter.Log("PROGRAM START");

            Process.Start(Application.StartupPath + @"\GenerateFile.exe");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistForm());
        }
    }
}