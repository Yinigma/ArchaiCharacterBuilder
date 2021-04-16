using Domain.Entities;
using Domain.Port;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCase.SetFighterWalkMovement
{
    public sealed class SetFighterMovementUseCase
    {
        private readonly IProjectRepository repo;

        public void SetFighterMovement(FighterMovementUpdate update)
        {
            Project project = repo.GetProject(update.ProjectId);
            Fighter fighter = (Fighter) project.First((item)=> item is Fighter && (item as Fighter).Id == update.FighterId);
            fighter.UpdateWalk(update.WalkSpeed, update.WalkAccel, update.WalkTurnTime);
        }
    }
}
