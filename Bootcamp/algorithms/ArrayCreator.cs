public static class ArrayCreator
{
    public static int[] Create(int n)
    {
        return new int[n];
    }
    public static string ConvertToString(this int[] array)
    {
        return $"[{String.Join(',', array)}]";
    }
}