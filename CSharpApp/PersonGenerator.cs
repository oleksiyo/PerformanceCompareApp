using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpApp
{
    public class PersonGenerator
    {
        private readonly Random random = new Random();

        public IEnumerable<Person> GetPersons(int count)
        {
            return Enumerable.Range(0, count)
                .AsParallel()
                .Select(CreatePerson);
        }

        private Person CreatePerson(int personId)
        {
            return new Person
                {
                    Id = personId,
                    Amount = random.Next(1, 10),
                    Earned = 0,
                    PersonalNumber = GetPersonalNumber(),
                    RegisteredDate = 2000 + random.Next(0, 9),
                    Salary = random.Next(100, 1000),
                    Signature = "Signature"
                };
        }

        private string GetPersonalNumber()
        {
            return string.Join("Number",
                               Enumerable.Repeat(0, 900)
                                         .Select(_ => random.Next(0, 9))
                                         .Select(i => i.ToString()));
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string PersonalNumber { get; set; }
        public int Amount { get; set; }
        public int RegisteredDate { get; set; }
        public string Signature { get; set; }
        public int Salary { get; set; }
        public int Earned { get; set; }
    }
}