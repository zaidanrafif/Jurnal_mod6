using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeUser> uploadedVideos;
    public string Username;
    
    public SayaTubeUser (string username)
    {
        this.Username= username;    
    }
}