using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Port
{
    interface IGameEnvironment
    {
        void StartGame();

        void SuspendGame();

        void ResumeGame();

        void EndGame();

        void AddGameObject();

        void RemoveGameObject();
    }
}
