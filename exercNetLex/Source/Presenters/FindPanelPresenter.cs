using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using WinFormsMvp;
using exercNetLex.Views;
using exercNetLex.Source.Services;
using exercNetLex.Source.Views;
using System;

namespace exercNetLex.Presenters
{
	public class FindPanelPresenter : Presenter<IFindPanelView>
	{
		private IWordService wordService;

		public FindPanelPresenter(IFindPanelView View) : base(View)
		{
			View.FindNext += View_FindNext;
			View.ReplaceNext += View_ReplaceNext;
			View.ReplaceAll += View_ReplaceAll;
			View.EnableComponetsTextFind += View_EnableComponetsTextFind;
			View.EnableComponetsTextReplace += View_EnableComponetsTextReplace;
			wordService = WordService.Instance;
		}

		private void View_EnableComponetsTextFind(object arg1, EventArgs arg2)
		{
			if (View.TextFind.Length > 0)
			{
				View.TxReplaceEnable = true;
				View.BntFindNextEnable = true;
				View.CheckFindEnable = true;
			}
			else
			{
				View.TxReplaceEnable = false;
				View.BntFindNextEnable = false;
				View.CheckFindEnable = false;
			}
		}

		private void View_EnableComponetsTextReplace(object sender, EventArgs e)
		{
			if (View.TextReplace.Length > 0)
			{
				View.BntReplaceNextEnable = true;
				View.BntReplaceAllEnable = true;
				View.CheckFindEnable = true;
			}
			else
			{
				View.BntReplaceNextEnable = false;
				View.BntReplaceAllEnable = false;
				View.CheckFindEnable = false;
			}
		}

		private void View_FindNext(object sender, EventArgs e)
		{
			if (!wordService.FindNext(View.TextFind, View.CheckFindCase))
			{
				View.MostrarMsgNotFound();
			}
		}

		private void View_ReplaceNext(object sender, EventArgs e)
		{
			if(!wordService.ReplaceNext(View.TextFind, View.TextReplace, View.CheckFindCase))
			{
				View.MostrarMsgNotFound();
			}
		}

		private void View_ReplaceAll(object sender, EventArgs e)
		{
			if(!wordService.ReplaceAll(View.TextFind, View.TextReplace, View.CheckFindCase))
			{
				View.MostrarMsgNotFound();
			}
		}
	}
}
