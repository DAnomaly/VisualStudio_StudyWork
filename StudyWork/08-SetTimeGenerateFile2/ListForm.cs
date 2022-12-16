using SetTimeGenerateFile2.Data;
using UtilLibrary.File;

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
            try
            {
                LogWriter.Log("목록을 불러옵니다...");
                DataInfos = ControlDataInfo.LoadDataInfo();
                foreach (DataInfo info in DataInfos)
                    DataTable.Rows.Add(info.FileName, new DateTime(info.RegTime).ToString(), new DateTime(info.WorkTime).ToString(), ShowStatus(info.IsStatus));
            }
            catch (Exception ex)
            {
                LogWriter.Log("목록을 불러오는데에 실패하였습니다. ExceptionMessage: " + ex.Message);
            }

            DataTable.AutoResizeColumns();
        }

        /// <summary>
        /// 작업상태를 한글로 반환합니다.
        /// </summary>
        /// <see cref="LoadList"/>
        /// <param name="isStatus"></param>
        /// <returns></returns>
        private static string ShowStatus(string isStatus)
        {
            if (isStatus == ControlDataInfo.IsReady)
                return "작업대기";
            else if (isStatus == ControlDataInfo.IsWorked)
                return "등록됨";
            else if (isStatus == ControlDataInfo.IsPast)
                return "누락된처리";
            else if (isStatus == ControlDataInfo.IsError)
                return "오류";
            else
                return isStatus;
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
