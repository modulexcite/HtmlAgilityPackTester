using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using System.IO;

namespace Nullstring.Modules.WFWebClient
{
    public class WebClientLibrary
    {
        public string GetResponse(string url)
        {
            string ret = string.Empty;

            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status. (not need)
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            ret = responseFromServer;
            // Clean up the streams and the response.
            reader.Close();
            response.Close();

            return ret;
            //return "isblocklisted:True"; // used for debugging
        }
    }
}
