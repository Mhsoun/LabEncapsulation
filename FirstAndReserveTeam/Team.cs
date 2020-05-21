using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortPerson;

namespace FirstAndReserveTeam
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        public List<Person> FirstTeam { get; }
        private List<Person> reverseTeam;
        public List<Person> ReverseTeam { get; }

        public Team(string name)
        {
            this.firstTeam = new List<Person>();
            this.reverseTeam = new List<Person>();
            this.name = name;
        }

        public void AddPlayer(Person player)
        {
            if(player.Age<40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reverseTeam.Add(player);
            }
        }

    }
}
