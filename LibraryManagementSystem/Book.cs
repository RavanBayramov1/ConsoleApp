using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : LibraryItem
    {
        public LibraryLocation libraryLocation;

        private static int _idBook;

        public int IdBook { get; }
        public BookJenre Genre {  get; set; }

        public Book( string title, int? publicationYear) : base(title, publicationYear)
        {
            ++_idBook;
            Title = title;
            PublicationYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Genre} {Title} {PublicationYear}");
        }

    }
    public struct LibraryLocation
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }

    }
}