using Domain.Adapter;
using Domain.Port;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCase.LoadProjectFromFile
{
    public sealed class LoadProjectFromFileUseCase
    {
        private readonly IProjectLoader loader;
        private readonly IProjectRepository repository;

        public void LoadProjectFromFile(string projectUri)
        {
            repository.AddProject(loader.LoadProject(projectUri));
        }
    }
}
