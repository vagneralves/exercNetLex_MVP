namespace exercNetLex
{
	public partial class ThisAddIn
	{
		private FindPanel FindPanel;
		private static Microsoft.Office.Tools.CustomTaskPane CustomTaskPane;

		private void ThisAddIn_Startup(object sender, System.EventArgs e)
		{
			FindPanel = new FindPanel();
			CustomTaskPane = this.CustomTaskPanes.Add(FindPanel, "Revisão");
			CustomTaskPane.Width = 255;
			
		}

		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
		{
		}

		public static void IniciarFindAndReplace()
		{
			CustomTaskPane.Visible = !CustomTaskPane.Visible;
		}

		#region Código gerado por VSTO

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(ThisAddIn_Startup);
			this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
		}

		#endregion
	}
}
