using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlQueue
{
    public class QueueVO
    {
        public int No { get; set; }
        public string FileName { get; set; }
        public string Content { get; set; }
        public string GenDate { get; set; }
        public string RegDate { get; set; }
        public int IsGen { get; set; }
        public int Cancel { get; set; }
    }
}
