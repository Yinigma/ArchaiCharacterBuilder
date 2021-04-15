using Domain.Entities;
using Domain.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.InterfaceAdapters
{
    public class ProjectSessionRepository : IProjectRepository
    {
        private long idCounter = 0;

        private Dictionary<long, Project> currentProjects = new Dictionary<long, Project>();

        private Dictionary<long, Project> reversionProjects = new Dictionary<long, Project>();

        public long AddProject(Project proj)
        {
            currentProjects.Add(idCounter++, proj);
            reversionProjects.Add(idCounter, proj.Duplicate());
            return idCounter;
        }

        public long CreateProject()
        {
            Project proj = new Project();
            return AddProject(proj);
        }

        public Project GetProject(long projectId)
        {
            if(currentProjects.Keys.Contains(projectId))
            {
                return currentProjects[projectId];
            }
            throw new ProjectNotFoundException();
        }

        public void RemoveProject(long projectId)
        {
            if (currentProjects.Keys.Contains(projectId))
            {
                currentProjects.Remove(projectId);
                reversionProjects.Remove(projectId);
            }
            throw new ProjectNotFoundException();
        }

        public void RevertProject(long projectId)
        {
            if (currentProjects.Keys.Contains(projectId))
            {
                currentProjects[projectId] = reversionProjects[projectId].Duplicate();
            }
            throw new ProjectNotFoundException();
        }
    }
}
