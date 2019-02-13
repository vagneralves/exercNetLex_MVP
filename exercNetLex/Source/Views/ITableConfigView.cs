using System;
using WinFormsMvp;

namespace exercNetLex.Views
{
	public interface ITableConfigView : IView
	{
		event EventHandler CreateTable;
		event EventHandler CloseFormTableConfig;

		int NumeroLinhas { get; set; }
		int NumeroColunas { get; set; }

		void FecharTelaTableConfig();
	}
}
