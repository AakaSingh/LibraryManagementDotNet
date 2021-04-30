using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    class Movie: Media
    {
        public int RunTime { get; private set; }
        public Movie(string name, string mediaType, int runTime) : base(name, mediaType)
        {
            this.RunTime = runTime;
        }

        public override string MediaInfo()
        {
            return base.MediaInfo() + "\nRun Time : " + RunTime + " minutes";
        }
    }
}
