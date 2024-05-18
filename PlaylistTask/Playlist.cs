using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistTask
{
    public class Playlist
    {
        private Song[] songs = [];
        public Song[] Songs { get => songs; }

        public void AddSong(params Song[] forAddSongs)
        {
            foreach (Song song in forAddSongs)
            {
                Array.Resize(ref songs, songs.Length + 1);
                songs[songs.Length - 1] = song;
            }
        }

        public void GetAllSongsByGenre(MusicGenre genre)
        {
            foreach (Song song in songs)
            {
                if (song.Genre == genre) song.GetDetails();
            }
        }
    }
}
