namespace SetTimeGenerateFile
{
    internal static class Program
    {
        #pragma warning disable CS8618 // �����ڸ� ������ �� null�� ������� �ʴ� �ʵ忡 null�� �ƴ� ���� �����ؾ� �մϴ�. null ������� ������ ������.
        public static List<TimeFileCeator> Creators { get; set; }
        #pragma warning restore CS8618

        /// <summary>
        /// Main
        /// </summary>
        [STAThread]
        static void Main()
        {
            Creators= new List<TimeFileCeator>();

            #region 1. MainForm ����
            ApplicationConfiguration.Initialize();
            Form mainForm = new MainForm();
            Application.Run(mainForm);
            #endregion

            #region 2. MainForm ����� ����
            bool check = true;
            while (check)
            {
                Thread.Sleep(1000); // 1�ʸ��� üũ

                check = false;
                // List�� �ִ� ��� ���ϴ�⿭�� Ȯ���ϰ�
                // �ش� ��⿭�� �ִ� ��� ���� ������ �Ϸ�Ǹ�
                // while���� ����ȴ�.
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