static class ListUtility
{
    private static string input;
    public static void getListInput(List<string> list)
    {
        Console.WriteLine("Please enter a name and press enter.");
        Console.WriteLine("You may do this as many times as you would like.");
        Console.WriteLine("Otherwise, please enter \"ok\" to continue.");
        while (true)
        {
            input = Console.ReadLine();
            if (input.Replace(" ", "") == "")
            {
                Console.WriteLine("No input detected.");
                Console.Write("Enter next name: ");
            }
            else if(!input.Equals("ok", StringComparison.OrdinalIgnoreCase))
            {
                list.Add(input);
                Console.Write("Enter next name: ");
            }
            else
            {
                Console.WriteLine();
                break;
            }
        }
    }
    public static void calculateLikes(List<string> list)
    {
        int friends = list.Count;
        switch (list.Count)
        {
            case 0:
                Console.WriteLine("No one has liked your post :(");
                break;
            case 1:
                Console.WriteLine("{0} likes your post", list[friends - 1]);
                break;
            default:
                string f1 = list[friends - 1];
                string f2 = list[friends - 2];
                int others = list.Count - 2;
                if (others == 0)
                {
                    Console.WriteLine("{0} and {1} like your post", f1, f2);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, and {2} others like your post", f1, f2, others);
                }
                break;
        }
    }
}