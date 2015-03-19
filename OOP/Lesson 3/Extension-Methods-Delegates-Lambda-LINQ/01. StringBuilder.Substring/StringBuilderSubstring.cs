using System.Text;

namespace StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        public static string Substring(this StringBuilder builder, int index, int length)
        {
            string result = builder.ToString().Substring(index, length);
            return result;
        }
        
    }

}
