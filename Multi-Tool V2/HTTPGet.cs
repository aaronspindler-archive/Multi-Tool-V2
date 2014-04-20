﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace Multi_Tool_V2
{
    /*
 *    HTTPGet.cs | C# .NET 2.0 HTTP GET Class
 *    Copyright (c) 2008, Corey Goldberg
 *
 *    HTTPGet.cs is free software; you can redistribute it and/or modify
 *    it under the terms of the GNU General Public License as published by
 *    the Free Software Foundation; either version 3 of the License, or
 *    (at your option) any later version.
 */
    public class HTTPGet
    {
        private string escapedBody;
        private HttpWebRequest request;
        private HttpWebResponse response;

        private string responseBody;
        private double responseTime;
        private int statusCode;

        public string ResponseBody
        {
            get { return responseBody; }
        }

        public string EscapedBody
        {
            get { return GetEscapedBody(); }
        }

        public int StatusCode
        {
            get { return statusCode; }
        }

        public double ResponseTime
        {
            get { return responseTime; }
        }

        public string Headers
        {
            get { return GetHeaders(); }
        }

        public string StatusLine
        {
            get { return GetStatusLine(); }
        }


        public void Request(string url)
        {
            var timer = new Stopwatch();
            var respBody = new StringBuilder();

            request = (HttpWebRequest) WebRequest.Create(url);

            try
            {
                timer.Start();
                response = (HttpWebResponse) request.GetResponse();
                var buf = new byte[8192];
                Stream respStream = response.GetResponseStream();
                int count = 0;
                do
                {
                    count = respStream.Read(buf, 0, buf.Length);
                    if (count != 0)
                        respBody.Append(Encoding.ASCII.GetString(buf, 0, count));
                } while (count > 0);
                timer.Stop();

                responseBody = respBody.ToString();
                statusCode = (int) response.StatusCode;
                responseTime = timer.ElapsedMilliseconds/1000.0;
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse) ex.Response;
                responseBody = "No Server Response";
                escapedBody = "No Server Response";
                responseTime = 0.0;
            }
        }


        private string GetEscapedBody()
        {
            // HTML escaped chars
            string escapedBody = responseBody;
            escapedBody = escapedBody.Replace("&", "&amp;");
            escapedBody = escapedBody.Replace("<", "&lt;");
            escapedBody = escapedBody.Replace(">", "&gt;");
            escapedBody = escapedBody.Replace("'", "&apos;");
            escapedBody = escapedBody.Replace("\"", "&quot;");
            this.escapedBody = escapedBody;

            return escapedBody;
        }


        private string GetHeaders()
        {
            if (response == null)
                return "No Server Response";
            var headers = new StringBuilder();
            for (int i = 0; i < response.Headers.Count; ++i)
                headers.Append(String.Format("{0}: {1}\n",
                    response.Headers.Keys[i], response.Headers[i]));

            return headers.ToString();
        }


        private string GetStatusLine()
        {
            if (response == null)
                return "No Server Response";
            return String.Format("HTTP/{0} {1} {2}", response.ProtocolVersion,
                (int) response.StatusCode, response.StatusDescription);
        }
    }
}