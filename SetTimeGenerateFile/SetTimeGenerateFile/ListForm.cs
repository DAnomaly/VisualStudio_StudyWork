using ControlQueue;

namespace SetTimeGenerateFile
{
#pragma warning disable CS8618 // 생성자를 종료할 때 null을 허용하지 않는 필드에 null이 아닌 값을 포함해야 합니다. null 허용으로 선언해 보세요.
    public partial class ListForm : Form
    {

        private List<QueueVO> QueueList { get; set; }

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

            QueueList = ControlQueue.Control.SelectQueue();

            foreach (QueueVO vo in QueueList)
            {
                DataTable.Rows.Add(
                    vo.No,
                    vo.FileName,
                    vo.RegDate,
                    vo.GenDate,
                    vo.IsGen == QueueConfig.IsGenerated ? "Y" : "N",
                    vo.Cancel == QueueConfig.IsCanceled ? "Y" : "N"
                );
            }
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
                // QueueVO 정보 받아오기
                string noStr = DataTable.Rows[e.RowIndex].Cells[0].Value as string;

                QueueVO vo = null;
                foreach (QueueVO tmpVO in QueueList)
                {
                    if (tmpVO.No.ToString() == noStr)
                    {
                        vo = tmpVO;
                        break;
                    }
                }
                if (vo == null) throw new NotImplementedException("ListForm.DataTable_CellMouseClick\r\nvo의 값이 null입니다.");
                // ContextMenuStrip 생성
                ContextMenuStrip menu = new ContextMenuStrip();
                #region 삭제 메뉴
                // 삭제 버튼 생성
                ToolStripMenuItem item1 = new ToolStripMenuItem();
                item1.Text = "삭제";
                item1.Click += (sender, e) =>
                {
                    // 삭제 이벤트
                    ControlQueue.Control.DeleteQueue(vo.No);
                    LoadList();
                };
                menu.Items.Add(item1);
                #endregion
                #region 취소 메뉴
                // 취소 버튼 생성
                ToolStripMenuItem item2 = new ToolStripMenuItem();
                item2.Text = "취소";
                item2.Click += (sender, e) =>
                {
                    vo.Cancel = QueueConfig.IsCanceled;
                    // 취소 이벤트
                    ControlQueue.Control.UpdateQueue(vo);
                    LoadList();
                };
                menu.Items.Add(item2);
                #endregion
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
