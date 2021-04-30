using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public class LibraryMember
    {
        private static int counter = 1;
        public string Name { get; set; }
        public int Id { get; private set; }
        public List<Media> borrowHistory = new List<Media>();
        public List<Media> currentlyBorrowed = new List<Media>();

        public LibraryMember(string name)
        {
            this.Name = name;
            this.Id = counter;
            counter++;
        }
        public string MemberInfo()
        {
            string toReturn = "Name " + Name + "\nBorrow History :";

            foreach (Media m in borrowHistory)
                toReturn += "\n" +m.Name;

            toReturn += "\n\nCurrently Borrowed : ";

            foreach (Media m in currentlyBorrowed)
                toReturn += "\n" + m.Name;

            return toReturn;
        }
    }
}
