public class ReverseStringClass
{
    public static string ReverseString(string original)
    {
        StringBuilder reversed = new StringBuilder();

        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed.Append(original[i]);
        }
        return reversed.ToString();
    }
}