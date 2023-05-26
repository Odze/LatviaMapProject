namespace MapProject.Extensions
{
    public static class ListExtensions
    {
        public static string Filter(this string str, List<char> charsToRemove)
        {
            charsToRemove.ForEach(c => str = str.Replace(c.ToString(), string.Empty));
            return str;
        }
    }
}
