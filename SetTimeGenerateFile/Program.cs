namespace SetTimeGenerateFile
{
    internal static class Program
    {
        #pragma warning disable CS8618 // 생성자를 종료할 때 null을 허용하지 않는 필드에 null이 아닌 값을 포함해야 합니다. null 허용으로 선언해 보세요.
        public static List<TimeFileCeator> Creators { get; set; }
        #pragma warning restore CS8618

        /// <summary>
        /// Main
        /// </summary>
        [STAThread]
        static void Main()
        {
            Creators= new List<TimeFileCeator>();

            #region 1. MainForm 시작
            ApplicationConfiguration.Initialize();
            Form mainForm = new MainForm();
            Application.Run(mainForm);
            #endregion

            #region 2. MainForm 종료된 이후
            bool check = true;
            while (check)
            {
                Thread.Sleep(1000); // 1초마다 체크

                check = false;
                // List에 있는 모든 파일대기열을 확인하고
                // 해당 대기열에 있는 모든 파일 생성이 완료되면
                // while문이 종료된다.
                foreach (TimeFileCeator creator in Creators)
                    if (creator.isCreate == false)
                    {
                        creator.CreateFile();
                        check = true;
                    }
            }
            #endregion 
        }
    }
}