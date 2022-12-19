namespace ControlQueue
{
    public class QueueConfig
    {
        public static readonly string ConnPath = Directory.GetCurrentDirectory() + @"\Queue.db";
        public static readonly string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public static readonly int IsNotGenerated = 0;
        public static readonly int IsGenerated = 1;

        public static readonly int IsNotCanceled = 0;
        public static readonly int IsCanceled = 1;
    }
}
