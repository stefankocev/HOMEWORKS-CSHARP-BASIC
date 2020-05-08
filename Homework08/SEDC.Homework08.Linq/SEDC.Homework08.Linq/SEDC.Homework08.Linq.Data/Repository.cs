using SEDC.Homework08.Linq.MusicLibrary.Enums;
using SEDC.Homework08.Linq.MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Homework08.Linq.DataBase
{
    public class Repository : Data
    {
        public string GetFaveSongs(Person person)
        {
            string allFaveSongs = null ;
            foreach (var song in person.FavoriteSongs)
            {
                allFaveSongs += song.Title + ",";
            }
            if (allFaveSongs != null)
            {
                return $"{person.FirstName}'s favorite songs are:{allFaveSongs.Remove(allFaveSongs.Length - 1, 1)}.";
            }
            return $"This person hates music.";
        }
        public Person FindPerson(string name)
        {
            var personFound = FansArray.FirstOrDefault(person => person.FirstName == name);
            if(personFound != null)
            {
                return personFound;
            }
            return null;

        }
        public List<Song> SongsThatStartsWithB()
        {
            return   Songs
                    .Where(song => song.Title.StartsWith('B'))
                    .ToList();
        }

        public List<Song> SongsThatStartsWithBQuery()
        {
            var songsThatStartsWithB = from song in Songs
                                       where song.Title.StartsWith('B')
                                       select song;
            return songsThatStartsWithB.ToList();
        }
        public List<Song> SongsLessThan6Min()
        {
            return Songs
                  .Where(song => song.Length <= 360)
                  .ToList();
        }
        public List<Song> SongsLessThan6MinQuery()
        {
            var songsLessThan6min = from song in Songs
                                    where song.Length <= 360
                                    select song;
            return songsLessThan6min.ToList();
        }
        public List<Song> SongsOfRockGenre()
        {
            return Songs
                .Where(song => song.Genre.Equals(Genre.Rock))
                .ToList();
        }
        public List<Song> SongsOfRockGenreQuery()
        {
            var songsOfRockGenre = from song in Songs
                                   where song.Genre.Equals(Genre.Rock)
                                   select song;
            return songsOfRockGenre.ToList();
        }
        public List<Song> SongsLessThan3MinAndOfHipHopGenre()
        {
            return Songs
                .Where(song => song.Length <= 180 && song.Genre.Equals(Genre.Hip_Hop))
                .ToList();
        }
        public List<Song> SongsLessThan3MinAndOfHipHopGenreQuery()
        {
            var songLessThan3MinAndOfHipHopGenre = from song in Songs
                                                   where song.Length <= 180 && song.Genre.Equals(Genre.Hip_Hop)
                                                   select song;
            return songLessThan3MinAndOfHipHopGenre.ToList();
        }
        public List<string> MoreThan4FaveSongs()
        {
            return FansArray
                .Where(person => person.FavoriteSongs.Count >= 4)
                .Select(person => person.FirstName)
                .ToList();
        }
        public List<string> MoreThan4FaveSongsQuery()
        {
            var moreThan4FaveSongs = from person in FansArray
                                     where person.FavoriteSongs.Count >= 4
                                     select person.FirstName;
           return moreThan4FaveSongs.ToList();
        }
        public List<Song> AddSongs(Person person, List<Song> faveSongList)
        {
               return person.FavoriteSongs = faveSongList;
        }
    }
}
