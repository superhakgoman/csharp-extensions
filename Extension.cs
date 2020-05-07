namespace CsharpExtensions
{
    public static class Extension
    {
        public static bool IsValid(this string str) => string.IsNullOrEmpty(str) == false;
        public static bool IsValid<T>(this T[] array) => array != null && array.Length > 0;
        public static bool IsEmpty<T>(this T[] array) => array != null && array.Length == 0;

    }
}