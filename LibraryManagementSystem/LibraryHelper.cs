using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagementSystem
{
    public static class LibraryHelperExtension
    {
        public static int CalculateAge(this LibraryItem libraryItem)
        {
            int dif = 0;
            int now = DateTime.Now.Year;
            dif = (int)(now - libraryItem.PublicationYear);
            return dif;
        }
        public static string ToTitleCAse(this LibraryItem libraryItem)
        {
            string title = libraryItem.Title;
            return Char.ToUpper(title[0]) + title.Substring(1).ToLower();
        }
    }
}
