using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryCatalog : Exception
    {
        public Book[] books;
        private static int _idBook;
        public int IdBook { get; }
        public Book this[int index]
        {
            get
            {
                int digit = 0;
                for (int i = 0; i < books.Length; i++)
                {

                    if (books[i].IdBook != _idBook)
                    {
                        ++digit;
                        return books[index];
                    }
                }  // Yarimciq qaldi fikirlesirdim
                throw new CustomBookError("Daxil edilen Id-ye uygun kitab tapilmadi");
            }
            set
            {

            }
        }
    }
}