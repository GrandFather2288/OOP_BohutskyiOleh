using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class Family
    {
        #region Fields

        List<Person> persons = new List<Person>();

        #endregion

        #region Methods

        public void AddMember(Person member)
        {
            persons.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = new Person();
            int count = 0;
            int maxCount = 0;

            for(int i = 0; i < persons.Count; i++)
            {
                count = persons[i].Age;
                if(count > maxCount)
                {
                    maxCount = count;
                    oldest = persons[i];
                }
            }

            return oldest;
        }

        #endregion
    }
}
