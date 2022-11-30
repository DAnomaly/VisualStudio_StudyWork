using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class DataInfo
    {
        /// <summary>
        /// 파일명
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 파일 내용
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 파일 생성 시각
        /// </summary>
        public long SetTime { get; set; }
        
    }
}
