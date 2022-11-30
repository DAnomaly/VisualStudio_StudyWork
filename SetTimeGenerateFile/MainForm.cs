namespace SetTimeGenerateFile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 대기열을 만듭니다.
        /// </summary>
        /// <param name="sender">생성버튼</param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 경로
            string fileName = FileNameBox.Text;
            if (fileName == null || fileName.Length == 0)
            {
                MessageBox.Show("파일명을 적어주세요.");
                return;
            }
            fileName += ".dat"; // 파일명

            DateTime setTime = dateTimePicker.Value;
            MessageBox.Show(setTime.ToString() + "\n해당 시간에 파일이 생성됩니다.", "대기열 생성");

            FileInfo file = new FileInfo(filePath + "\\" + fileName);
            string content = "이건 파일에 적힐 내용입니다.";
            Program.Creators.Add(new TimeFileCeator(file, content, setTime));
        }

        /// <summary>
        /// 매 틱마다 대기열의 파일생성여부를 확인하고
        /// 생성이 되어있지 않으면 파일을 생성합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (TimeFileCeator creator in Program.Creators)
                if (creator.isCreate == false)
                    creator.CreateFile();
        }
    }
}
