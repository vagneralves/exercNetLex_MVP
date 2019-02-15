using System;
using WinFormsMvp;
using exercNetLex.Source.Services;
using exercNetLex.Source.Views;
using System.Windows.Forms;

namespace exercNetLex.Presenters
{
	public class AddFieldPresenter : Presenter<IAddFieldView>
	{
		private IWordService wordService;

		public AddFieldPresenter(IAddFieldView View) : base(View)
		{
			View.AddField += View_AddField;
			View.CloseFormAddField += View_CloseFormAddField;
			wordService = WordService.Instance;
		}

		private void View_AddField(object sender, EventArgs e)
		{
			// Testa se o campo foi preenchido
			if (View.ExpressionField != null && View.ExpressionField != "")
			{
				wordService.AddField(View.ExpressionField);
			}
			else
			{
				View.MostrarMsgField("Campo vazio! Você deve inserir uma expressão!");
			}
			
		}

		private void View_CloseFormAddField(object sender, EventArgs e)
		{
			View.FecharTelaAddField();
		}

	}
}
