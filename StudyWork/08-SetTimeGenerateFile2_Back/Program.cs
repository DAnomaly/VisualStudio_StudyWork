using SetTimeGenerateFile2.Data;
using System.Diagnostics;
using System.Timers;
using UtilLibrary.File;

namespace SetTimeGenerateFile2_Back
{
    internal class Program
    {
        #region 0. 클래스 필드
        /// <summary>
        /// Config 내용 : data 폴더 경로
        /// </summary>
        private static string FolderPath { get; set; }
        /// <summary>
        /// Config 내용 : 동작간격
        /// </summary>
        private static int TimerTick { get; set; }
        #endregion

        #region 1. Main 매소드
        /// <summary>
        /// Main 매소드
        /// </summary>
        private static void Main()
        {
            // 중복 실행시 종료
            if (IsExistProcess(Process.GetCurrentProcess().ProcessName))
                return;

            LogWriter.Log("PROGRAM START");

            // Config파일을 읽습니다.
            ReadConfig("Config.ini");
            // FolderPath가 없으면 종료
            if (FolderPath.Equals(""))
                return;

            // 정해진 시간이 지난 수행작업을 확인합니다.
            CheckPastWorks();

            // TimerTick초마다 OnTimedEvent를 실행합니다.
            System.Timers.Timer timer = new(1000 * TimerTick);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;

            while (true)
                Thread.Sleep(100000);

        }
        #endregion

        #region 2. (private) 동작 메소드
        /// <summary>
        /// 시간이 지난 수행작업 체크 후 업데이트
        /// </summary>
        private static void CheckPastWorks()
        {
            List<DataInfo> dataInfos = ControlDataInfo.LoadDataInfo();

            foreach (DataInfo info in dataInfos)
                if (info.IsStatus == ControlDataInfo.IsReady && DateTime.Now.Ticks >= info.WorkTime)
                {
                    info.IsStatus = ControlDataInfo.IsPast;
                    ControlDataInfo.SaveDataInfo(info);
                    LogWriter.Log("PAST FILE: " + info.FileName);
                }
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
                if (info.IsStatus == ControlDataInfo.IsReady && DateTime.Now.Ticks >= info.WorkTime)
                {
                    info.IsStatus = ControlDataInfo.IsWorked;
                    try
                    {
                        File.WriteAllText(FolderPath + "/" + info.FileName, info.Content);
                        ControlDataInfo.SaveDataInfo(info);
                        LogWriter.Log("REGIST FILE: " + info.FileName);
                    }
                    catch (Exception ex)
                    {
                        info.IsStatus = ControlDataInfo.IsError;
                        ControlDataInfo.SaveDataInfo(info);
                        LogWriter.Log("ERROR FILE: " + info.FileName + ", ExceptionMessage: " + ex.Message);
                    }
                }
        }

        /// <summary>
        /// Config파일을 읽습니다.
        /// </summary>
        /// <param name="filename"></param>
        private static void ReadConfig(string filename)
        {
            IniFile ini = new();
            ini.Load(filename);

            FolderPath = ini["Project_Config"]["FolderDirectory"].GetString();
            TimerTick = ini["Project_Config"]["TimerTick"].ToInt(10);
        }
        #endregion

    }
}