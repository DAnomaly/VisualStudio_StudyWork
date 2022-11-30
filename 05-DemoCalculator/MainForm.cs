using _05_DemoCalculator.Util;
using System;
using System.Windows.Forms;

namespace _05_DemoCalculator
{
    public partial class MainForm : Form
    {

        private Calc calc;

        public MainForm()
        {
            InitializeComponent();
            calc = new Calc();
        }

        /// <summary>
        /// 숫자버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
                calLabel.Text = calc.InputNum(button.Text);
        }

        /// <summary>
        /// 정리버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            calc.Clear();
            calLabel.Text = "";
        }

        /// <summary>
        /// 연산기호버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
                calLabel.Text = calc.InputSign(button.Text);
        }

        /// <summary>
        /// '='버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalButton_Click(object sender, EventArgs e)
        {
            calLabel.Text = calc.InputEqual();
        }
    }
}
