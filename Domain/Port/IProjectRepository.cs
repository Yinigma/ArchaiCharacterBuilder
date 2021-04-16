using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Port
{
    public interface IProjectRepository
    {
        long AddProject(Project proj);

        void RevertProject(long projectId);

        long CreateProject();

        Project GetProject(long projectId);

        void RemoveProject(long projectId);
    }
}
