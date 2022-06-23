class Test
{
    static void Main(string[] args)
    {
        SortedDictionary<int, string> dict;
        dict = new SortedDictionary<int, string>();

        dict[15] = "fifteen";
        dict[5] = "five";
        dict[20] = "twenty";

        var enumartor = dict.GetEnumerator();
        enumartor.MoveNext();
        var x = enumartor.Current;
        System.Console.WriteLine(x);
    }
}