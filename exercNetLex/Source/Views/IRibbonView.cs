using System;
using System.Windows.Forms;
using WinFormsMvp;

namespace exercNetLex.Source.Views
{
	public interface IRibbonView : IView
	{
		event EventHandler AddImage;
		event EventHandler SavePDF;
		event EventHandler InvertCase;
		event EventHandler FindSpan;

		OpenFileDialog Open { get; set; }

		void ClickButton_AddImage(object sender, EventArgs e);
		void ClickButton_SavePDF(object sender, EventArgs e);
		void ClickButton_InvertCase(object sender, EventArgs e);
		void ClickButton_FindSpan(object sender, EventArgs e);

		void MostrarOpenFileDialog();
		string RetornaNomeArquivo();

	}
}
