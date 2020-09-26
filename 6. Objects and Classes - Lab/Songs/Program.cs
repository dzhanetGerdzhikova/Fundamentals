using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                songs.Add(new Song(input[0], input[1], input[2]));
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                Console.WriteLine(string.Join("\n", songs.Select(e => e.Name)));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, songs.Where(e => e.TypeList == typeList).Select(e => e.Name)));
            }
        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
