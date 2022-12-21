namespace ControlQueue
{
    public class QueueConfig
    {
        public static readonly string ConnPath = "Data Source=" + Directory.GetCurrentDirectory() + @"\Queue.db;Version=3;";
        public static readonly string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public static readonly int IsNotGenerated = 0;
        public static readonly int IsGenerated = 1;

        public static readonly int IsNotCanceled = 0;
        public static readonly int IsCanceled = 1;
    }
}
