using System;
using WinFormsMvp;

namespace exercNetLex.Source.Views
{
	public interface IAddSpanView : IView
	{
		event EventHandler AddSpan;
		event EventHandler CloseFormAddSpan;

		string expressionSpan { get; set; }

		void FecharTelaAddSpan();
	}
}
