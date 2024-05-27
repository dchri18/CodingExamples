using Iterator.Example.Components;
using Iterator.Example.Interfaces;

namespace Iterator.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create playlist and add songs
            Playlist playlist = new Playlist();
            playlist.AddSong(new Song("Song 1"));
            playlist.AddSong(new Song("Song 2"));
            playlist.AddSong(new Song("Song 3"));

            // Create iterator for the playlist
            IIterator<Song> iterator = playlist.CreateIterator();

            // Traverse the playlist
            while (iterator.HasNext())
            {
                Song song = iterator.Next();
                Console.WriteLine("Playing: " + song.Title);
            }
        }
    }
}
