namespace UtilLib
{
    public static class ReadIni
    {
        #region static field
        public static string FolderPath { get; private set; }
        public static int TimerTick { get; private set; }
        public static Dictionary<string, Dictionary<string, string>> ContentMap { get; private set; }
        #endregion

        #region constructor
        static ReadIni()
        {
            #region ini 파일 체크
            string iniFilename = @".\config.ini";
            if (!File.Exists(iniFilename)) throw new FileNotFoundException("ini파일을 찾을 수 없습니다.\r\n 파일명:" + iniFilename);
            #endregion
            #region ini 내용 확인
            ContentMap = new();
            string[] iniContents = File.ReadAllLines(iniFilename);
            string tmpTitle = string.Empty;
            for (int i = 0; i < iniContents.Length; i++)
            {
                string content = iniContents[i].Trim();
                if (content.Length == 0) continue; // 내용이 없으면
                if (content.IndexOf('#') == 0) continue; // 해당 내용이 주석이면
                if (content.Contains('[') && content.Contains(']')) // [] 안의 내용 (title)
                {
                    tmpTitle = content.Substring(content.IndexOf('['), content.IndexOf(']'));
                    ContentMap.Add(tmpTitle, new());
                    continue;
                }
                if (content.Contains('=')) // key와 value
                {
                    if (tmpTitle == string.Empty) continue;
                    string key = content.Substring(0, content.IndexOf("="));
                    string value = content.Substring(content.IndexOf("="));
                    ContentMap[tmpTitle].Add(key, value);
                    continue;
                }
            }
            #endregion
            #region static Field 반영
            FolderPath = ContentMap["SETTING"]["FolderPath"];
            if (FolderPath == null || FolderPath.Length == 0) throw new NotImplementedException("ini파일에 FolderPath에 대한 내용이 없습니다.");
            string timerTickStr = ContentMap["SETTING"]["TimerTick"];
            if (timerTickStr == null || timerTickStr.Length == 0) throw new NotImplementedException("ini파일에 TimerTick에 대한 내용이 없습니다.");
            TimerTick = int.Parse(timerTickStr);
            #endregion
        }
        #endregion
    }
}
