namespace SetTimeGenerateFile
{
    /// <summary>
    /// 파일 대기열 클래스
    /// </summary>
    class TimeFileCeator
    {
        public DateTime setTime { get; private set; }
        public FileInfo file { get; private set; }
        public string content { get; private set; }
        public bool isCreate { get; private set; }

        /// <summary>
        /// 파일생성 대기열
        /// </summary>
        /// <param name="file">파일(경로)</param>
        /// <param name="content">내용</param>
        /// <param name="setTime">지정한 시간</param>
        public TimeFileCeator(FileInfo file, string content, DateTime setTime)
        {
            this.file = file;
            this.content = content;
            this.setTime = setTime;
            this.isCreate = false;
        }

        /// <summary>
        /// 파일이 생성하지 않았고 지정한 시간이 되면
        /// 해당 파일을 생성합니다.
        /// </summary>
        public void CreateFile()
        {
            if (isCreate == false && DateTime.Now >= this.setTime)
            {
                isCreate = true;
                File.WriteAllText(file.FullName, content);
            }
        }

    }
}
