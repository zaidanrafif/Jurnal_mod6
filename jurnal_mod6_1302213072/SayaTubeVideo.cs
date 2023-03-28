using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal_mod6_1302213072
{
   internal class SayaTubeVideo
        {
            private int id;
            private string title;
            public int playCount;

            public SayaTubeVideo(string title)
            {
                this.id = new Random().Next(1000, 99999);
                this.title = title;
                this.playCount = 0;
            }

            public void IncreasePlayCount(int count)
            {
                this.playCount += count;
            }
            public void PrintVideoDetails()
            {
                Console.WriteLine("ID: " + id + "\nTitle: " + title + "\nplayCount: " + playCount);
            }

        }
   }
    

