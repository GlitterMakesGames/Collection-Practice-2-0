using System.Collections.Generic;
class MainClass
{
    public static void Main(string[] args)
    {
        List<string> nameList = new List<string>();
        List<DictEntry> treeChart;
        ListUtility.getListInput(nameList);
        ListUtility.calculateLikes(nameList);

        Console.WriteLine(); //-----------------------------------------------

        Dictionary<string, int> letters = new Dictionary<string, int>();
        DictUtility.populateDict(letters);
        treeChart = DictUtility.findKeyOrder(letters);
        DictUtility.printHuffmanTreeChart(treeChart);
    }
}