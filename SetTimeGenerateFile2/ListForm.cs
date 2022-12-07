using SetTimeGenerateFile2.Data;

namespace SetTimeGenerateFile2
{
#pragma warning disable CS8618 // 생성자를 종료할 때 null을 허용하지 않는 필드에 null이 아닌 값을 포함해야 합니다. null 허용으로 선언해 보세요.
    public partial class ListForm : Form
    {
        /// <summary>
        /// 등록된 대기열 정보
        /// </summary>
        private List<DataInfo> DataInfos;

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
            DataTable.Rows.Clear();

            DataInfos = ControlDataInfo.LoadDataInfo();
            foreach (DataInfo info in DataInfos)
                DataTable.Rows.Add(info.FileName, new DateTime(info.RegTime).ToString(), new DateTime(info.WorkTime).ToString(), info.IsWork ? "등록됨" : "작업대기");

            DataTable.AutoResizeColumns();
        }

        /// <summary>
        /// 마우스 우클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right) && e.RowIndex != -1)
            {
                // Cell 선택 Control
                foreach (DataGridViewRow row in DataTable.Rows)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Selected = false;
                foreach (DataGridViewCell cell in DataTable.Rows[e.RowIndex].Cells)
                    cell.Selected = true;
                // DataInfo정보 받아오기
                DataInfo selectInfo = DataInfos[e.RowIndex];
                // ContextMenuStrip 생성
                ContextMenuStrip menu = new ContextMenuStrip();
                // 삭제 버튼 생성
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = "삭제";
                item.Click += (sender, e) =>
                {
                    // 삭제 이벤트
                    ControlDataInfo.DeleteFileInfo(selectInfo.FileName);
                    LoadList();
                };
                menu.Items.Add(item);
                // 생성한 메뉴보여주기
                menu.Show(MousePosition);
            }
        }

        /// <summary>
        /// 키 F5 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                LoadList();
        }
    }
#pragma warning restore CS8618 
}
