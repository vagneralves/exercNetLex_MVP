using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp.Forms;

namespace exercNetLex.Source.Views
{
	public partial class RibbonView : MvpForm, IRibbonView
	{
		public event EventHandler AddImage;
		public event EventHandler SavePDF;
		public event EventHandler InvertCase;

		private string NomeArquivo;
		public OpenFileDialog Open { get; set; }

		public RibbonView()
		{
			Open = new OpenFileDialog
			{
				Title = "Escolha a Imagem",
				Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg"
			};
		}

		public void ClickButton_AddImage(object sender, EventArgs e)
		{
			AddImage(sender, e);
		}

		public void ClickButton_SavePDF(object sender, EventArgs e)
		{
			SavePDF(sender, e);
		}

		public void ClickButton_InvertCase(object sender, EventArgs e)
		{
			InvertCase(sender, e);
		}

		public void MostrarOpenFileDialog()
		{
			Open.ShowDialog();
			NomeArquivo = Open.FileName;
		}

		public string RetornaNomeArquivo()
		{
			return NomeArquivo;
		}

	}
}
