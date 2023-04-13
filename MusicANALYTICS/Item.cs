namespace MusicANALYTICS;

public class Item
{
    public int songID {get; private set;} 
    public int year { get; private set; }
    public int position { get; private set; }
    public string artist { get; private set; }
    public string song { get; private set; }
    public float revenue { get; private set; }
    public int us { get; private set; }
    public int uk { get; private set; }
    public int de { get; private set; }
    public int fr { get; private set; }
    public int ca { get; private set; }
    public int au { get; private set; }

    public Item(int id, int y, int pos, string art, string song, float rev, int us, int uk, int de, int fr, int ca, int au)
    {
        songID = id;
        year = y;
        position = pos;
        artist = art;
        this.song = song;
        revenue = rev;
        this.us = us;
        this.uk = uk;
        this.de = de;
        this.fr = fr;
        this.ca = ca;
        this.au = au;

    }
}