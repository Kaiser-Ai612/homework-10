using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_10
{
    internal class Event
    {
        private List<Person> people;

        public Event(List<Person> people)
        {
            this.people = people;
        }

        public void CheckEvent(string eventDes)
        {
            foreach (var person in people)
            {
                if (person.Hobbies.Contains(eventDes))
                {
                    person.ReactToEvent(eventDes);
                }
            }
        }
    }
}
