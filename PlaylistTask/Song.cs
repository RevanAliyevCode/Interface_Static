﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistTask
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public MusicGenre Genre { get; set; }

        public Song(string title, string artist, TimeSpan duration, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Title: {Title}, Artist: {Artist}, Duration: {Duration}, Genre: {Genre}");
        }
    }
}
