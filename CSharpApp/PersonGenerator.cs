using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{
    public class PersonGenerator
    {
        public List<Person> GetPersons(int count)
        {
            return Enumerable.Range(0, count).Select(CreatePerson).ToList();
        }

        private Person CreatePerson(int personId)
        {
            var random = new Random();
            var personalNumber = String.Empty;

                for (var i = 0; i < 900; i++)
                {
                    personalNumber += random.Next(0, 9).ToString() + "Number";
                }

            return new Person
                {
                    Id = personId,
                    Amount = random.Next(1, 10),
                    Earned = 0,
                    PersonalNumber = personalNumber,
                    RegisteredDate = DateTime.Now,
                    Salary = random.Next(100, 1000),
                    Signature = "Signature"
                    
                };
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string PersonalNumber { get; set; }
        public int Amount { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string Signature { get; set; }
        public int Salary { get; set; }
        public int Earned { get; set; }
    }
}
