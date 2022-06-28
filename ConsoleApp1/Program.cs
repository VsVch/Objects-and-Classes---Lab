using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();
            string typeList = Console.ReadLine();
            

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song somg = new Song();

                somg.TypeList = type;
                somg.Name = name;
                somg.Time = time;

                songs.Add(somg);

            }

            if (typeList == "all")
            {
                foreach (Song somg in songs)
                {
                    Console.WriteLine(somg.Name);
                }

            }
            else
            {
                foreach (Song somg in songs)
                {
                    if (somg.TypeList == typeList)
                    {
                        Console.WriteLine(somg.Name);
                    }

                }
            }

            List<Song> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();
            foreach (Song somg in filteredSongs)
            {
                Console.WriteLine(somg.Name);
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
