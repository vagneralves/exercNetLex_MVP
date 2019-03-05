﻿using System;
namespace exercNetLex
{
	partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Ribbon1()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

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
			this.tab1 = this.Factory.CreateRibbonTab();
			this.grpPDF = this.Factory.CreateRibbonGroup();
			this.BtnSavePDF = this.Factory.CreateRibbonButton();
			this.grpImg = this.Factory.CreateRibbonGroup();
			this.BntAddImage = this.Factory.CreateRibbonButton();
			this.grpTabela = this.Factory.CreateRibbonGroup();
			this.BntAddTabela = this.Factory.CreateRibbonButton();
			this.grpLetras = this.Factory.CreateRibbonGroup();
			this.BntInvertCase = this.Factory.CreateRibbonButton();
			this.grpRevisao = this.Factory.CreateRibbonGroup();
			this.BntFindAndReplace = this.Factory.CreateRibbonButton();
			this.grpFieldSpan = this.Factory.CreateRibbonGroup();
			this.BntAddField = this.Factory.CreateRibbonButton();
			this.BtnFindSpan = this.Factory.CreateRibbonButton();
			this.BntAddSpan = this.Factory.CreateRibbonButton();
			this.grpQualificacao = this.Factory.CreateRibbonGroup();
			this.BntQualificacao = this.Factory.CreateRibbonButton();
			this.dlgImg = new System.Windows.Forms.OpenFileDialog();
			this.tab1.SuspendLayout();
			this.grpPDF.SuspendLayout();
			this.grpImg.SuspendLayout();
			this.grpTabela.SuspendLayout();
			this.grpLetras.SuspendLayout();
			this.grpRevisao.SuspendLayout();
			this.grpFieldSpan.SuspendLayout();
			this.grpQualificacao.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.grpPDF);
			this.tab1.Groups.Add(this.grpImg);
			this.tab1.Groups.Add(this.grpTabela);
			this.tab1.Groups.Add(this.grpLetras);
			this.tab1.Groups.Add(this.grpRevisao);
			this.tab1.Groups.Add(this.grpFieldSpan);
			this.tab1.Groups.Add(this.grpQualificacao);
			this.tab1.Label = "ExercNetLex";
			this.tab1.Name = "tab1";
			// 
			// grpPDF
			// 
			this.grpPDF.Items.Add(this.BtnSavePDF);
			this.grpPDF.Label = "PDF";
			this.grpPDF.Name = "grpPDF";
			// 
			// BtnSavePDF
			// 
			this.BtnSavePDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BtnSavePDF.Image = global::exercNetLex.Properties.Resources.imgPDF;
			this.BtnSavePDF.Label = "Save As PDF";
			this.BtnSavePDF.Name = "BtnSavePDF";
			this.BtnSavePDF.ShowImage = true;
			this.BtnSavePDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSavePDF_Click);
			// 
			// grpImg
			// 
			this.grpImg.Items.Add(this.BntAddImage);
			this.grpImg.Label = "Imagens";
			this.grpImg.Name = "grpImg";
			// 
			// BntAddImage
			// 
			this.BntAddImage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntAddImage.Image = global::exercNetLex.Properties.Resources.uploadImg;
			this.BntAddImage.Label = "Add Image";
			this.BntAddImage.Name = "BntAddImage";
			this.BntAddImage.ShowImage = true;
			this.BntAddImage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddImage_Click);
			// 
			// grpTabela
			// 
			this.grpTabela.Items.Add(this.BntAddTabela);
			this.grpTabela.Label = "Tabelas";
			this.grpTabela.Name = "grpTabela";
			// 
			// BntAddTabela
			// 
			this.BntAddTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntAddTabela.Image = global::exercNetLex.Properties.Resources.imgTable;
			this.BntAddTabela.Label = "Add Table";
			this.BntAddTabela.Name = "BntAddTabela";
			this.BntAddTabela.ShowImage = true;
			this.BntAddTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddTabela_Click);
			// 
			// grpLetras
			// 
			this.grpLetras.Items.Add(this.BntInvertCase);
			this.grpLetras.Label = "Letras";
			this.grpLetras.Name = "grpLetras";
			// 
			// BntInvertCase
			// 
			this.BntInvertCase.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntInvertCase.Enabled = false;
			this.BntInvertCase.Image = global::exercNetLex.Properties.Resources.caseImg;
			this.BntInvertCase.Label = "Invert Case";
			this.BntInvertCase.Name = "BntInvertCase";
			this.BntInvertCase.ShowImage = true;
			this.BntInvertCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntInvertCase_Click);
			// 
			// grpRevisao
			// 
			this.grpRevisao.Items.Add(this.BntFindAndReplace);
			this.grpRevisao.Label = "Revisão";
			this.grpRevisao.Name = "grpRevisao";
			// 
			// BntFindAndReplace
			// 
			this.BntFindAndReplace.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntFindAndReplace.Image = global::exercNetLex.Properties.Resources.findAndReplace;
			this.BntFindAndReplace.Label = "Find and Replace";
			this.BntFindAndReplace.Name = "BntFindAndReplace";
			this.BntFindAndReplace.ShowImage = true;
			this.BntFindAndReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntFindAndReplace_Click);
			// 
			// grpFieldSpan
			// 
			this.grpFieldSpan.Items.Add(this.BntAddField);
			this.grpFieldSpan.Items.Add(this.BtnFindSpan);
			this.grpFieldSpan.Items.Add(this.BntAddSpan);
			this.grpFieldSpan.Label = "Condição";
			this.grpFieldSpan.Name = "grpFieldSpan";
			// 
			// BntAddField
			// 
			this.BntAddField.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntAddField.Image = global::exercNetLex.Properties.Resources.fieldImg;
			this.BntAddField.Label = "Add Field";
			this.BntAddField.Name = "BntAddField";
			this.BntAddField.ShowImage = true;
			this.BntAddField.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddField_Click);
			// 
			// BtnFindSpan
			// 
			this.BtnFindSpan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BtnFindSpan.Image = global::exercNetLex.Properties.Resources.checkImg;
			this.BtnFindSpan.Label = "Check Span";
			this.BtnFindSpan.Name = "BtnFindSpan";
			this.BtnFindSpan.ShowImage = true;
			this.BtnFindSpan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnFindSpan_Click);
			// 
			// BntAddSpan
			// 
			this.BntAddSpan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntAddSpan.Enabled = false;
			this.BntAddSpan.Image = global::exercNetLex.Properties.Resources.spanImg1;
			this.BntAddSpan.Label = "Add Span";
			this.BntAddSpan.Name = "BntAddSpan";
			this.BntAddSpan.ShowImage = true;
			this.BntAddSpan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddSpan_Click);
			// 
			// grpQualificacao
			// 
			this.grpQualificacao.Items.Add(this.BntQualificacao);
			this.grpQualificacao.Label = "Qualificação";
			this.grpQualificacao.Name = "grpQualificacao";
			// 
			// BntQualificacao
			// 
			this.BntQualificacao.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntQualificacao.Image = global::exercNetLex.Properties.Resources.contatoPJImg;
			this.BntQualificacao.Label = "Qualificação PJ";
			this.BntQualificacao.Name = "BntQualificacao";
			this.BntQualificacao.ShowImage = true;
			this.BntQualificacao.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntQualificacao_Click);
			// 
			// dlgImg
			// 
			this.dlgImg.FileName = "dlgImg";
			// 
			// Ribbon1
			// 
			this.Name = "Ribbon1";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.grpPDF.ResumeLayout(false);
			this.grpPDF.PerformLayout();
			this.grpImg.ResumeLayout(false);
			this.grpImg.PerformLayout();
			this.grpTabela.ResumeLayout(false);
			this.grpTabela.PerformLayout();
			this.grpLetras.ResumeLayout(false);
			this.grpLetras.PerformLayout();
			this.grpRevisao.ResumeLayout(false);
			this.grpRevisao.PerformLayout();
			this.grpFieldSpan.ResumeLayout(false);
			this.grpFieldSpan.PerformLayout();
			this.grpQualificacao.ResumeLayout(false);
			this.grpQualificacao.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpPDF;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnSavePDF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpImg;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntAddImage;
		private System.Windows.Forms.OpenFileDialog dlgImg;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpTabela;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntAddTabela;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpLetras;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntInvertCase;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpRevisao;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntFindAndReplace;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpFieldSpan;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntAddField;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntAddSpan;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpQualificacao;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntQualificacao;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnFindSpan;
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get { return this.GetRibbon<Ribbon1>(); }
		}
	}
}
