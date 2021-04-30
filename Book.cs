using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    class Book : Media
    {
        public int NumberOfPages { get; private set; }
        public Book(string name, string mediaType, int numberOfPages) : base( name, mediaType )
        {
            this.NumberOfPages = numberOfPages;
        }
        public override string MediaInfo()
        {
            return base.MediaInfo() + "\n Number Of Pages : " + NumberOfPages;
        }
    }
}
