using Word = Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;

namespace exercNetLex.Source.Services
{
	class WordService : IWordService
	{
		Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
		Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
		Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
		Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;
		



		private static readonly Lazy<IWordService> instance =
			new Lazy<IWordService>(() => new WordService());

		public static IWordService Instance
		{
			get
			{
				return instance.Value;
			}
		}

		private WordService()
		{
		}
		public bool FindNext(string text)
		{

			object findText = text;
			selection.Find.ClearFormatting();
			selection.Find.Forward = true;
			selection.Find.MatchCase = false;
			selection.Find.Execute(ref findText);

			if (!selection.Find.Found)
			{
				doc.Range(0, 0).Select();
				selection.Find.Execute(ref findText);
				if (!selection.Find.Found)
				{
					return false;
				}
			}
			return true;
		}

		public void CriarTabela(int numLinhas, int numColunas)
		{

			selection.Collapse();

			// Add a tabela, formata e coloca bordas na tabela
			selection.Tables.Add(selection.Range, numLinhas, numColunas, Word.WdLineStyle.wdLineStyleSingle);
		}

		public void AddImage(string nomeImg)
		{

			selection.Collapse();
			//Add a imagem no documento
			selection.InlineShapes.AddPicture(nomeImg);
			//Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(nomeImg);
		}

		public void SavePDF()
		{
			try
			{
				object name = Path.GetTempPath() + @"\\" + doc.Name + ".pdf";
				doc.ExportAsFixedFormat((string)name, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		public void InvertCase()
		{
			for(int i = 1; i <= selecao.Characters.Count; i++)
			{
				if(selecao.Characters[i].Case == Word.WdCharacterCase.wdLowerCase)
				{
					selecao.Characters[i].Case = Word.WdCharacterCase.wdUpperCase;
				}
				else
				{
					selecao.Characters[i].Case = Word.WdCharacterCase.wdLowerCase;
				}
			}
		}

		public void AddField(string expression)
		{
			Word.Range RangeField = Globals.ThisAddIn.Application.Selection.Range;
			
			//add o field entre "{}"
			RangeField.Delete();
			RangeField.InsertBefore(string.Format("{{{0}}}", expression));
			RangeField.Select();
			RangeField.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
		}

		public void AddSpan(string expression)
		{
			Word.Range RangeSpan = Globals.ThisAddIn.Application.Selection.Range;
			//add o span na selecao
			RangeSpan.InsertBefore("[");
			RangeSpan.InsertAfter("]");
			RangeSpan.Select();
			RangeSpan.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
			RangeSpan.Start = RangeSpan.Start + 1;
			RangeSpan.Select();
			RangeSpan.InsertBefore(expression);
			RangeSpan.End = RangeSpan.Start + expression.Length;
			RangeSpan.Select();
			RangeSpan.Application.Selection.Font.Subscript = -1;
		}
	}
}
