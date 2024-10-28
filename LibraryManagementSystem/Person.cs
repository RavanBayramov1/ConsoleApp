using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class Person
    {
        
        private static int _id;
        public  int Id { get; }
        public string Name;
        protected Person(string name)
        {
            ++_id;
            Name = name;
        }



    }
}
