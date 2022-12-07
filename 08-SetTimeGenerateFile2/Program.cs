using System.Diagnostics;

namespace SetTimeGenerateFile2
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Process.Start(Application.StartupPath + "/08-SetTimeGenerateFile2_Back.exe");

            ApplicationConfiguration.Initialize();
            Application.Run(new RegistForm());
        }
    }
}