/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages. */

using System;
using System.IO;
using System.Security;
using System.Text;


class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter full name of the file: ");
        string path = Console.ReadLine();

        ReadFile(path);
        
    }

    private static void ReadFile(string path)
    {
        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("path is null");
        }
        catch (ArgumentException)
        {

            Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. ");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch
        {
            Console.WriteLine("Exception has been thrown.");
        }
    }
}

