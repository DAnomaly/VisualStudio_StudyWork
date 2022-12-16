using System.Xml.Serialization;

namespace SetTimeGenerateFile2.Data
{
    /// <summary>
    /// DataInfo객체를 저장, 불러오기, 삭제하는 클래스
    /// </summary>
    public static class ControlDataInfo
    {

        public static string IsReady { get { return "00"; } }
        public static string IsWorked { get { return "01"; } }
        public static string IsPast { get { return "09"; } }
        public static string IsError { get { return "99"; } }

        /// <summary>
        /// 클래스 파일 저장경로
        /// </summary>
        private static string GetClassFolderPath { get { return System.IO.Directory.GetCurrentDirectory() + "/Data"; } }

        /// <summary>
        /// DataInfo클래스를 파일로 저장
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        /// <param name="setTime"></param>
        public static void SaveDataInfo(string fileName, string content, DateTime setTime)
        {
            // GetFolderPath : 해당 경로가 있는지 확인, 없으면 폴더를 생성
            DirectoryInfo di = new(GetClassFolderPath);
            if (di.Exists == false)
                di.Create();

            // 객체를 만듭니다.
            DataInfo data = new DataInfo
            {
                FileName = fileName,
                Content = content,
                WorkTime = setTime.Ticks,
                RegTime = DateTime.Now.Ticks,
                IsStatus = IsReady
            };

            string path = GetClassFolderPath + "/" + fileName[..fileName.LastIndexOf(".")] + ".xml";
            // 해당 저장 경로에 파일이 있을경우 삭제
            if (File.Exists(path))
                File.Delete(path);

            // 클래스를 파일로 저장
            using (StreamWriter wr = new(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(DataInfo));
                xs.Serialize(wr, data);
            }
        }

        /// <summary>
        /// DataInfo클래스를 파일로 저장
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        /// <param name="setTime"></param>
        public static void SaveDataInfo(DataInfo data)
        {
            string path = GetClassFolderPath + "/" + data.FileName[..data.FileName.LastIndexOf(".")] + ".xml";
            // 해당 저장 경로에 파일이 있을경우 삭제
            if (File.Exists(path))
                File.Delete(path);

            // 클래스를 파일로 저장
            using (StreamWriter wr = new StreamWriter(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(DataInfo));
                xs.Serialize(wr, data);
            }
        }

        /// <summary>
        /// 생성한 DataInfo객체들을 불러옵니다.
        /// </summary>
        /// <returns>DataInfo List</returns>
        public static List<DataInfo> LoadDataInfo()
        {
            List<DataInfo> returnList = new List<DataInfo>();

            // GetFolderPath : 해당 경로가 있는지 확인, 없으면 return
            DirectoryInfo di = new DirectoryInfo(GetClassFolderPath);
            if (di.Exists == false)
                return returnList;

            // di로부터 파일들을 가져옵니다.
            // xml파일을 읽고 DataInfo객체를 만듭니다.
            // 만든 객체를 returnList에 담습니다.
            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    using (var reader = new StreamReader(file.FullName))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(DataInfo));
                        DataInfo? data = xs.Deserialize(reader) as DataInfo;
                        if (data != null)
                            returnList.Add(data);
                    }
                }
                catch (Exception) { }
            }

            return returnList;
        }

        /// <summary>
        /// DataInfo 객체를 삭제합니다.
        /// </summary>
        /// <param name="fileName">파일명</param>
        public static void DeleteFileInfo(string fileName)
        {
            string path = GetClassFolderPath + "/" + fileName[..fileName.LastIndexOf(".")] + ".xml";
            // 해당 저장 경로에 파일이 있을경우 삭제
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}
