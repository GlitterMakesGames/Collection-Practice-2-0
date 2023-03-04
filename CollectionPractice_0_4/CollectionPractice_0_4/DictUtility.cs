static class DictUtility
{
    private static char[] charArray;
    public static void populateDict(Dictionary<string, int> dict)
    {
        Console.WriteLine("Enter a Sentence:");
        charArray = Console.ReadLine().ToCharArray();
        if(charArray.Length != 0)
        {
            foreach (char c in charArray)
            {
                if ((int)c == 32)
                {
                    if (dict.ContainsKey("space"))
                    {
                        dict["space"]++;
                    }
                    else
                    {
                        dict.Add("space", 1);
                    }
                }
                else if ((int)c >= 33
                   && (int)c <= 126)
                {
                    if (dict.ContainsKey(c + ""))
                    {
                        dict[c + ""]++;
                    }
                    else
                    {
                        dict.Add(c + "", 1);
                    }
                }
            }
        }
    }

    public static List<DictEntry> findKeyOrder(Dictionary<string, int> dict)
    {
        List<DictEntry> sorting = new List<DictEntry>();
        foreach (KeyValuePair<string, int> entry in dict)
        {
            bool added = false;
            if (sorting.Count != 0)
            {
                foreach (DictEntry DE in sorting)
                {
                    if (entry.Value >= DE.value)
                    {
                        sorting.Insert(sorting.IndexOf(DE), new DictEntry(entry.Key, entry.Value));
                        added = true;
                        break;
                    }
                }
                if (!added)
                {
                    sorting.Add(new DictEntry(entry.Key, entry.Value));
                }
            }
            else
            {
                sorting.Add(new DictEntry(entry.Key, entry.Value));
            }
        }
        return sorting;
    }

    public static void printHuffmanTreeChart(List<DictEntry> list)
    {
        for(int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine("{0} | {1}", list[i].key, list[i].value);
        }
    }
}

public class DictEntry
{
    private string _key;
    private int _value;
    public string key { get => this._key; set => this._key = value; }
    public int value { get => this._value; set => this._value = value; }

    public DictEntry(string s, int i)
    {
        _key = s;
        _value = i;
    }
}