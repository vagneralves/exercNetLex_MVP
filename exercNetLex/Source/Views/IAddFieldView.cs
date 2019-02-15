using System;
using WinFormsMvp;

namespace exercNetLex.Source.Views
{
	public interface IAddFieldView : IView
	{
		event EventHandler AddField;
		event EventHandler CloseFormAddField;

		string ExpressionField { get; set; }

		void FecharTelaAddField();
		void MostrarMsgField(string msg);
	}
}
