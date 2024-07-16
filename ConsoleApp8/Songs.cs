using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Songs
    {
        /// <summary>
        /// A method returns songs in random order
        /// </summary>
        public static IList<Song>? GetRandomSongList(IList<Song> songs)
        {
            if (songs == null) return default;
            if(songs.Count == 0) return default;
            if (songs.Count == 1) return songs;
            Random random = new Random();
            int[] songsNumber = new int[songs.Count];
            List<Song> list = new List<Song>();
            var randomTempNumber = 0;

            //Arrange the random numbers in the array according to the size of the number of songs.
            for (int i = 1; i < songs.Count + 1; i++)
            {
                randomTempNumber = random.Next(1, songs.Count);
                if (songsNumber[randomTempNumber] != 0)
                {
                    if (randomTempNumber == songs.Count - 1)
                        randomTempNumber = 0;
                    // Look for a free place in the array.
                    while (songsNumber[randomTempNumber] != 0)
                    {
                        if (randomTempNumber == songs.Count - 1)
                            randomTempNumber = 0;
                        else
                            randomTempNumber++;
                    }
                }
                songsNumber[randomTempNumber] = i;
            }
            // Arrange the songs according to the arrangement of the random numbers
            for (int i = 0; i < songs.Count; i++)
            {
                list.Add(songs[songsNumber[i] - 1]);
            }
            return list;
        }
    }
}
