using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using WinFormsMvp;
using exercNetLex.Source.Services;
using exercNetLex.Source.Views;


namespace exercNetLex.Presenters
{ 
	public class RibbonPresenter : Presenter<IRibbonView>
	{

		private IWordService wordService;
		public FindPanelView FindPanel;
		

		public RibbonPresenter(IRibbonView View) : base(View)
		{
			wordService = WordService.Instance;
			View.AddImage += View_AddImage;
			View.SavePDF += View_SavePDF;
			View.InvertCase += View_InvertCase;
			View.FindSpan += View_FindSpan;
		}

		private void View_FindSpan(object sender, EventArgs e)
		{
			wordService.FindSpan();
		}

		private void View_InvertCase(object sender, EventArgs e)
		{
			wordService.InvertCase();
		}

		private void View_AddImage(object sender, EventArgs e)
		{
			View.MostrarOpenFileDialog();
			string nomeImg = View.RetornaNomeArquivo();

			if (nomeImg != null && nomeImg != "")
			{
				wordService.AddImage(nomeImg);
			}
		}

		public void View_SavePDF(object sender, EventArgs e)
		{
			wordService.SavePDF();
		}
	}
}
