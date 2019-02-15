using System;
using WinFormsMvp;
using exercNetLex.Source.Services;
using exercNetLex.Source.Views;

namespace exercNetLex.Presenters
{
	public class QualificationPresenter : Presenter<IQualificationView>
	{
		private IWordService wordService;

		public QualificationPresenter(IQualificationView View) : base(View)
		{
			View.AddQualificacao += View_AddQualificacao;
			View.CloseFormAddQualificacao += View_CloseFormAddQualificacao;
			wordService = WordService.Instance;
		}

		private void View_AddQualificacao(object sender, EventArgs e)
		{
			// Testa se o campo foi preenchido
			if ((View.NomeContatoPJ != null && View.NomeContatoPJ != "") && (View.NomeContatoRep != null && View.NomeContatoRep != ""))
			{
				wordService.AddQualificacao(View.NomeContatoPJ, View.NomeContatoRep);
			}
			else
			{
				if ((View.NomeContatoPJ == null || View.NomeContatoPJ == "") && (View.NomeContatoRep == null || View.NomeContatoRep == ""))
				{
					View.MostrarMsgQualificacao("Campos vazios! Você deve inserir nomes para os Contatos!");
				}
				else
				{
					if (View.NomeContatoPJ == null || View.NomeContatoPJ == "")
					{
						View.MostrarMsgQualificacao("Campo vazio! Você deve inserir um nome para o Contato PJ!");
					}
					if (View.NomeContatoRep == null || View.NomeContatoRep == "")
					{
						View.MostrarMsgQualificacao("Campo vazio! Você deve inserir um nome para o Contato Rep!");
					}
				}
			}

		}

		private void View_CloseFormAddQualificacao(object sender, EventArgs e)
		{
			View.FecharTelaAddQualificacao();
		}

	}
}
