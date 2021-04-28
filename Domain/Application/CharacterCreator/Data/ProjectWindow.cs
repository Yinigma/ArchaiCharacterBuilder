using Domain.Core.Enum.Window;
using Domain.Core.ValueObjects;
using Domain.Core.ValueObjects.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    public class ProjectWindow : IProjectItem
    {
        private const string DEFAULT_WINDOW_NAME = "New Window";

        private long layerId = 0;
        public long Id { get; }
        public string Name { get; set; }

        public WindowConfiguration Configuration { get; set; }

        private GroupLayer rootGroupLayer;

        private long GenerateLayerId()
        {
            return layerId++;
        }

        private ProjectWindow(long id, string name, WindowConfiguration configuration, GroupLayer layers)
        {
            Id = id;
            Name = name;
            Configuration = configuration;
            rootGroupLayer = layers;
        }

        public static ProjectWindow CreateNew(long id)
        {
            return new ProjectWindow
            (
                id,
                DEFAULT_WINDOW_NAME,
                new WindowConfiguration
                ( 
                    new WindowTiming
                    (
                        WindowType.NORMAL, 
                        5, 
                        false
                    ), 
                    new WindowMovement
                    (
                        new Vector2(0,0), 
                        SpeedType.SET_ON_FIRST_FRAME, 
                        SpeedType.SET_ON_FIRST_FRAME, 
                        false, 
                        null
                    ),
                    InvincibilityType.NONE,
                    CancelType.DOES_NOT_CANCEL
                ),
                new GroupLayer(0)
            );
        }

        public IProjectItem Duplicate(long duplicateId)
        {
            return new ProjectWindow(duplicateId, Name, Configuration, rootGroupLayer.Duplicate() as GroupLayer);
        }
    }
}
