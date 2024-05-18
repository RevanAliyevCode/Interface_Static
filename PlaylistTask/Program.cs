// See https://aka.ms/new-console-template for more information

using PlaylistTask;

Song song1 = new("bdejdbej", "jebdej", new(3, 0, 0), MusicGenre.Classical);
Song song2 = new("bdejdbej", "jebdej", new(3, 0, 0), MusicGenre.Classical);
Song song3 = new("bdejdbej", "jebdej", new(3, 0, 0), MusicGenre.Pop);
Song song4 = new("bdejdbej", "jebdej", new(3, 0, 0), MusicGenre.Jazz);
Song song5 = new("bdejdbej", "jebdej", new(3, 0, 0), MusicGenre.Rock);

Playlist playlist = new();

playlist.AddSong(song1, song2, song3, song4, song5);

playlist.GetAllSongsByGenre(MusicGenre.Classical);