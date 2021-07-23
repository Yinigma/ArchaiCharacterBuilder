using Archai.CharacterCreator.Domain.Entity;
using Archai.CharacterCreator.Port;
using CharacterCreator.Domain.Project;
using CharacterCreator.Port;

namespace Archai.CharacterCreator.Application.ProjectUseCases
{
    public class ProjectEditingInteractor
    {
        private readonly IProjectEditor editor;
        private readonly IHitboxFactory hitboxFactory;

        public ProjectEditingInteractor(IProjectEditor editor, IHitboxFactory hitboxFactory)
        {
            this.editor = editor;
            this.hitboxFactory = hitboxFactory;
        }

        public void CreateEmptyFighter(Group destination)
        {

        }

        public void CreateEmptyFighterTemplate(Group destination)
        {

        }

        public void CreateTemplateFromFighter()
        {

        }

        public void CreateHitbox(Project project, Group destination)
        {
            Hitbox box = hitboxFactory.CreateHitbox();
            editor.PushAction(() => project.AddItem(destination, box), () => project.RemoveItem(destination, box));
        }

        public void DeleteProjectItem(Project project, Group target, IProjectItem item)
        {
            editor.PushAction(()=>project.RemoveItem(target, item), ()=>project.AddItem(target, item));
        }

    }

}

