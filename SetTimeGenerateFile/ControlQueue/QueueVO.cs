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

        public override string ToString()
        {
            return string.Format("NO:{0}, FILENAME:{1}, CONTENT:{2}, GENDATE:{3}, REGDATE:{4}, ISGEN:{5}, CANCEL:{6}", No, FileName, Content, GenDate, RegDate, IsGen, Cancel);
        }

    }
}