using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    static class Library
    {
        public static List<LibraryMember> members = new List<LibraryMember> { new LibraryMember("John"),
                                                                       new LibraryMember("Aakash"),
                                                                       new LibraryMember("Dhruv"),
                                                                       new LibraryMember("Ralph"),
                                                                       new LibraryMember("Steven") };

        public static List<Media> medias = new List<Media>(15) { new Book("Don Quixote","Book",200),
                                                          new Book("Invisible Man","Book",210),
                                                          new Book("The Great Gatsby","Book",220),
                                                          new Book("A Passage To India","Book",230),
                                                          new Book("To Kill A Mockingbird","Book",240),
                                                          new Movie("Black Panther","Movie", 138),
                                                          new Movie("Citizen Kane","Movie", 190),
                                                          new Movie("Inception","Movie", 120),
                                                          new Movie("Interstellar","Movie", 56),
                                                          new Movie("Primal Fear","Movie", 65),
                                                          new Magazine("Times","Magazine",2345),
                                                          new Magazine("Outlook","Magazine",2346),
                                                          new Magazine("Forbes","Magazine",2347),
                                                          new Magazine("People","Magazine",2348),
                                                          new Magazine("Cosmopolitan","Magazine",2349) };
      
    }
}
