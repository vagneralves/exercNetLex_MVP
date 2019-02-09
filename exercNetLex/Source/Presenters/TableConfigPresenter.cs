using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsMvp;
using exercNetLex.Views;
using exercNetLex.Source.Services;

namespace exercNetLex.Presenters
{
	public class TableConfigPresenter : Presenter<ITableConfigView>
	{
		private IWordService wordService;

		public TableConfigPresenter(ITableConfigView View) : base(View)
		{
			View.CreateTable += View_CreateTable;
			View.CloseForm += View_CloseForm;
			wordService = WordService.Instance;
		}

		private void View_CloseForm(object sender, EventArgs e)
		{
			View.FecharTela();
		}

		private void View_CreateTable(object sender, EventArgs e)
		{
			wordService.CriarTabela(View.NumeroLinhas, View.NumeroColunas);
		}
	}
}
