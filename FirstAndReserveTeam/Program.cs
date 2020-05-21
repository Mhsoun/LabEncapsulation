using SortPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 2;
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArg = Console.ReadLine().Split();
                var person = new Person(cmdArg[0], cmdArg[1], int.Parse(cmdArg[2]));
                persons.Add(person);
            }

            Team team = new Team("Lexicon");
            foreach(Person p in persons)
            {
                team.AddPlayer(p);
            }

            Console.ReadLine();
        }
    }
}
