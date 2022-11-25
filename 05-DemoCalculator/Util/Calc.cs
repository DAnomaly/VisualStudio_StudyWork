using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace _05_DemoCalculator.Util
{
    /// <summary>
    /// DemoCalculator를 위한 계산클래스
    /// </summary>
    class Calc
    {
        private StringBuilder num1;
        private StringBuilder num2;
        private StringBuilder result;
        private StringBuilder sign;
        private bool reset;
        private bool calReady;

        private int numMaxLenth = 9;
        private int decMaxLenth = 3;

        public Calc()
        {
            num1 = new StringBuilder("0");
            num2 = new StringBuilder("0");
            result = new StringBuilder();
            sign = new StringBuilder();

            // 내용을 모두 초기화한다.
            Clear();
        }

        #region Calc 메소드
        /// <summary>
        /// 내용을 모두 초기화한다.
        /// </summary>
        public void Clear()
        {
            num1.Clear();
            num2.Clear();
            result.Clear();
            sign.Clear();

            num1.Append("0");
            num2.Append("0");
            reset = false;
            calReady = false;
        }

        /// <summary>
        /// 숫자를 받는다.
        /// </summary>
        /// <param name="input">숫자</param>
        /// <returns>표시숫자</returns>
        public string InputNum(string input)
        {
            // 초기화 대상이면
            // 모두 한번 정리한다.
            if (reset)
                Clear();

            // 어디에 값을 넣는지 찾는다.
            StringBuilder sNum = sign.ToString().Equals("") ? num1 : num2;
            if (sNum.ToString().Equals("0"))
            {
                // 값이 0일 경우
                // 0을 지워주고 값을 입력한다.
                sNum.Clear();
                sNum.Append(input);
            }
            else if (sNum.ToString().Contains(".") ?
                    num1.Length < numMaxLenth + 1 && sNum.ToString().Substring(num1.ToString().IndexOf(".")).Length < decMaxLenth + 1 :
                    sNum.Length < numMaxLenth) 
            {
                // 입력범위를 체크한다.
                // numMaxLenth보다 숫자 자리수가 많으면 안되며,
                // decMaxLenth보다 소수점 자리수가 많으면 안된다.
                // 위 해당 조건이 모두 충족하면 값을 넣는다.
                sNum.Append(input);
            }

            calReady = true;
            return sNum.ToString();
        }

        /// <summary>
        /// 계산기호를 받는다.
        /// </summary>
        /// <param name="signStr">계산기호</param>
        /// <returns>표시숫자</returns>
        public string InputSign(string signStr)
        {
            // 이미 계산기호가 있을 경우
            // 즉시 계산을 실시하고
            // 1번칸에 계산결과를 넣는다.
            if (calReady && !sign.ToString().Equals(""))
            {
                string pathValue = InputEqual();
                Clear();
                num1.Clear();
                num1.Append(pathValue);
            }

            // 계산기호를 등록한다.
            sign.Clear();
            sign.Append(signStr);

            calReady = false;

            return num1.ToString();
        }

        /// <summary>
        /// '='기호를 받는다.
        /// </summary>
        /// <returns>계산결과</returns>
        public string InputEqual()
        {
            // '='기호를 이미 한번 누른 상태에서는
            // 이전에 수행한 결과에 한번더 계산 작업을 실시한다.
            if (reset)
            {
                num1.Clear();
                num1.Append(result.ToString());
            }

            String formula = num1.ToString() + sign.ToString() + num2.ToString();

            var value = new DataTable().Compute(formula, "");

            result.Clear();
            if (value.GetType() == typeof(decimal))
                // 소수아래 3자리까지 표시
                result.Append(Decimal.Round((decimal)value, decMaxLenth));
            else
                result.Append(value);

            reset = true;
            return result.ToString();
        }

        /// <summary>
        /// 최근에 입력한 숫자를 지운다
        /// </summary>
        /// <returns>변경된 숫자</returns>
        public string Erase()
        {
            StringBuilder sNum = sign.ToString().Equals("") ? num1 : num2;

            if (sNum.Length != 0)
                sNum.Remove(sNum.Length - 1, 1);

            return sNum.ToString();
        }
        #endregion
    }
}
