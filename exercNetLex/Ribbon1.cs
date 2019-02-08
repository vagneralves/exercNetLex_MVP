using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Word;


namespace exercNetLex
{
	public partial class Ribbon1
	{
		RibbonPresenter RibbonPresenter;
		FrmAddField FrmAddField;
		FrmAddSpan FrmAddSpan;
		FrmQualificacao FrmQualificacao;

		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{
			Globals.ThisAddIn.Application.DocumentChange += Application_DocumentChange;
		}

		private void Application_DocumentChange()
		{
			if (Globals.ThisAddIn.Application.Documents.Count != 0)
			{
				var vstoDoc = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
				vstoDoc.SelectionChange += VstoDoc_SelectionChange;
			}
		}

		private void VstoDoc_SelectionChange(object sender, SelectionEventArgs e)
		{
			RibbonPresenter = new RibbonPresenter();

			RibbonPresenter.Selecao = Globals.ThisAddIn.Application.Selection;
			if (RibbonPresenter.Selecao.Range.Text != null && RibbonPresenter.Selecao.Range.Text != "")
			{
				BntInvertCase.Enabled = true;
				BntAddSpan.Enabled = true;
			}
			else
			{
				BntInvertCase.Enabled = false;
				BntAddSpan.Enabled = false;
			}
		}

		private void BtnSavePDF_Click(object sender, RibbonControlEventArgs e)
		{
			RibbonPresenter = new RibbonPresenter();
			RibbonPresenter.SavePDF();
		}

		private void BntAddImage_Click(object sender, RibbonControlEventArgs e)
		{
			//Configuração do openDialog
			dlgImg.InitialDirectory = @"C:\Users\Netlex\Desktop\exercNetLex\";
			dlgImg.Title = "Escolha a Imagem";
			dlgImg.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

			//Mostra o openDialog e seta a stringo com o nome da imagem
			dlgImg.ShowDialog();
			string nomeImg = dlgImg.FileName;

			RibbonPresenter = new RibbonPresenter();
			RibbonPresenter.AddImage(nomeImg);
		}

		private void BntAddTabela_Click(object sender, RibbonControlEventArgs e)
		{
			//Mostra a tela de configuração da tabela
			TableConfigView FormTable = new TableConfigView();
			FormTable.Show();
		}

		private void BntInvertCase_Click(object sender, RibbonControlEventArgs e)
		{
			RibbonPresenter = new RibbonPresenter();
			RibbonPresenter.InvertCase();
		}

		private void BntFindAndReplace_Click(object sender, RibbonControlEventArgs e)
		{
			ThisAddIn.IniciarFindAndReplace();
		}

		private void BntAddSpan_Click(object sender, RibbonControlEventArgs e)
		{
			FrmAddSpan = new FrmAddSpan();
			FrmAddSpan.Show();
		}

		private void BntAddField_Click(object sender, RibbonControlEventArgs e)
		{
			FrmAddField = new FrmAddField();
			FrmAddField.Show();
			
		}

		private void BntQualificacao_Click(object sender, RibbonControlEventArgs e)
		{
			FrmQualificacao = new FrmQualificacao();
			FrmQualificacao.Show();
		}
	}
}
