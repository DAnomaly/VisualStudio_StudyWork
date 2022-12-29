using FAXCOMLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendFax
{
    internal class FaxController
    {
        public void FaxDocument(string theFile, string faxNumber)
        {
            /*
            FaxServer server = new FaxServerClass();
            FaxDoc doc = null;
            int response = -11;

            server.Connect(Environment.MachineName);
            
            doc = (FaxDoc)server.CreateDocument(theFile);
            
            doc.FaxNumber = faxNumber;
            doc.RecipientName = "Test";
            doc.DisplayName = "work";

            response = doc.Send();
            
            server.Disconnect();
            
            Console.WriteLine("response: " + response);
            */
        }
    }
}
