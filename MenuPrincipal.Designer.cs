﻿namespace Adega_Irmandade
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVends = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.PictureBox();
            this.btnRelatorio = new System.Windows.Forms.PictureBox();
            this.btnEmails = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnEstoque = new System.Windows.Forms.PictureBox();
            this.btnProdutos = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.PictureBox();
            this.btnFuncionario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProdutosMaisVendidos = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.lblProdutosMaisVendidos = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblNumCliente = new System.Windows.Forms.Label();
            this.lblNumEmails = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblNumEstoque = new System.Windows.Forms.Label();
            this.lblNumProdutos = new System.Windows.Forms.Label();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblNumFunionario = new System.Windows.Forms.Label();
            this.lblNumVendas = new System.Windows.Forms.Label();
            this.pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosMaisVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // time1
            // 
            this.time1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlMenuPrincipal.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacamenu;
            this.pnlMenuPrincipal.Controls.Add(this.label8);
            this.pnlMenuPrincipal.Controls.Add(this.btnVends);
            this.pnlMenuPrincipal.Controls.Add(this.btnClientes);
            this.pnlMenuPrincipal.Controls.Add(this.btnRelatorio);
            this.pnlMenuPrincipal.Controls.Add(this.btnEmails);
            this.pnlMenuPrincipal.Controls.Add(this.pctLogo);
            this.pnlMenuPrincipal.Controls.Add(this.btnEstoque);
            this.pnlMenuPrincipal.Controls.Add(this.btnProdutos);
            this.pnlMenuPrincipal.Controls.Add(this.btnAjuda);
            this.pnlMenuPrincipal.Controls.Add(this.btnFuncionario);
            this.pnlMenuPrincipal.Controls.Add(this.panel1);
            this.pnlMenuPrincipal.Controls.Add(this.pnlUsuario);
            resources.ApplyResources(this.pnlMenuPrincipal, "pnlMenuPrincipal");
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // btnVends
            // 
            this.btnVends.Image = global::Adega_Irmandade.Properties.Resources.vendas;
            resources.ApplyResources(this.btnVends, "btnVends");
            this.btnVends.Name = "btnVends";
            this.btnVends.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Adega_Irmandade.Properties.Resources.cliente;
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.TabStop = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = global::Adega_Irmandade.Properties.Resources.relatorio;
            resources.ApplyResources(this.btnRelatorio, "btnRelatorio");
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.TabStop = false;
            // 
            // btnEmails
            // 
            this.btnEmails.Image = global::Adega_Irmandade.Properties.Resources.emails;
            resources.ApplyResources(this.btnEmails, "btnEmails");
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            resources.ApplyResources(this.pctLogo, "pctLogo");
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.TabStop = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Image = global::Adega_Irmandade.Properties.Resources.estoque;
            resources.ApplyResources(this.btnEstoque, "btnEstoque");
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.TabStop = false;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = global::Adega_Irmandade.Properties.Resources.produto;
            resources.ApplyResources(this.btnProdutos, "btnProdutos");
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Image = global::Adega_Irmandade.Properties.Resources.ajuda;
            resources.ApplyResources(this.btnAjuda, "btnAjuda");
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.TabStop = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Image = global::Adega_Irmandade.Properties.Resources.funcionarios;
            resources.ApplyResources(this.btnFuncionario, "btnFuncionario");
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvProdutosMaisVendidos);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.pctFechar);
            this.panel1.Controls.Add(this.lblProdutosMaisVendidos);
            this.panel1.Controls.Add(this.lblUsuario);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dgvProdutosMaisVendidos
            // 
            this.dgvProdutosMaisVendidos.AllowUserToResizeRows = false;
            this.dgvProdutosMaisVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutosMaisVendidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutosMaisVendidos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvProdutosMaisVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosMaisVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutosMaisVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutosMaisVendidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutosMaisVendidos.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.dgvProdutosMaisVendidos, "dgvProdutosMaisVendidos");
            this.dgvProdutosMaisVendidos.MultiSelect = false;
            this.dgvProdutosMaisVendidos.Name = "dgvProdutosMaisVendidos";
            this.dgvProdutosMaisVendidos.ReadOnly = true;
            this.dgvProdutosMaisVendidos.RowHeadersVisible = false;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Name = "lblHora";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Name = "lblData";
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Black;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            resources.ApplyResources(this.pctFechar, "pctFechar");
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // lblProdutosMaisVendidos
            // 
            this.lblProdutosMaisVendidos.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblProdutosMaisVendidos, "lblProdutosMaisVendidos");
            this.lblProdutosMaisVendidos.ForeColor = System.Drawing.Color.White;
            this.lblProdutosMaisVendidos.Name = "lblProdutosMaisVendidos";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsuario.Controls.Add(this.lblEmail);
            this.pnlUsuario.Controls.Add(this.lblClientes);
            this.pnlUsuario.Controls.Add(this.lblNumCliente);
            this.pnlUsuario.Controls.Add(this.lblNumEmails);
            this.pnlUsuario.Controls.Add(this.lblVendas);
            this.pnlUsuario.Controls.Add(this.lblEstoque);
            this.pnlUsuario.Controls.Add(this.lblProdutos);
            this.pnlUsuario.Controls.Add(this.lblNumEstoque);
            this.pnlUsuario.Controls.Add(this.lblNumProdutos);
            this.pnlUsuario.Controls.Add(this.dgvContato);
            this.pnlUsuario.Controls.Add(this.lblFuncionario);
            this.pnlUsuario.Controls.Add(this.lblNumFunionario);
            this.pnlUsuario.Controls.Add(this.lblNumVendas);
            resources.ApplyResources(this.pnlUsuario, "pnlUsuario");
            this.pnlUsuario.Name = "pnlUsuario";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Name = "lblEmail";
            // 
            // lblClientes
            // 
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblClientes, "lblClientes");
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Name = "lblClientes";
            // 
            // lblNumCliente
            // 
            this.lblNumCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNumCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumCliente, "lblNumCliente");
            this.lblNumCliente.ForeColor = System.Drawing.Color.White;
            this.lblNumCliente.Name = "lblNumCliente";
            // 
            // lblNumEmails
            // 
            this.lblNumEmails.BackColor = System.Drawing.Color.Transparent;
            this.lblNumEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumEmails, "lblNumEmails");
            this.lblNumEmails.ForeColor = System.Drawing.Color.White;
            this.lblNumEmails.Name = "lblNumEmails";
            // 
            // lblVendas
            // 
            this.lblVendas.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblVendas, "lblVendas");
            this.lblVendas.ForeColor = System.Drawing.Color.White;
            this.lblVendas.Name = "lblVendas";
            // 
            // lblEstoque
            // 
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblEstoque, "lblEstoque");
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Name = "lblEstoque";
            // 
            // lblProdutos
            // 
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblProdutos, "lblProdutos");
            this.lblProdutos.ForeColor = System.Drawing.Color.White;
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblNumEstoque
            // 
            this.lblNumEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblNumEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumEstoque, "lblNumEstoque");
            this.lblNumEstoque.ForeColor = System.Drawing.Color.White;
            this.lblNumEstoque.Name = "lblNumEstoque";
            // 
            // lblNumProdutos
            // 
            this.lblNumProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblNumProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumProdutos, "lblNumProdutos");
            this.lblNumProdutos.ForeColor = System.Drawing.Color.White;
            this.lblNumProdutos.Name = "lblNumProdutos";
            // 
            // dgvContato
            // 
            this.dgvContato.BackgroundColor = System.Drawing.Color.Black;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvContato, "dgvContato");
            this.dgvContato.Name = "dgvContato";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblFuncionario, "lblFuncionario");
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Name = "lblFuncionario";
            // 
            // lblNumFunionario
            // 
            this.lblNumFunionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNumFunionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumFunionario, "lblNumFunionario");
            this.lblNumFunionario.ForeColor = System.Drawing.Color.White;
            this.lblNumFunionario.Name = "lblNumFunionario";
            // 
            // lblNumVendas
            // 
            this.lblNumVendas.BackColor = System.Drawing.Color.Transparent;
            this.lblNumVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumVendas, "lblNumVendas");
            this.lblNumVendas.ForeColor = System.Drawing.Color.White;
            this.lblNumVendas.Name = "lblNumVendas";
            // 
            // frmMenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosMaisVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProdutosMaisVendidos;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Timer time1;
        private System.Windows.Forms.DataGridView dgvProdutosMaisVendidos;
        private System.Windows.Forms.PictureBox btnFuncionario;
        private System.Windows.Forms.PictureBox btnEstoque;
        private System.Windows.Forms.PictureBox btnProdutos;
        private System.Windows.Forms.PictureBox btnAjuda;
        private System.Windows.Forms.PictureBox btnVends;
        private System.Windows.Forms.PictureBox btnClientes;
        private System.Windows.Forms.PictureBox btnRelatorio;
        private System.Windows.Forms.PictureBox btnEmails;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblNumVendas;
        private System.Windows.Forms.Label lblNumFunionario;
        private System.Windows.Forms.Label lblNumProdutos;
        private System.Windows.Forms.Label lblNumEstoque;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblNumCliente;
        private System.Windows.Forms.Label lblNumEmails;
    }
}