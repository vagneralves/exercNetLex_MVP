using System;
using WinFormsMvp;

namespace exercNetLex.Source.Views
{
	public interface IAddSpanView : IView
	{
		event EventHandler AddSpan;
		event EventHandler CloseFormAddSpan;

		string ExpressionSpan { get; set; }

		void FecharTelaAddSpan();
		void MostrarMsgSpan(string msg);
	}
}
