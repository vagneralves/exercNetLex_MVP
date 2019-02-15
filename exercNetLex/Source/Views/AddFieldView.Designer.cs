namespace exercNetLex.Views
{
	partial class AddFieldView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFieldView));
			this.TxtAddField = new System.Windows.Forms.TextBox();
			this.LblAddField = new System.Windows.Forms.Label();
			this.BntAddFieldCancel = new System.Windows.Forms.Button();
			this.BntAddFieldOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtAddField
			// 
			this.TxtAddField.Location = new System.Drawing.Point(26, 52);
			this.TxtAddField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TxtAddField.Name = "TxtAddField";
			this.TxtAddField.Size = new System.Drawing.Size(198, 20);
			this.TxtAddField.TabIndex = 0;
			// 
			// LblAddField
			// 
			this.LblAddField.AutoSize = true;
			this.LblAddField.Location = new System.Drawing.Point(24, 28);
			this.LblAddField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAddField.Name = "LblAddField";
			this.LblAddField.Size = new System.Drawing.Size(97, 13);
			this.LblAddField.TabIndex = 1;
			this.LblAddField.Text = "Digite a expressão:";
			// 
			// BntAddFieldCancel
			// 
			this.BntAddFieldCancel.Location = new System.Drawing.Point(26, 101);
			this.BntAddFieldCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BntAddFieldCancel.Name = "BntAddFieldCancel";
			this.BntAddFieldCancel.Size = new System.Drawing.Size(56, 19);
			this.BntAddFieldCancel.TabIndex = 2;
			this.BntAddFieldCancel.Text = "Cancelar";
			this.BntAddFieldCancel.UseVisualStyleBackColor = true;
			this.BntAddFieldCancel.Click += new System.EventHandler(this.BntAddFieldCancel_Click);
			// 
			// BntAddFieldOk
			// 
			this.BntAddFieldOk.Location = new System.Drawing.Point(166, 101);
			this.BntAddFieldOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BntAddFieldOk.Name = "BntAddFieldOk";
			this.BntAddFieldOk.Size = new System.Drawing.Size(56, 19);
			this.BntAddFieldOk.TabIndex = 3;
			this.BntAddFieldOk.Text = "OK";
			this.BntAddFieldOk.UseVisualStyleBackColor = true;
			this.BntAddFieldOk.Click += new System.EventHandler(this.BntAddFieldOk_Click);
			// 
			// AddFieldView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 144);
			this.Controls.Add(this.BntAddFieldOk);
			this.Controls.Add(this.BntAddFieldCancel);
			this.Controls.Add(this.LblAddField);
			this.Controls.Add(this.TxtAddField);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AddFieldView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Field";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LblAddField;
		private System.Windows.Forms.Button BntAddFieldCancel;
		private System.Windows.Forms.Button BntAddFieldOk;
		public System.Windows.Forms.TextBox TxtAddField;
	}
}