using Domain.Application.CharacterCreator.Data;
using Domain.Port;

namespace Domain.UseCase.SetFighterGroundMovement
{
    public sealed class SetFighterGroundMovementUseCase
    {
        private readonly IProjectRepository repo;

        public void SetFighterMovement(FighterGroundMovementUpdate update)
        {
            Project project = repo.GetProject(update.ProjectId);
            ProjectFighter fighter = (ProjectFighter) project.First((item)=> item is ProjectFighter && (item as ProjectFighter).Id == update.FighterId);
            fighter.WalkSpeed = update.WalkSpeed;

            //.UpdateWalk(update.WalkSpeed, update.WalkAccel, update.WalkTurnTime);
        }
    }
}
