namespace SetTimeGenerateFile
{
    public partial class RegistForm : Form
    {
        #region 1. 생성자
        public RegistForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 2. 메소드
        /// <summary>
        /// 리스트 보기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListFormButton_Click(object sender, EventArgs e)
        {
            // ListForm 열기
            Form frm = new ListForm();
            frm.ShowDialog();
        }

        /// <summary>
        /// 리스트 생성 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // 파일명 확인
            string filename = FileNameBox.Text;
            if (filename == null
                || filename.Trim().Length == 0)
            {
                MessageBox.Show("파일명을 입력해주세요.");
                FileNameBox.Focus();
                return;
            }
            if (filename.LastIndexOf(".") == -1)
            {
                filename += ".dat";
            }

            // 내용 확인
            string content = FileContentBox.Text;
            if (content == null
                || content.Trim().Length == 0)
            {
                MessageBox.Show("내용을 입력해주세요.");
                FileContentBox.Focus();
                return;
            }

            // 시간 확인
            DateTime genDate = SetDateTime.Value;
            if (DateTime.Now > genDate)
            {
                MessageBox.Show("설정하신 시간이 이미 지났습니다.");
                SetDateTime.Focus();
                return;
            }

            // 대기열 생성
            try
            {
                ControlQueue.Control.InsertQueue(filename, content, genDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("대기열 생성중 오류가 발생했습니다.\r\n" + ex.Message);
                return;
            }
            MessageBox.Show(filename + " 대기열이 생성되었습니다.");

            // 내용 초기화
            FileNameBox.Text = "";
            FileContentBox.Text = "";
        }
        #endregion
    }
}
