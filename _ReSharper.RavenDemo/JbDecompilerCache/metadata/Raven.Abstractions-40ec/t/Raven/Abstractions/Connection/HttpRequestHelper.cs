// Type: Raven.Abstractions.Connection.HttpRequestHelper
// Assembly: Raven.Abstractions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=37f41c7f99471593
// Assembly location: Z:\Code\RavenDemo\packages\RavenDB-Client.1.0.910-Unstable\lib\net40\Raven.Abstractions.dll

using System.Net;

namespace Raven.Abstractions.Connection
{
    public class HttpRequestHelper
    {
        public static void WriteDataToRequest(HttpWebRequest req, string data, bool disableCompression);
        public static void CopyHeaders(HttpWebRequest src, HttpWebRequest dest);
    }
}
