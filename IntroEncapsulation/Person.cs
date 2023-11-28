namespace IntroEncapsulation
{
    internal class Person
    {
        private string _firstName;

        public Person(string firstName)
        {
            _firstName = firstName;
        }

        public int FirstNameLength => _firstName.Length;

        public int FirstNameLengthMethod()
        {
            return _firstName.Length;
        }

        /*
         * var p1 = new Person("Terje");
         * var p2 = new Person("Per");
         * var firstName1 = p1.FirstName;
         * var firstName2 = p2.FirstName;
         * p1.FirstName = "Albert";
         * p2.FirstName = "Albert";
         */


        // public string FirstName { get; set; }

        public string FirstName
        {
            get
            {
                // logging, tilgangskontroll
                return _firstName;
            }
            set
            {
                // logging, tilgangskontroll
                _firstName = value;
            }
        }

        /*
         * var p1 = new Person("Terje");
         * var p2 = new Person("Per");
         * var firstName1 = p1.GetFirstName();
         * var firstName2 = p2.GetFirstName();
         * p1.SetFirstName("Albert");
         * p2.SetFirstName("Albert");
         */

        public string GetFirstName()
        {
            // logging, tilgangskontroll
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            // logging, tilgangskontroll
            _firstName = firstName;
        }
    }
}
