using MusicANALYTICS;

class Program
{
    static void Main(string[] args)
    {
        List<Item> songs = ParseCSV.Parse();


        var count1 = 0;

        foreach (Item s in songs)
        {
            Console.WriteLine(s.ToString());
            count1++;
        }

        Console.WriteLine(count1);

        // Distinct songs
        
        List<Item> distinctSongs = songs.DistinctBy(i => i.song).ToList();
        
        var count2 = 0;
        foreach (Item i in distinctSongs)
        {
            Console.WriteLine(i.song);
            count2++;
        }

        Console.WriteLine(count2);
        
        // Distinct artists

        List<Item> distinctArtists = songs.DistinctBy(i => i.artist).ToList();

        var count3 = 0;
        foreach (Item i in distinctArtists)
        {
            Console.WriteLine(i.artist);
            count3++;
        }

        Console.WriteLine(count3);
    }
    
    
}