using FAXCOMLib;

namespace SendFax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string theFile = @"C:\Users\tripleaims\Downloads\back.tiff", faxNumber = @"+822-6952-7006";

            FaxServer server = new FaxServer();
            FaxDoc doc = null;
            int response = -11;
            try
            {
                server.Connect(Environment.MachineName);

                doc = server.CreateDocument(theFile);

                doc.FaxNumber = faxNumber;
                doc.RecipientName = "Test";
                doc.DisplayName = "work";

                response = doc.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                server.Disconnect();
            }
            MessageBox.Show("response: " + response);
        }
    }
}