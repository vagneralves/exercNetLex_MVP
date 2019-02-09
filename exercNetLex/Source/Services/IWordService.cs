namespace exercNetLex.Source.Services
{
	public interface IWordService
	{
		bool FindNext(string text);
		void CriarTabela(int numLinhas, int numColunas);
	}
}
