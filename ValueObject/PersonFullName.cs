using System;
using System.Collections.Generic;

namespace ValueObjectSample
{
    public class PersonFullName : IEquatable<PersonFullName>
    {
        private string _given;
        private string _surname;

        public static PersonFullName Create(string given, string surname)
        {
            return new PersonFullName(given, surname);
        }
        private PersonFullName(string given, string surname)
        {
            _given = given;
            _surname = surname;
        }


        public string Given => _given;
        public string Surname => _surname;
        public string FullName => _given + " " + _surname;
        public string Reverse => _surname + ", " + _given;
        public PersonFullName FamilyMemberWithSameSurname(string newGivenName)
              => Create(newGivenName, _surname);

        public override bool Equals(object obj)
        {
            return Equals(obj as PersonFullName);
        }

        public bool Equals(PersonFullName other)
        {
            return other != null &&
                   Given == other.Given &&
                   Surname == other.Surname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Given, Surname);
        }

        public static bool operator ==(PersonFullName left, PersonFullName right)
        {
            return EqualityComparer<PersonFullName>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonFullName left, PersonFullName right)
        {
            return !(left == right);
        }
    }
}
