using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRepository
{
    public class Audio
    {
        public string name { get; set; }
        public string URL { get; set; }
        public bool Favorite { get; set; }

        public Audio(string name, string uRL, bool favorite)
        {
            this.name = name;
            URL = uRL;
            Favorite = favorite;
        }
    }
}
