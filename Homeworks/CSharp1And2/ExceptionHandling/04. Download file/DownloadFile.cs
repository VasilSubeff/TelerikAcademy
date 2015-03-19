//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        string uri = "http://telerikacademy.com/Content/Images/";
        string fileName = "news-img01.png";
        string fullURLToFile = uri + fileName;

        WebClient downloader = new WebClient();
        
        try
        {
            downloader.DownloadFile(fullURLToFile, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, fullURLToFile);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Directory.GetCurrentDirectory());
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null.");
        }
        catch (WebException)
        {
            Console.WriteLine("Address is invalid or the file does not exist.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        finally
        {
            downloader.Dispose();
        }
    }
}
