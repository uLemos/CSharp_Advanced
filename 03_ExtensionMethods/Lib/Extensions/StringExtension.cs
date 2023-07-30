namespace System
{
    public static class StringExtension
    {
        public static string FirstToUpper(this string str)
        {
            string First = str.Substring(0, 1);

            string Second = str.Substring(1);

            return First.ToUpper() + Second;
        }
    }
}
