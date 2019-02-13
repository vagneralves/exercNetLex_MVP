using System;
using WinFormsMvp;

namespace exercNetLex.Source.Views
{
	public interface IAddFieldView : IView
	{
		event EventHandler AddField;
		event EventHandler CloseFormAddField;

		string expressionField { get; set; }

		void FecharTelaAddField();
	}
}
