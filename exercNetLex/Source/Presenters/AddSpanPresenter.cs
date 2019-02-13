using System;
using WinFormsMvp;
using exercNetLex.Source.Services;
using exercNetLex.Source.Views;
using System.Windows.Forms;

namespace exercNetLex.Presenters
{
	public class AddSpanPresenter : Presenter<IAddSpanView>
	{
		private IWordService wordService;

		public AddSpanPresenter(IAddSpanView View) : base(View)
		{
			View.AddSpan += View_AddSpan;
			View.CloseFormAddSpan += View_CloseFormAddSpan;
			wordService = WordService.Instance;
		}

		private void View_AddSpan(object sender, EventArgs e)
		{
			// Testa se o campo foi preenchido
			if (View.expressionSpan != null && View.expressionSpan != "")
			{
				wordService.AddSpan(View.expressionSpan);
			}
			else
			{
				MessageBox.Show("Campo vazio! Você deve inserir uma expressão!");
			}

		}

		private void View_CloseFormAddSpan(object sender, EventArgs e)
		{
			View.FecharTelaAddSpan();
		}

	}
}
