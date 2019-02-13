using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

using WinFormsMvp;
using exercNetLex.Views;
using exercNetLex.Source.Services;
using exercNetLex.Source.Views;


namespace exercNetLex.Presenters
{ 
	public class RibbonPresenter : Presenter<IRibbonView>
	{
		public Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
		public Word.Selection Selecao = Globals.ThisAddIn.Application.Selection;
		Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
		public Word.Range Range = Globals.ThisAddIn.Application.Selection.Range;

		private IWordService wordService;

		public RibbonPresenter(IRibbonView View) : base(View)
		{
			wordService = WordService.Instance;
			View.AddImage += View_AddImage;
			View.SavePDF += View_SavePDF;
			View.InvertCase += View_InvertCase;
		}

		private void View_InvertCase(object sender, EventArgs e)
		{
			wordService.InvertCase();
		}

		private void View_AddImage(object sender, EventArgs e)
		{
			View.MostrarOpenFileDialog();
			string nomeImg = View.RetornaNomeArquivo();
			wordService.AddImage(nomeImg);
		}

		public void View_SavePDF(object sender, EventArgs e)
		{
			wordService.SavePDF();
		}

		public void InvertCase()
		{
			
		}

		public void AddSpan(string condicao)
		{
			//add o span na selecao
			Range.InsertBefore("[");
			Range.InsertAfter("]");
			Range.Select();
			Range.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
			Range.Start = Range.Start + 1;
			Range.Select();
			Range.InsertBefore(condicao);
			Range.End = Range.Start + condicao.Length;
			Range.Select();
			Range.Application.Selection.Font.Subscript = -1;
		}


		public void AddQualificacao(string nomeContatoPJ, string nomeContatoRep)
		{
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
			AddDeclinaGeneroPJ(nomeContatoPJ);
			Range.InsertAfter(string.Format(" no CNPJ sob o n. {{{0}.CNPJ}}, sediad", nomeContatoPJ));
			AddDeclinaGeneroPJ(nomeContatoPJ);
			Range.InsertAfter(string.Format(" na {{{0}.Logradouro}}, {{{0}.LogradouroNumeroComp}}", nomeContatoPJ));
			AddCondicao(nomeContatoPJ, "LogradouroNumeroComp", "!=", "n.", " ");
			Range.InsertAfter(string.Format("{{{0}.LogradouroNumero}}, ", nomeContatoPJ));
			AddCondicao(nomeContatoPJ, "LogradouroComplemento", "!=", "", string.Format("{{{0}.LogradouroComplemento}}, ", nomeContatoPJ));
			Range.InsertAfter(string.Format("bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{{0}.Estado}}, {{{0}.Pais}}, ", nomeContatoPJ));
			AddCondicao(nomeContatoPJ, "Pais", "=", "Brasil", "CEP");
			AddCondicao(nomeContatoPJ, "Pais", "!=", "Brasil", "Código Postal");
			Range.InsertAfter(string.Format(": {{{0}.CEP}}, neste ato representad", nomeContatoPJ));
			AddDeclinaGeneroPJ(nomeContatoPJ);
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
			AddCondicao(nomeContatoRep, "Sexo", "=", "feminino", "a");
			Range.InsertAfter(" d");
			AddCondicao(nomeContatoRep, "IdentidadeTipo", "=", "Passaporte", "o");
			AddCondicao(nomeContatoRep, "IdentidadeTipo", "!=", "Passaporte", "a");
			Range.InsertAfter(string.Format(" {{{0}.IdentidadeTipo}}, n. {{{0}.IdentidadeNumero}} – " +
				"{{{0}.IdentidadeOrgaoEmissor Formatar \"caixaalta\"}}, inscrit", nomeContatoRep));
			AddDeclinaGeneroRep(nomeContatoRep);
			Range.InsertAfter(string.Format(" no CPF sob o n. {{{0}.CPF}}, residente e domiciliad", nomeContatoRep));
			AddDeclinaGeneroRep(nomeContatoRep);
			Range.InsertAfter(string.Format(" na {{{0}.Logradouro}}, {{{0}.LogradouroNumeroComp}}", nomeContatoRep));
			AddCondicao(nomeContatoRep, "LogradouroNumeroComp", "!=", "n.", " ");
			Range.InsertAfter(string.Format("{{{0}.LogradouroNumero}}, ", nomeContatoRep));
			AddCondicao(nomeContatoRep, "LogradouroComplemento", "!=", "", string.Format("{{{0}.LogradouroComplemento}}, ", nomeContatoRep));
			Range.InsertAfter(string.Format("bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{{0}.Estado}}, {{{0}.Pais}}, ", nomeContatoRep));
			AddCondicao(nomeContatoRep, "Pais", "=", "Brasil", "CEP");
			AddCondicao(nomeContatoRep, "Pais", "!=", "Brasil", "Código Postal");
			Range.InsertAfter(string.Format(": {{{0}.CEP}}", nomeContatoRep));
			Range.SetRange(Range.End, Range.End);
			Range.Select();

			finalRepetirRep = Range.End;

			Range.SetRange(incioRepetirRep, finalRepetirRep);
			// Add o "[repetir numRep pontuacao "; | e |."" no inicio da qualificação de representantes e o "{sinal}]" ao final"
			AddRepetir("numRep");

			// 9 somado ao final corresponde aos simbolos "{sinal}]"
			finalQualificacao = finalRepetirRep + Range.Text.Length + 9;
			Range.SetRange(inicioQualificacao, finalQualificacao);
			Range.Select();
			Range.Application.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
			Range = Documento.Range();
			Range.SetRange(Range.End, Range.End);
			Range.Select();
			//Range.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
		}

		//Metodo generico para adicionar condicao
		public void AddCondicao(string contato, string atributo, string operacao, string comparacao, string resultado)
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
		public void AddRepetir(string numContato)
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
		public void AddDeclinaGeneroPJ(string nomeContatoPJ)
		{
			AddCondicao(nomeContatoPJ, "Genero", "=", "masculino", "o");
			AddCondicao(nomeContatoPJ, "Genero", "=", "feminino", "a");
		}

		//Metodo para inserir declinacao de genero (masculino e feminino) da parte PF
		public void AddDeclinaGeneroRep(string nomeContatoRep)
		{
			AddCondicao(nomeContatoRep, "Sexo", "=", "masculino", "o");
			AddCondicao(nomeContatoRep, "Sexo", "=", "feminino", "a");
		}
	}
}
