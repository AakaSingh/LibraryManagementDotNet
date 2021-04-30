using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    class Magazine: Media
    {
        public int IssueNumber { get; private set; }
        public Magazine(string name, string mediaType, int issueNumber) : base(name, mediaType)
        {
            this.IssueNumber = issueNumber;
        }
        public override string MediaInfo()
        {
            return base.MediaInfo() + "\nIssue Number : " + IssueNumber;
        }
    }
}
