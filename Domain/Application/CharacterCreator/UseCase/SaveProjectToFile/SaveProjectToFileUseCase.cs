using Domain.Adapter;
using Domain.Entities;
using Domain.Port;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCase.SaveProjectToFile
{
    class SaveProjectToFileUseCase
    {
        private readonly IProjectWriter writer;
        private readonly IProjectRepository repository;

        public void SaveProjectToFile(long projectId, string projectLocation)
        {
            Project proj = repository.GetProject(projectId);
            writer.SaveProject(proj, projectLocation);
        }
    }
}
