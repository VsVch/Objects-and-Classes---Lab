using System;
using System.Collections.Generic;

namespace PP03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSong; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);

            }
            string typeLi = Console.ReadLine();
            if (typeLi == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeLi)
                    {
                        Console.WriteLine(song.Name);
                    }

                }
            }
        }
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }


        }
    }
}
