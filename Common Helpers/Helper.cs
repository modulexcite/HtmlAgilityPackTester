using System;
using System.IO;

using HtmlAgilityPack;

namespace HTMLLive
{
    internal class Helper
    {
        public static long auctionID = 0;
        public static string HTMLCode = string.Empty;

        public const string defaultSavePath = "C:\\temp.htm";

        public static HtmlDocument htmldoc = new HtmlDocument();
        public static HtmlNode htmlnode;
        public static HtmlNodeCollection htmlnodecol;

        //public static Beattie.Modules.Core.Net.WebResponse webresponse = new Beattie.Modules.Core.Net.WebResponse();
        public static Nullstring.Modules.WFWebClient.WebClientLibrary webresponse = new Nullstring.Modules.WFWebClient.WebClientLibrary();

        public static void Save(string filepath, string content)
        {
            string writethis = content.Replace("\r\n", "<br />");
            using (StreamWriter writer = new StreamWriter(@filepath))
            {
                writer.Write(writethis);
            }
        }
    }
}
