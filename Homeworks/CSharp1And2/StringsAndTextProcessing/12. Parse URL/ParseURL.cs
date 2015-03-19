//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        Console.WriteLine("[URL] = " + url);
        
        int protocolEndIndex = url.IndexOf("://");
        int protocolStartIndex = 0;
        string protocol = url.Substring(protocolStartIndex, protocolEndIndex);
        Console.WriteLine("[protocol] = " + ParseTheURL(url, protocolStartIndex, protocolEndIndex));


        int serverStartIndex = protocolEndIndex + 3;
        int serverEndIndex = url.IndexOf("/", serverStartIndex) - serverStartIndex;
        string server = url.Substring(serverStartIndex, serverEndIndex);
        Console.WriteLine("[server] = " + ParseTheURL(url, serverStartIndex, serverEndIndex));


        int resourceStartIndex = url.IndexOf("/", serverEndIndex - 1);
        int resourceEndIndex = url.Length - resourceStartIndex;
        Console.WriteLine("[resource] = " + ParseTheURL(url, resourceStartIndex, resourceEndIndex));
    }

    private static string ParseTheURL(string url, int startIndex, int endIndex)
    {
        string part = url.Substring(startIndex, endIndex);
        return part;
    }
}

