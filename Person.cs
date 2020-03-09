namespace BerverageCashRegister
{
    class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string fullName()
        {
            return lastName + ' ' + firstName;
        }
    }

    class Persons
    {

    }
}
