public class ParseDate
{
    //To change the date format - edit format variable value.
    public static DateTime ParseDate(string dateInput)
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime date = new DateTime();
        string format = "d.MM.yyyy";

        try
        {
            date = DateTime.ParseExact(dateInput, format, provider);

        }
        catch (System.FormatException)
        {

            Console.WriteLine("Invalid date !");
            Environment.Exit(0);
        }
        return date;
    }
}

