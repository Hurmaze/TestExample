using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.API.ResponseModels
{
    public class VideoGame
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime releaseDate { get; set; }
        public int reviewScore { get; set; }
        public string category { get; set; }
        public string rating { get; set; }
    }

}
