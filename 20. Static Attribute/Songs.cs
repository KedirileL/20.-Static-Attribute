using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_Attribute
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount; // declared 
        public Songs(string aTitle, string aArtist, int aDuration) //Constructor
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;


        }
    }
}
