using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    internal class GroupLayer : WindowLayer
    {
        internal IList<WindowLayer> Layers = new List<WindowLayer>(); 

        internal GroupLayer(long id) : base(id) { }
    }
}
