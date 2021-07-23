using System;

namespace CharacterCreator.Port
{
	public interface IScriptEditor
	{
		void PushAction(Func changeFunction, Func inverseFunction);

		void UndoEdit();

		void RedoEdit();

	}

}

