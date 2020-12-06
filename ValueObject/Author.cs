using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectSample
{
    public class Author
    {
        private Guid _id;
        private PersonFullName _name;

        public Author(string given, string surname)
        {
            _id = Guid.NewGuid();
            _name = PersonFullName.Create(given, surname);

        }
        public Guid Id => _id;
        public PersonFullName Name =>_name;
        public void FixAuthorName(string given, string surname)
        { _name = PersonFullName.Create(given, surname); 
        }
    }
}
