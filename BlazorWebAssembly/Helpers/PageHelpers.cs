namespace BlazorWebAssembly.Helpers
{
    public static class PageHelpers
    {
        public static string GetProperName(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1);
        }
    }
}
