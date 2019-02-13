using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Word;
using Word = Microsoft.Office.Interop.Word;
using exercNetLex.Source.Views;
using System;
using exercNetLex.Views;

namespace exercNetLex
{
	public partial class Ribbon1
	{
		//RibbonPresenter RibbonPresenter;
		AddFieldView AddFieldView;
		AddSpanView AddSpanView;
		FrmQualificacao FrmQualificacao;

		RibbonView Rv;

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
			Word.Selection Selecao = Globals.ThisAddIn.Application.Selection;
			if (Selecao.Range.Text != null && Selecao.Range.Text != "")
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
				
		private void BntAddImage_Click(object sender, RibbonControlEventArgs e)
		{
			Rv = new RibbonView();
			Rv.ClickButton_AddImage(sender, (EventArgs)e);
		}

		private void BtnSavePDF_Click(object sender, RibbonControlEventArgs e)
		{
			Rv = new RibbonView();
			Rv.ClickButton_SavePDF(sender, (EventArgs)e);
		}

		private void BntAddTabela_Click(object sender, RibbonControlEventArgs e)
		{
			TableConfigView FormTable = new TableConfigView();
			FormTable.Show();
		}

		private void BntInvertCase_Click(object sender, RibbonControlEventArgs e)
		{
			Rv = new RibbonView();
			Rv.ClickButton_InvertCase(sender, (EventArgs)e);
		}

		private void BntFindAndReplace_Click(object sender, RibbonControlEventArgs e)
		{
			ThisAddIn.IniciarFindAndReplace();
		}

		private void BntAddSpan_Click(object sender, RibbonControlEventArgs e)
		{
			AddSpanView = new AddSpanView();
			AddSpanView.Show();
		}

		private void BntAddField_Click(object sender, RibbonControlEventArgs e)
		{
			AddFieldView = new AddFieldView();
			AddFieldView.Show();
			
		}

		private void BntQualificacao_Click(object sender, RibbonControlEventArgs e)
		{
			FrmQualificacao = new FrmQualificacao();
			FrmQualificacao.Show();
		}
	}
}
