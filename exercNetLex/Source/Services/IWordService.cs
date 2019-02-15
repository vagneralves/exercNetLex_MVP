namespace exercNetLex.Source.Services
{
	public interface IWordService
	{
		void CriarTabela(int numLinhas, int numColunas);
		void AddImage(string nomeImg);
		void SavePDF();
		void InvertCase();
		void AddField(string expression);
		void AddSpan(string expression);
		void AddQualificacao(string nomeContatoPJ, string nomeContatoRep);
		bool FindNext(string texto, bool caseSensitve);
		bool ReplaceNext(string textFind, string textReplace, bool caseSensitve);
		bool ReplaceAll(string textFind, string textReplace, bool caseSensitve);
	}
}
