using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Adapter
{
    public interface IProjectLoader
    {
        Project LoadProject(string uri);
    }
}