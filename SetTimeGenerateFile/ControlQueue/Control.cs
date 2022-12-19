using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Threading.Channels;

namespace ControlQueue
{
    public class Control
    {

        public static void InsertQueue(string filename, string content, DateTime genDate)
        {
            QueueVO vo = new()
            {
                FileName = filename,
                Content = content,
                GenDate = genDate.ToString(QueueConfig.DateTimeFormat)
            };

            InsertQueue(vo);
        }

        public static void InsertQueue(QueueVO vo)
        {
            using SQLiteConnection conn = new(QueueConfig.ConnPath);

            conn.Open();
            string sql = "INSERT INTO QUEUE (FILENAME, CONTENT, GENDATE, REGDATE) VALUES (@FILENAME, @CONTENT, @GENDATE, @REGDATE)";
            SQLiteCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@FILENAME", vo.FileName);
            cmd.Parameters.AddWithValue("@CONTENT", vo.Content);
            cmd.Parameters.AddWithValue("@GENDATE", vo.GenDate);
            cmd.Parameters.AddWithValue("@REGDATE", DateTime.Now.ToString(QueueConfig.DateTimeFormat));

            cmd.ExecuteNonQuery();
        }

        public static List<QueueVO> SelectQueue()
        {
            List<QueueVO> list = new();

            using SQLiteConnection conn = new(QueueConfig.ConnPath);

            conn.Open();
            string sql = "SELECT NO, FILENAME, CONTENT, GENDATE, REGDATE, ISGEN, CANCEL FROM QUEUE ORDER BY NO";
            SQLiteCommand cmd = new(sql, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                QueueVO vo = new()
                {
                    No = dr.GetInt32(0),
                    FileName = dr.GetString(1),
                    Content = dr.GetString(2),
                    GenDate = dr.GetString(3),
                    RegDate = dr.GetString(4),
                    IsGen = dr.GetInt32(5),
                    Cancel = dr.GetInt32(6)
                };

                list.Add(vo);
            }

            return list;
        }

        public static void UpdateQueue(QueueVO vo)
        {
            using SQLiteConnection conn = new(QueueConfig.ConnPath);

            conn.Open();
            string sql = "UPDATE QUEUE SET FILENAME = @FILENAME, CONTENT = @CONTENT, GENDATE = @GENDATE, ISGEN = @ISGEN, CANCEL = @CANCEL WHERE NO = @NO";
            SQLiteCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@NO", vo.No);
            cmd.Parameters.AddWithValue("@FILENAME", vo.FileName);
            cmd.Parameters.AddWithValue("@CONTENT", vo.Content);
            cmd.Parameters.AddWithValue("@GENDATE", vo.GenDate);
            cmd.Parameters.AddWithValue("@ISGEN", vo.IsGen);
            cmd.Parameters.AddWithValue("@CANCEL", vo.Cancel);

            cmd.ExecuteNonQuery();
        }

        public static void UpdateQueue(int no, int isGen, int cancel)
        {
            using SQLiteConnection conn = new(QueueConfig.ConnPath);

            conn.Open();
            string sql = "UPDATE QUEUE SET ISGEN = @ISGEN, CANCEL = @CANCEL WHERE NO = @NO";
            SQLiteCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@NO", no);
            cmd.Parameters.AddWithValue("@ISGEN", isGen);
            cmd.Parameters.AddWithValue("@CANCEL", cancel);

            cmd.ExecuteNonQuery();
        }

        public static void DeleteQueue(int no)
        {
            using SQLiteConnection conn = new(QueueConfig.ConnPath);

            conn.Open();
            string sql = "DELETE FROM QUEUE WHERE NO = @NO";
            SQLiteCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@NO", no);

            cmd.ExecuteNonQuery();
        }

        public static bool IsPossibleGenerate(QueueVO vo)
        {
            if(vo.IsGen == QueueConfig.IsGenerated || vo.Cancel == QueueConfig.IsCanceled) return false;
            else if (DateTime.Now < DateTime.ParseExact(vo.GenDate, QueueConfig.DateTimeFormat, CultureInfo.CurrentCulture)) return false;
            else return true;
        }
        
    }
}
