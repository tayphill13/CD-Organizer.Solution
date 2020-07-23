using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Record
  {
    private static List<Record> _instances = new List<Record> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Song> Songs { get; set; }

    public Record(string RecordName)
    {
      Name = RecordName;
      _instances.Add(this);
      Id = _instances.Count;
      Songs = new List<Song>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }

    public static Record Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddSong(Song song)
    {
      Songs.Add(song);
    }
  }
}
