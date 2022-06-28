using System;
using System.Collections.Generic;



namespace _03._Songs
{
    partial class Program




    {



        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }



            


        }



        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> song = new List<Song>();
            string typeList = Console.ReadLine();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song somg = new Song();


                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                song.Add(song);

                if (typeList == "all")
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
                        if (song.TypeList == typeList)
                        {
                            Console.WriteLine(song.Name);
                        }
                    }


                }
                

            }
        }





        

           
        }
    }

