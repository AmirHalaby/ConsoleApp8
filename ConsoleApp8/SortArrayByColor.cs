using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /*
     * To-Do ex 1:
     *  check anther setoation if the ansuar is correct.
     * 
     */

    public class Song
    {
        public string Name { get; set; }
        public Song(string name) 
        {
            Name = name;
        }
    }

    public static class SortArrayByColor
    {
        public static string[]? SortArray(string[] balls)
        {
            if (balls == null)
                return default;
            if(balls.Length < 2)
            {
                return balls;
            }
            return orderByBall( orderByBall(balls, "Green"), "Yellow");
        }

        /// <summary>
        /// Arrange the balls by the string str.
        /// At the beginning we will send those who arrange the green balls and in a second reading you can also arrange the yellow balls.
        /// </summary>
        public static string[] orderByBall(string[] balls, string str)
        {
            int i = 0;
            int j = balls.Length - 1;
            
            while (!(i == j))
            {
                if (str == "Yellow" && balls[i] == "Green")
                {
                    i++;
                }
                if (balls[i] == str)
                {
                    i++;
                }
                if (balls[i] == "Red")
                {
                    if (balls[j] == str)
                    {
                        balls[i] = balls[j];
                        balls[j] = "Red";
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
                if (balls[i] == "Yellow")
                {
                    if (balls[j] == str)
                    {
                        balls[i] = balls[j];
                        balls[j] = "Yellow";
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            return balls;
        }
    }
}

