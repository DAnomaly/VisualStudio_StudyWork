namespace SetTimeGenerateFile
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
            
        }
    }
}
