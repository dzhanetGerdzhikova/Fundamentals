using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countOfTeam = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeam; i++)
            {
                string[] userAndTeam = Console.ReadLine().Split('-');
                string creator = userAndTeam[0];
                string team = userAndTeam[1];

                if (teams.Where(e => e.TeamName == team).Count() == 0 && teams.Where(e => e.Creator == creator).Count() == 0)
                {
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                    teams.Add(new Team(team, creator));
                }
                else if (teams.Where(e => e.TeamName == team).Count() > 0)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (teams.Where(e => e.Creator == creator).Count() > 0)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            string[] userInTeam = Console.ReadLine().Split("->");
            string user1 = userInTeam[0];

            while (user1 != "end of assignment")
            {
                string team1 = userInTeam[1];
                if (teams.Where(e => e.TeamName == team1).Count() <= 0)
                {
                    Console.WriteLine($"Team {team1} does not exist!");
                }
                else if (teams.Where(e => e.Members.Contains(user1) || e.Creator == user1).Count() > 0)
                {
                    Console.WriteLine($"Member {user1} cannot join team {team1}!");
                }
                else
                {
                    teams.Where(e => e.TeamName == team1).First().Members.Add(user1);
                }

                userInTeam = Console.ReadLine().Split("->");
                user1 = userInTeam[0];
            }

            List<Team> fullTeams = teams.Where(e => e.Members.Count() > 0).OrderByDescending(e => e.Members.Count).ThenBy(x => x.TeamName).ToList();
            List<Team> disabandTeams = teams.Where(e => e.Members.Count() == 0).OrderBy(e => e.TeamName).ToList();

            foreach (Team team in fullTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
                //Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(e => "-- " + e)));
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in disabandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    internal class Team
    {
        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}