using SEDC.Homework08.Linq.MusicLibrary;
using SEDC.Homework08.Linq.DataBase;
using System;

namespace SEDC.Homework08.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataRepository = new Repository();
            #region Jerry
            var jerry = dataRepository.FindPerson("Jerry");
            var jerrysFaveSongs = dataRepository.SongsThatStartsWithB();
            var jerrysFaveSongsQuery = dataRepository.SongsThatStartsWithBQuery();
            //dataRepository.AddSongs(jerry, jerrysFaveSongs);
            dataRepository.AddSongs(jerry, jerrysFaveSongsQuery);
            Console.WriteLine(dataRepository.GetFaveSongs(jerry));
            #endregion
            Console.WriteLine("------------------------------------");
            #region Maria
            var maria = dataRepository.FindPerson("Maria");
            var mariasFaveSongs = dataRepository.SongsLessThan6Min();
            var mariasFaveSongsQuery = dataRepository.SongsLessThan6MinQuery();
            //dataRepository.AddSongs(maria, mariasFaveSongs);
            dataRepository.AddSongs(maria, mariasFaveSongsQuery);
            Console.WriteLine(dataRepository.GetFaveSongs(maria));
            #endregion
            Console.WriteLine("------------------------------------");
            #region Jane
            var jane = dataRepository.FindPerson("Jane");
            var janesFaveSongs = dataRepository.SongsOfRockGenre();
            dataRepository.AddSongs(jane, janesFaveSongs);
            Console.WriteLine(dataRepository.GetFaveSongs(jane));
            #endregion
            Console.WriteLine("------------------------------------");
            #region Stefan
            var stefan = dataRepository.FindPerson("Stefan");
            var stefansFaveSongs = dataRepository.SongsLessThan3MinAndOfHipHopGenre();
            var stefansFaveSongsQuery = dataRepository.SongsLessThan3MinAndOfHipHopGenreQuery();
            //dataRepository.AddSongs(stefan, stefansFaveSongs);
            dataRepository.AddSongs(stefan, stefansFaveSongsQuery);
            Console.WriteLine(dataRepository.GetFaveSongs(stefan));
            #endregion
            Console.WriteLine("------------------------------------");
            #region All of them :)
            var moreThan4Songs = dataRepository.MoreThan4FaveSongs();
            var moreThan4SongsQuery = dataRepository.MoreThan4FaveSongsQuery();
            foreach (var person in moreThan4Songs)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("------------------------------------");
            foreach (var person in moreThan4SongsQuery)
            {
                Console.WriteLine(person);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
