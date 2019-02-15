namespace exercNetLex
{
	partial class FindPanelView
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxFind = new System.Windows.Forms.TextBox();
			this.LbFind = new System.Windows.Forms.Label();
			this.BntFindNext = new System.Windows.Forms.Button();
			this.checkFind = new System.Windows.Forms.CheckBox();
			this.TxReplace = new System.Windows.Forms.TextBox();
			this.LbReplace = new System.Windows.Forms.Label();
			this.BntReplaceNext = new System.Windows.Forms.Button();
			this.BntReplaceAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxFind
			// 
			this.TxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxFind.Location = new System.Drawing.Point(14, 30);
			this.TxFind.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.TxFind.Name = "TxFind";
			this.TxFind.Size = new System.Drawing.Size(206, 21);
			this.TxFind.TabIndex = 0;
			this.TxFind.TextChanged += new System.EventHandler(this.TxFind_TextChanged);
			// 
			// LbFind
			// 
			this.LbFind.AutoSize = true;
			this.LbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LbFind.Location = new System.Drawing.Point(15, 60);
			this.LbFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LbFind.Name = "LbFind";
			this.LbFind.Size = new System.Drawing.Size(53, 13);
			this.LbFind.TabIndex = 1;
			this.LbFind.Text = "Find what";
			// 
			// BntFindNext
			// 
			this.BntFindNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BntFindNext.Enabled = false;
			this.BntFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BntFindNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BntFindNext.Location = new System.Drawing.Point(18, 205);
			this.BntFindNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.BntFindNext.Name = "BntFindNext";
			this.BntFindNext.Size = new System.Drawing.Size(92, 26);
			this.BntFindNext.TabIndex = 2;
			this.BntFindNext.Text = "Find Next";
			this.BntFindNext.UseVisualStyleBackColor = false;
			this.BntFindNext.EnabledChanged += new System.EventHandler(this.TxFind_TextChanged);
			this.BntFindNext.Click += new System.EventHandler(this.BntFindNext_Click);
			// 
			// checkFind
			// 
			this.checkFind.AutoSize = true;
			this.checkFind.Enabled = false;
			this.checkFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.checkFind.Location = new System.Drawing.Point(16, 160);
			this.checkFind.Name = "checkFind";
			this.checkFind.Size = new System.Drawing.Size(107, 19);
			this.checkFind.TabIndex = 3;
			this.checkFind.Text = "Case-Sensitive";
			this.checkFind.UseVisualStyleBackColor = true;
			// 
			// TxReplace
			// 
			this.TxReplace.Enabled = false;
			this.TxReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxReplace.Location = new System.Drawing.Point(14, 91);
			this.TxReplace.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.TxReplace.Name = "TxReplace";
			this.TxReplace.Size = new System.Drawing.Size(204, 21);
			this.TxReplace.TabIndex = 4;
			this.TxReplace.TextChanged += new System.EventHandler(this.TxReplace_TextChanged);
			// 
			// LbReplace
			// 
			this.LbReplace.AutoSize = true;
			this.LbReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbReplace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LbReplace.Location = new System.Drawing.Point(15, 121);
			this.LbReplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LbReplace.Name = "LbReplace";
			this.LbReplace.Size = new System.Drawing.Size(62, 13);
			this.LbReplace.TabIndex = 5;
			this.LbReplace.Text = "Replace for";
			// 
			// BntReplaceNext
			// 
			this.BntReplaceNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BntReplaceNext.Enabled = false;
			this.BntReplaceNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BntReplaceNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BntReplaceNext.Location = new System.Drawing.Point(126, 205);
			this.BntReplaceNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.BntReplaceNext.Name = "BntReplaceNext";
			this.BntReplaceNext.Size = new System.Drawing.Size(92, 26);
			this.BntReplaceNext.TabIndex = 6;
			this.BntReplaceNext.Text = "Replace Next";
			this.BntReplaceNext.UseVisualStyleBackColor = false;
			this.BntReplaceNext.Click += new System.EventHandler(this.BntReplaceNext_Click);
			// 
			// BntReplaceAll
			// 
			this.BntReplaceAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BntReplaceAll.Enabled = false;
			this.BntReplaceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BntReplaceAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BntReplaceAll.Location = new System.Drawing.Point(72, 247);
			this.BntReplaceAll.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.BntReplaceAll.Name = "BntReplaceAll";
			this.BntReplaceAll.Size = new System.Drawing.Size(92, 26);
			this.BntReplaceAll.TabIndex = 7;
			this.BntReplaceAll.Text = "Replace All";
			this.BntReplaceAll.UseVisualStyleBackColor = false;
			this.BntReplaceAll.Click += new System.EventHandler(this.BntReplaceAll_Click);
			// 
			// FindPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.Controls.Add(this.BntReplaceAll);
			this.Controls.Add(this.BntReplaceNext);
			this.Controls.Add(this.LbReplace);
			this.Controls.Add(this.TxReplace);
			this.Controls.Add(this.checkFind);
			this.Controls.Add(this.BntFindNext);
			this.Controls.Add(this.LbFind);
			this.Controls.Add(this.TxFind);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.Name = "FindPanel";
			this.Size = new System.Drawing.Size(239, 417);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LbFind;
		private System.Windows.Forms.Button BntFindNext;
		public System.Windows.Forms.TextBox TxFind;
		private System.Windows.Forms.CheckBox checkFind;
		public System.Windows.Forms.TextBox TxReplace;
		private System.Windows.Forms.Label LbReplace;
		private System.Windows.Forms.Button BntReplaceNext;
		private System.Windows.Forms.Button BntReplaceAll;
	}
}
