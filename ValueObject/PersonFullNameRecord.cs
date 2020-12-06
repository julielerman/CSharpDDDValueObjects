namespace ValueObjectSample
{
    public record PersonFullNameRecord
    {
        private string _given;
        private string _surname;

        public static PersonFullNameRecord Create(string given, string surname)
        {
            return new PersonFullNameRecord(given, surname);
        }
        private PersonFullNameRecord(string given, string surname)
        {
            _given = given;
            _surname = surname;
        }
        public string Given => _given;
        public string Surname => _surname;
        public string FullName => _given + " " + _surname;
        public string Reverse => _surname + ", " + _given;
        public PersonFullNameRecord FamilyMemberWithSameSurname(string newGivenName)
              => Create(newGivenName, _surname);

    }
}
