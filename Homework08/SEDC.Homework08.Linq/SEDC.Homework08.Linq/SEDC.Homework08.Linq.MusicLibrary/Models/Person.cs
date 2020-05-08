using SEDC.Homework08.Linq.MusicLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework08.Linq.MusicLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public Person(string firstName, string lastName, int age, Genre favoriteMusicType)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
        }
        
    }
}
