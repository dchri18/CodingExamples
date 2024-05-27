using Iterator.Example.Components;
using Iterator.Example.Interfaces;

namespace Iterator.Example
{
    public class Playlist : IAggregate<Song>
    {
        private readonly List<Song> _songs = new List<Song>();

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(this);
        }

        public List<Song> GetSongs()
        {
            return _songs;
        }
    }
}
