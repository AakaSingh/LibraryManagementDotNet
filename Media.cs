using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public abstract class Media
    {
        static int counter = 101;
        public string Name { get; set; }
        public string MediaType { get; set; }
        public int SerialNumber { get; set; }
        public int NumberOfTimesLent { get; set; }
        public string Borrower { get; set; }
        public bool IsBorrowed { get; set; }
        public int borrowerId;

        public Media(string name, string mediaType)
        {
            this.Name = name;
            this.MediaType = mediaType;
            this.SerialNumber = counter;
            this.NumberOfTimesLent = 0;
            this.Borrower = null;
            this.IsBorrowed = false;
            counter++;
        }

        public virtual string MediaInfo()
        {
            return "Name : " + Name + "\nMedia Type : "+ MediaType + "\nSerial Number : " + SerialNumber + "\nAvailable : " + (IsBorrowed?"No":"Yes") +
                    "\nTimes Lent : " + NumberOfTimesLent + "\nCurrent Borrower : " + (Borrower ?? "None");
        }
            
    }
}
