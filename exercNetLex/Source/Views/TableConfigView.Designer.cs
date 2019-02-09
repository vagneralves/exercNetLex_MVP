namespace exercNetLex
{
	partial class TableConfigView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableConfigView));
			this.BntAddTableOK = new System.Windows.Forms.Button();
			this.NumLinhas = new System.Windows.Forms.Label();
			this.NumColunas = new System.Windows.Forms.Label();
			this.NudNumColunas = new System.Windows.Forms.NumericUpDown();
			this.NudNumLinhas = new System.Windows.Forms.NumericUpDown();
			this.BntAddTableCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NudNumColunas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NudNumLinhas)).BeginInit();
			this.SuspendLayout();
			// 
			// BntAddTableOK
			// 
			this.BntAddTableOK.Location = new System.Drawing.Point(147, 93);
			this.BntAddTableOK.Name = "BntAddTableOK";
			this.BntAddTableOK.Size = new System.Drawing.Size(75, 23);
			this.BntAddTableOK.TabIndex = 0;
			this.BntAddTableOK.Text = "OK";
			this.BntAddTableOK.UseVisualStyleBackColor = true;
			this.BntAddTableOK.Click += new System.EventHandler(this.BntAddTableOK_Click);
			// 
			// NumLinhas
			// 
			this.NumLinhas.AutoSize = true;
			this.NumLinhas.Location = new System.Drawing.Point(9, 56);
			this.NumLinhas.Name = "NumLinhas";
			this.NumLinhas.Size = new System.Drawing.Size(96, 13);
			this.NumLinhas.TabIndex = 1;
			this.NumLinhas.Text = "Número de Linhas:";
			// 
			// NumColunas
			// 
			this.NumColunas.AutoSize = true;
			this.NumColunas.Location = new System.Drawing.Point(9, 24);
			this.NumColunas.Name = "NumColunas";
			this.NumColunas.Size = new System.Drawing.Size(103, 13);
			this.NumColunas.TabIndex = 2;
			this.NumColunas.Text = "Número de Colunas:";
			// 
			// NudNumColunas
			// 
			this.NudNumColunas.Location = new System.Drawing.Point(118, 17);
			this.NudNumColunas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NudNumColunas.Name = "NudNumColunas";
			this.NudNumColunas.Size = new System.Drawing.Size(40, 20);
			this.NudNumColunas.TabIndex = 5;
			this.NudNumColunas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// NudNumLinhas
			// 
			this.NudNumLinhas.Location = new System.Drawing.Point(118, 49);
			this.NudNumLinhas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NudNumLinhas.Name = "NudNumLinhas";
			this.NudNumLinhas.Size = new System.Drawing.Size(40, 20);
			this.NudNumLinhas.TabIndex = 6;
			this.NudNumLinhas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// BntAddTableCancel
			// 
			this.BntAddTableCancel.Location = new System.Drawing.Point(11, 93);
			this.BntAddTableCancel.Name = "BntAddTableCancel";
			this.BntAddTableCancel.Size = new System.Drawing.Size(75, 23);
			this.BntAddTableCancel.TabIndex = 7;
			this.BntAddTableCancel.Text = "Cancelar";
			this.BntAddTableCancel.UseVisualStyleBackColor = true;
			this.BntAddTableCancel.Click += new System.EventHandler(this.BntAddTableCancel_Click);
			// 
			// TableConfigView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 127);
			this.Controls.Add(this.BntAddTableCancel);
			this.Controls.Add(this.NudNumLinhas);
			this.Controls.Add(this.NudNumColunas);
			this.Controls.Add(this.NumColunas);
			this.Controls.Add(this.NumLinhas);
			this.Controls.Add(this.BntAddTableOK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TableConfigView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inserir Tabela";
			this.Load += new System.EventHandler(this.TableConfigView_Load);
			((System.ComponentModel.ISupportInitialize)(this.NudNumColunas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NudNumLinhas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BntAddTableOK;
		private System.Windows.Forms.Label NumLinhas;
		private System.Windows.Forms.Label NumColunas;
		public System.Windows.Forms.NumericUpDown NudNumColunas;
		public System.Windows.Forms.NumericUpDown NudNumLinhas;
		private System.Windows.Forms.Button BntAddTableCancel;
	}
}