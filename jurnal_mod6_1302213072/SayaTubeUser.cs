using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal_mod6_1302213072
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeUser> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            this.uploadedVideos= new List<SayaTubeUser>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0; 
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }
        public void AddVideo(SayaTubeUser video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + i + "judul: " + SayaTubeVideo.);
            }
        }
    }
}
