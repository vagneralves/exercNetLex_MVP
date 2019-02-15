using Word = Microsoft.Office.Interop.Word;
using System;
using System.IO;

namespace exercNetLex.Source.Services
{
	class WordService : IWordService
	{

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

		public void CriarTabela(int numLinhas, int numColunas)
		{
			Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;

			selection.Collapse();

			// Add a tabela, formata e coloca bordas na tabela
			selection.Tables.Add(selection.Range, numLinhas, numColunas, Word.WdLineStyle.wdLineStyleSingle);
		}

		public void AddImage(string nomeImg)
		{
			Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;

			selection.Collapse();
			//Add a imagem no documento
			selection.InlineShapes.AddPicture(nomeImg);
			//Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(nomeImg);
		}

		public void SavePDF()
		{
			Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

			object name = Path.GetTempPath() + @"\\" + doc.Name + ".pdf";
			doc.ExportAsFixedFormat((string)name, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
		}

		public void InvertCase()
		{
			Word.Selection selecao = Globals.ThisAddIn.Application.Selection;

			for (int i = 1; i <= selecao.Characters.Count; i++)
			{
				if (selecao.Characters[i].Case == Word.WdCharacterCase.wdLowerCase)
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
			//RangeField.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
		}

		public void AddSpan(string expression)
		{
			Word.Range RangeSpan = Globals.ThisAddIn.Application.Selection.Range;
			//add o span na selecao
			RangeSpan.InsertBefore("[");
			RangeSpan.InsertAfter("]");
			RangeSpan.Select();
			//RangeSpan.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
			RangeSpan.Start = RangeSpan.Start + 1;
			RangeSpan.Select();
			RangeSpan.InsertBefore(expression);
			RangeSpan.End = RangeSpan.Start + expression.Length;
			RangeSpan.Select();
			RangeSpan.Application.Selection.Font.Subscript = -1;
		}

		public void AddQualificacao(string nomeContatoPJ, string nomeContatoRep)
		{
			Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
			Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
			Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
			Word.Range Range = Globals.ThisAddIn.Application.Selection.Range;

			if (selecao.Characters.Count > 1)
			{
				selecao.Delete();
				Range = selection.Range;
			}
			//variaveis para marcar inicio e final da qualificacao e do repetir do representate (para adicionar a condicao)
			int inicioQualificacao, finalQualificacao, incioRepetirRep, finalRepetirRep;

			inicioQualificacao = Range.Start;

			// Bloco de codigo para inserir a parte PJ
			Range.InsertAfter(string.Format("{{{0}.RazaoSocial Formatar \"caixaalta\"}}", nomeContatoPJ));
			Range.Font.Bold = 1;
			Range.SetRange(Range.End, Range.End);
			Range.InsertAfter(string.Format(", {{{0}.Tipo}}, inscrit", nomeContatoPJ));
			Range.Font.Bold = 0;
			Range.SetRange(Range.End, Range.End);
			AddDeclinaGeneroPJ(nomeContatoPJ, Range);
			Range.InsertAfter(string.Format(" no CNPJ sob o n. {{{0}.CNPJ}}, sediad", nomeContatoPJ));
			AddDeclinaGeneroPJ(nomeContatoPJ, Range);
			Range.InsertAfter(string.Format(" na {{{0}.Logradouro}}, {{{0}.LogradouroNumeroComp}}", nomeContatoPJ));
			AddCondicao(nomeContatoPJ, "LogradouroNumeroComp", "!=", "n.", " ", Range);
			Range.InsertAfter(string.Format("{{{0}.LogradouroNumero}}, ", nomeContatoPJ));
			AddCondicao(nomeContatoPJ, "LogradouroComplemento", "!=", "", string.Format("{{{0}.LogradouroComplemento}}, ", nomeContatoPJ), Range);
			Range.InsertAfter(string.Format("bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{{0}.Estado}}, {{{0}.Pais}}, ", nomeContatoPJ));
			AddCondicao(nomeContatoPJ, "Pais", "=", "Brasil", "CEP", Range);
			AddCondicao(nomeContatoPJ, "Pais", "!=", "Brasil", "Código Postal", Range);
			Range.InsertAfter(string.Format(": {{{0}.CEP}}, neste ato representad", nomeContatoPJ));
			AddDeclinaGeneroPJ(nomeContatoPJ, Range);
			Range.InsertAfter(" por ");
			Range.SetRange(Range.End, Range.End);

			incioRepetirRep = Range.Start;

			// Bloco de codigo para inserir a parte Representante (PF)
			Range.InsertAfter(string.Format("{{{0}.Nome formatar \"caixaalta\"}}", nomeContatoRep));
			Range.Font.Bold = 1;
			Range.SetRange(Range.End, Range.End);
			Range.InsertAfter(string.Format(", {{{0}.Nacionalidade}}, {{{0}.EstadoCivil}}, {{{0}.Profissao}}, portador", nomeContatoRep));
			Range.Font.Bold = 0;
			Range.SetRange(Range.End, Range.End);
			AddCondicao(nomeContatoRep, "Sexo", "=", "feminino", "a", Range);
			Range.InsertAfter(" d");
			AddCondicao(nomeContatoRep, "IdentidadeTipo", "=", "Passaporte", "o", Range);
			AddCondicao(nomeContatoRep, "IdentidadeTipo", "!=", "Passaporte", "a", Range);
			Range.InsertAfter(string.Format(" {{{0}.IdentidadeTipo}}, n. {{{0}.IdentidadeNumero}} – " +
				"{{{0}.IdentidadeOrgaoEmissor Formatar \"caixaalta\"}}, inscrit", nomeContatoRep));
			AddDeclinaGeneroRep(nomeContatoRep, Range);
			Range.InsertAfter(string.Format(" no CPF sob o n. {{{0}.CPF}}, residente e domiciliad", nomeContatoRep));
			AddDeclinaGeneroRep(nomeContatoRep, Range);
			Range.InsertAfter(string.Format(" na {{{0}.Logradouro}}, {{{0}.LogradouroNumeroComp}}", nomeContatoRep));
			AddCondicao(nomeContatoRep, "LogradouroNumeroComp", "!=", "n.", " ", Range);
			Range.InsertAfter(string.Format("{{{0}.LogradouroNumero}}, ", nomeContatoRep));
			AddCondicao(nomeContatoRep, "LogradouroComplemento", "!=", "", string.Format("{{{0}.LogradouroComplemento}}, ", nomeContatoRep), Range);
			Range.InsertAfter(string.Format("bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{{0}.Estado}}, {{{0}.Pais}}, ", nomeContatoRep));
			AddCondicao(nomeContatoRep, "Pais", "=", "Brasil", "CEP", Range);
			AddCondicao(nomeContatoRep, "Pais", "!=", "Brasil", "Código Postal", Range);
			Range.InsertAfter(string.Format(": {{{0}.CEP}}", nomeContatoRep));
			Range.SetRange(Range.End, Range.End);
			Range.Select();

			finalRepetirRep = Range.End;

			Range.SetRange(incioRepetirRep, finalRepetirRep);
			// Add o "[repetir numRep pontuacao "; | e |."" no inicio da qualificação de representantes e o "{sinal}]" ao final"
			AddRepetir("numRep", Range);

			// 9 somado ao final corresponde aos simbolos "{sinal}]"
			finalQualificacao = finalRepetirRep + Range.Text.Length + 9;
			Range.SetRange(inicioQualificacao, finalQualificacao);
			Range.Select();
			Range.Application.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
			Range = doc.Range();
			Range.SetRange(Range.End, Range.End);
			Range.Select();
			//Range.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
		}

		//Metodo generico para adicionar condicao
		public void AddCondicao(string contato, string atributo, string operacao, string comparacao, string resultado, Word.Range Range)
		{
			Word.Range RangeCondicao = Range;
			RangeCondicao.SetRange(Range.End, Range.End);

			string condicao = string.Format("{0}.{1} {2} \"{3}\"{4}", contato, atributo, operacao, comparacao, resultado);

			RangeCondicao.Select();
			RangeCondicao.Application.Selection.Font.Subscript = 0;
			RangeCondicao.InsertAfter("[");
			RangeCondicao.Start = RangeCondicao.Start + 1;
			RangeCondicao.Select();
			RangeCondicao.InsertAfter(condicao);
			RangeCondicao.End = Range.Start + condicao.Length;
			RangeCondicao.Select();
			RangeCondicao.Application.Selection.Font.Subscript = -1;
			RangeCondicao.SetRange(RangeCondicao.End - resultado.Length, RangeCondicao.End);
			RangeCondicao.Select();
			RangeCondicao.Application.Selection.Font.Subscript = 0;
			RangeCondicao.InsertAfter("]");
			RangeCondicao.Select();
			RangeCondicao.Application.Selection.Font.Subscript = 0;
			RangeCondicao.SetRange(RangeCondicao.End, RangeCondicao.End);
			RangeCondicao.Select();

			Range.SetRange(RangeCondicao.End, RangeCondicao.End);
		}

		//Metodo generico para adicionar repetir
		public void AddRepetir(string numContato, Word.Range Range)
		{
			Word.Range RangeRepetir = Range;

			string repetir = string.Format("repetir 1 até {0} pontuacao \"; |; e |.\"", numContato);

			RangeRepetir.InsertBefore("[");
			RangeRepetir.InsertAfter("{sinal}]");
			RangeRepetir.Select();
			RangeRepetir.Start = RangeRepetir.Start + 1;
			RangeRepetir.Select();
			RangeRepetir.InsertBefore(repetir);
			RangeRepetir.End = RangeRepetir.Start + repetir.Length;
			RangeRepetir.Select();
			RangeRepetir.Application.Selection.Font.Subscript = -1;
		}

		//Metodo para inserir declinacao de genero (masculino e feminino) da parte PJ
		public void AddDeclinaGeneroPJ(string nomeContatoPJ, Word.Range Range)
		{
			AddCondicao(nomeContatoPJ, "Genero", "=", "masculino", "o", Range);
			AddCondicao(nomeContatoPJ, "Genero", "=", "feminino", "a", Range);
		}

		//Metodo para inserir declinacao de genero (masculino e feminino) da parte PF
		public void AddDeclinaGeneroRep(string nomeContatoRep, Word.Range Range)
		{
			AddCondicao(nomeContatoRep, "Sexo", "=", "masculino", "o", Range);
			AddCondicao(nomeContatoRep, "Sexo", "=", "feminino", "a", Range);
		}

		public bool FindNext(string texto, bool caseSensitve)
		{
			Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
			Word.Selection Selecao = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;

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
					return false;
				}
			}
			return true;
		}

		public bool ReplaceNext(string textFind, string textReplace, bool caseSensitve)
		{
			Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
			Word.Selection Selecao = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;

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
					return false;
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
			return true;
		}


		public bool ReplaceAll(string textFind, string textReplace, bool caseSensitve)
		{
			Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
			Word.Selection Selecao = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;

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
					return false;
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
			return true;
		}
	}
}
