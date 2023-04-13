namespace MusicANALYTICS;

public class ParseCSV
{
    public static List<Item> Parse()
    {
        List<Item> _temp = new List<Item>();
        foreach (string line in System.IO.File.ReadLines("csv/music.csv"))
        {
            string[] lines = line.Split(",");
            _temp.Add(new Item());
        }
        return _temp;
    }
}