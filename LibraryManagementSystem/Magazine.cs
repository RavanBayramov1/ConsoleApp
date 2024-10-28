using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Magazine : LibraryItem
    {
        public LibraryLocation libraryLocation;

        public Magazine(string title, int? publicationYear) : base(title, publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Title} {PublicationYear}");
            ;
        }
    }
}
