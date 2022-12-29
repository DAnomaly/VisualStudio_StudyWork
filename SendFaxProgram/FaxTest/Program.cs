using FAXCOMLib;

internal class Program
{
    private static void Main(string[] args)
    {
        string theFile = @"C:\workspace\Homepage_Calipers\img\background.jpg", faxNumber = "+82269527006";

        FaxServer server = new FaxServer();
        FaxDoc doc = null;
        int response = -11;

        server.Connect(Environment.MachineName);
        
        doc = server.CreateDocument(theFile);

        doc.FaxNumber = faxNumber;
        doc.RecipientName = "Test";
        doc.DisplayName = "work";

        response = doc.Send();

        server.Disconnect();

        Console.WriteLine("response: " + response);
    }

    
}