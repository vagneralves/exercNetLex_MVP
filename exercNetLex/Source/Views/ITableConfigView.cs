using System;
using WinFormsMvp;

namespace exercNetLex.Views
{
	public interface ITableConfigView : IView
	{
		event EventHandler CreateTable;
		event EventHandler CloseForm;

		int NumeroLinhas { get; set; }
		int NumeroColunas { get; set; }

		void FecharTela();
	}
}
