using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618 // 생성자를 종료할 때 null을 허용하지 않는 필드에 null이 아닌 값을 포함해야 합니다. null 허용으로 선언해 보세요.
namespace SetTimeGenerateFile2.Data
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
        public long WorkTime { get; set; }

        /// <summary>
        /// 해당 클래스 등록 시각
        /// </summary>
        public long RegTime { get; set; }

        /// <summary>
        /// 작업 여부
        /// </summary>
        public bool IsWork { get; set; }
    }
}
#pragma warning restore CS8618