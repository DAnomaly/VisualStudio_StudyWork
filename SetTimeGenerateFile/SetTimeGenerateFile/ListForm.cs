namespace SetTimeGenerateFile
{
#pragma warning disable CS8618 // 생성자를 종료할 때 null을 허용하지 않는 필드에 null이 아닌 값을 포함해야 합니다. null 허용으로 선언해 보세요.
    public partial class ListForm : Form
    {

        public ListForm()
        {
            InitializeComponent();

            LoadList();
        }

        /// <summary>
        /// 테이블을 생성합니다.
        /// </summary>
        private void LoadList()
        {

        }

        /// <summary>
        /// 작업상태를 한글로 반환합니다.
        /// </summary>
        /// <see cref="LoadList"/>
        /// <param name="isStatus"></param>
        /// <returns></returns>
        private static string ShowStatus(string isStatus)
        {
            return null;
        }

        /// <summary>
        /// 마우스 우클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        /// <summary>
        /// 키 F5 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
#pragma warning restore CS8618 
}
