using SetTimeGenerateFile2.Data;
using UtilLibrary.File;

namespace SetTimeGenerateFile2
{
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();
        }

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
            // 파일명 체크
            if (FileNameBox.Text.Equals(""))
            {
                MessageBox.Show("파일명을 입력해주세요.", "안내");
                FileNameBox.Focus();
                return;
            }
            // 내용 체크
            if (FileContentBox.Text.Equals(""))
            {
                MessageBox.Show("내용을 입력해주세요.", "안내");
                FileContentBox.Focus();
                return;
            }
            // 작업 대기열 생성
            try
            {
                ControlDataInfo.SaveDataInfo(FileNameBox.Text + ".dat", FileContentBox.Text, SetDateTime.Value);
                LogWriter.Log("대기열 생성: " + FileNameBox.Text + ".dat");
                MessageBox.Show(string.Format("{0}\n해당 시간으로 {1} 작업이 생성됩니다.", SetDateTime.Value, FileNameBox.Text), "대기열 생성");
            }
            catch (Exception ex)
            {
                LogWriter.Log("대기열 생성실패: " + FileNameBox.Text + ".dat, ExceptionMessage:" + ex.Message);
            }
        }
    }
}
