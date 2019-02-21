using HouseBuild.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild.Model
{
    class HouseProject
    {
        public HouseProject()
        {
            team.createTeam();
            this.createProject();
        }
        private Team team = new Team();
        public List<IPart> parts = new List<IPart>();

        public List<ITask> tasks = new List<ITask>();

        
        public void startBuilding()
        {
            foreach (var item in parts)
            {

            }
        }

        public void createProject()
        {
        }
    }
}
