using System.Diagnostics;
using UtilLibrary.File;

namespace SetTimeGenerateFile2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            LogWriter.Log("PROGRAM START");

            Process.Start(Application.StartupPath + "/08-SetTimeGenerateFile2_Back.exe");

            ApplicationConfiguration.Initialize();
            Application.Run(new RegistForm());
        }
    }
}