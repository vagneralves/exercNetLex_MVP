using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace exercNetLex
{
	public class FindPanelPresenter
	{
		FindPanel Fp;

		public static Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
		public Word.Selection Selecao = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;


		public void FindNext(string texto, bool caseSensitve)
		{
			object objText = texto;
			Selecao.Find.ClearFormatting();
			Selecao.Find.Forward = true;
			Selecao.Find.MatchCase = caseSensitve;
			Selecao.Find.Execute(objText);

			if (!Selecao.Find.Found)
			{
				Documento.Range(0, 0).Select();
				Selecao.Find.Execute(objText);
				if (!Selecao.Find.Found)
				{
					MessageBox.Show("Não foram encontradas ocorrências!");
				}
			}
		}

		public void ReplaceNext(string textFind, string textReplace, bool caseSensitve)
		{
			object objText = textFind;
			Selecao.Find.ClearFormatting();
			Selecao.Find.Forward = true;
			Selecao.Find.MatchCase = caseSensitve;
			Selecao.Find.Execute(objText);

			if (!Selecao.Find.Found)
			{
				Documento.Range(0, 0).Select();
				Selecao.Find.Execute(objText);
				if (!Selecao.Find.Found)
				{
					MessageBox.Show("Não foram encontradas ocorrências!");
				}
				else
				{
					Selecao.TypeText(textReplace);
				}
			}
			else
			{
				Selecao.TypeText(textReplace);
			}
		}


		public void ReplaceAll(string textFind, string textReplace, bool caseSensitve)
		{
			object objText = textFind;
			Selecao.Find.ClearFormatting();
			Selecao.Find.Forward = true;
			Selecao.Find.MatchCase = caseSensitve;
			Selecao.Find.Execute(objText);

			
			if (!Selecao.Find.Found)
			{
				Documento.Range(0, 0).Select();
				Selecao.Find.Execute(objText);

				if (!Selecao.Find.Found)
				{
					MessageBox.Show("Não foram encontradas ocorrências!");
				}
				else
				{
					while (Selecao.Find.Found)
					{
						Selecao.TypeText(textReplace);
						Selecao.Find.Execute(objText);
					}
				}
			}
			else
			{
				while (Selecao.Find.Found)
				{
					Selecao.TypeText(textReplace);
					Selecao.Find.Execute(objText);
				}
				Documento.Range(0, 0).Select();
				Selecao.Find.Execute(objText);
				while (Selecao.Find.Found)
				{
					Selecao.TypeText(textReplace);
					Selecao.Find.Execute(objText);
				}
			}
		}
	}
}
