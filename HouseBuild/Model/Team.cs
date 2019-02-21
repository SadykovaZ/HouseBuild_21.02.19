using HouseBuild.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser;

namespace HouseBuild.Model
{
    public class Team
    {
        public List<IWorker> team = new List<IWorker>();

        public void createTeam()
        {
            Random rnd = new Random();
            var user = GenerateUser.GetUser();
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.fullName= user.name.title + user.name.first;
            teamLeader.salary = rnd.Next(100, 5000);
            team.Add(teamLeader);
            

            for (int i = 0; i < rnd.Next(4,20); i++)
            {
                user = GenerateUser.GetUser();
                Worker worker = new Worker(Position.worker);
                worker.fullName = user.name.title + user.name.first;
                worker.salary = rnd.Next(1000, 5000);

                team.Add(worker);
            }
            
        }
    }
}
