namespace SampleNuget;
public static class TratamentoString
{
    public static string LimitaTamanhoString(this string str, int len = 10)
    {
        return str.Length > len ? str.Substring(0, len) : str;
    }
}
