using SetTimeGenerateFile2.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;
using UtilLibrary.File;

namespace SetTimeGenerateFile2_Back
{
    internal class Program
    {
        private static string FolderPath { get; set; }
        private static int TimerTick { get; set; }

        /// <summary>
        /// Main 매소드
        /// </summary>
        private static void Main()
        {
            // 중복 실행시 종료
            if (IsExistProcess(Process.GetCurrentProcess().ProcessName))
                return;

            // Config파일을 읽습니다.
            ReadConfig("Config.ini");
            // FolderPath가 없으면 종료
            if (FolderPath.Equals(""))
                return;

            // 10초마다 OnTimedEvent를 실행합니다.
            System.Timers.Timer timer = new System.Timers.Timer(1000 * TimerTick);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;

            while (true) { }
        }

        /// <summary>
        /// 프로그램 중복실행 확인
        /// </summary>
        /// <param name="processName"></param>
        /// <returns></returns>
        private static bool IsExistProcess(string processName)
        {
            Process[] process = Process.GetProcesses();
            int cnt = 0;

            foreach (var p in process)
            {
                if (p.ProcessName == processName)
                    cnt++;
                if (cnt > 1)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 수행할 작업
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            List<DataInfo> dataInfos = ControlDataInfo.LoadDataInfo();

            foreach (DataInfo info in dataInfos)
                if (info.IsWork == false && DateTime.Now.Ticks >= info.WorkTime)
                {
                    info.IsWork = true;
                    File.WriteAllText(FolderPath + "/" + info.FileName, info.Content);
                    ControlDataInfo.SaveDataInfo(info);
                }
            
        }

        /// <summary>
        /// Config파일을 읽습니다.
        /// </summary>
        /// <param name="filename"></param>
        private static void ReadConfig(string filename)
        {
            IniFile ini = new IniFile();
            ini.Load(filename);

            FolderPath = ini["Project_Config"]["FolderDirectory"].GetString();
            TimerTick = ini["Project_Config"]["TimerTick"].ToInt(10);
        }

    }
}