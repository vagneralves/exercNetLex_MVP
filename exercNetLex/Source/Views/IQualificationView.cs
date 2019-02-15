using System;
using WinFormsMvp;

namespace exercNetLex.Source.Views
{
	public interface IQualificationView : IView
	{
		event EventHandler AddQualificacao;
		event EventHandler CloseFormAddQualificacao;

		string NomeContatoPJ { get; set; }
		string NomeContatoRep { get; set; }

		void FecharTelaAddQualificacao();

		void MostrarMsgQualificacao(string msg);
	}
}
