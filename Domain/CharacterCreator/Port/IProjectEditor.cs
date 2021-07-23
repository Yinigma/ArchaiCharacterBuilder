using System;

namespace CharacterCreator.Port
{
	public interface IProjectEditor
	{
		void PushAction(Action changeFunction, Action inverseFunction);

		void UndoEdit();

		void RedoEdit();

	}

}

