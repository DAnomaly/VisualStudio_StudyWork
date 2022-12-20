using ControlQueue;
using System.Diagnostics;
using System.Timers;
using UtilLib;
#region 중복실행 확인
Process[] processes = Process.GetProcesses();
int cnt = 0;
foreach (Process p in processes)
{
    if (p.ProcessName == Process.GetCurrentProcess().ProcessName)
        cnt++;
    if (cnt > 1)
        return;
}
#endregion
#region 지나간 대기열 취소
List<QueueVO> list = Control.SelectQueue();
foreach (QueueVO vo in list)
    if (Control.IsPossibleGenerate(vo))
    {
        vo.Cancel = QueueConfig.IsCanceled;
        Control.UpdateQueue(vo);
    }
#endregion
#region 작업 수행
#pragma warning disable CS8622 // 매개 변수 형식에서 참조 형식의 Null 허용 여부가 대상 대리자와 일치하지 않습니다(Null 허용 여부 특성 때문일 수 있음).
static void TimerEvent(object source, ElapsedEventArgs e)
{
    List<QueueVO> list = Control.SelectQueue();
    foreach (QueueVO vo in list)
        if (Control.IsPossibleGenerate(vo))
        {
            vo.IsGen = QueueConfig.IsGenerated;
            File.WriteAllText(ReadIni.FolderPath + "/" + vo.FileName, vo.Content);
            Control.UpdateQueue(vo);
        }
}
System.Timers.Timer timer = new(ReadIni.TimerTick);
timer.Elapsed += new ElapsedEventHandler(TimerEvent);
timer.Start();
#pragma warning restore CS8622 
#endregion
#region 종료방지
while (true)
    Thread.Sleep(100000);
#endregion