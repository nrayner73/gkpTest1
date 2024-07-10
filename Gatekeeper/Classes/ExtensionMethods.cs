namespace Gatekeeper.Classes
{
    public static class ExtensionMethods
    {

        public static bool ContainsAll(this string source, params string[] values)
        {
            return values.All(x => source.Contains(x));
        }

    }
}
