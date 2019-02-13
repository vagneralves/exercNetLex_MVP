namespace exercNetLex.Source.Services
{
	public interface IWordService
	{
		bool FindNext(string text);
		void CriarTabela(int numLinhas, int numColunas);
		void AddImage(string nomeImg);
		void SavePDF();
		void InvertCase();
		void AddField(string expression);
		void AddSpan(string expression);
	}
}
