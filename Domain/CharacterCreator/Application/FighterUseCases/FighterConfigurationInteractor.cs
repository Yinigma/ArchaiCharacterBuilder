using CharacterCreator.Port;
using CharacterCreator.Domain.Project;
using Archai.CharacterCreator.Domain.ValueObject.Script;
using Archai.CharacterCreator.Domain.Enumeration;

namespace Archai.CharacterCreator.Application.FighterUseCases
{
    public class FighterConfigurationInteractor
    {
        private IProjectEditor manager;

        private IFighterInjector injector;

        private IFighterPresenter presenter;

        public void AddProperty(string name, IScriptVariableType type)
        {

        }

        public void SetProperty(string name, object value)
        {

        }

        public void RemoveProperty(string name)
        {

        }

        public void AddScript(FighterScriptSlot slot)
        {

        }

        public void InsertScript(FighterScriptSlot slot, IScript script, int index)
        {

        }

        public void RemoveScript(FighterScriptSlot slot, IScript script)
        {

        }

    }

}

