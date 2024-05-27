using Iterator.Example.Components;
using Iterator.Example.Interfaces;

namespace Iterator.Example
{
    public class PlaylistIterator : IIterator<Song>
    {
        private readonly Playlist _playlist;
        private int _currentIndex = 0;

        public PlaylistIterator(Playlist playlist)
        {
            _playlist = playlist;
        }

        public bool HasNext()
        {
            return _currentIndex < _playlist.GetSongs().Count;
        }

        public Song Next()
        {
            return _playlist.GetSongs()[_currentIndex++];
        }
    }
}
