namespace Adega_Irmandade
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
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblNumProdutos = new System.Windows.Forms.Label();
            this.lblNumCliente = new System.Windows.Forms.Label();
            this.lblNumEstoque = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblNumVendas = new System.Windows.Forms.Label();
            this.lblNumFuncionario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.lblProdutosMaisVendidos = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.dgvProdutosMaisVendidos = new System.Windows.Forms.DataGridView();
            this.pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlCont.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosMaisVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlMenuPrincipal.Controls.Add(this.btnFuncionarios);
            this.pnlMenuPrincipal.Controls.Add(this.pctLogo);
            this.pnlMenuPrincipal.Controls.Add(this.pnlCont);
            this.pnlMenuPrincipal.Controls.Add(this.panel1);
            this.pnlMenuPrincipal.Controls.Add(this.pnlUsuario);
            this.pnlMenuPrincipal.Controls.Add(this.btnCliente);
            this.pnlMenuPrincipal.Controls.Add(this.btnEmail);
            this.pnlMenuPrincipal.Controls.Add(this.btnEstoque);
            this.pnlMenuPrincipal.Controls.Add(this.btnProdutos);
            this.pnlMenuPrincipal.Controls.Add(this.btnVendas);
            this.pnlMenuPrincipal.Controls.Add(this.btnRelatorio);
            this.pnlMenuPrincipal.Controls.Add(this.btnAjuda);
            resources.ApplyResources(this.pnlMenuPrincipal, "pnlMenuPrincipal");
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            // 
            // btnFuncionarios
            // 
            resources.ApplyResources(this.btnFuncionarios, "btnFuncionarios");
            this.btnFuncionarios.Image = global::Adega_Irmandade.Properties.Resources.funcionario;
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Black;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo;
            resources.ApplyResources(this.pctLogo, "pctLogo");
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.TabStop = false;
            // 
            // pnlCont
            // 
            this.pnlCont.BackColor = System.Drawing.Color.DarkGray;
            this.pnlCont.Controls.Add(this.lblProdutos);
            this.pnlCont.Controls.Add(this.lblVendas);
            this.pnlCont.Controls.Add(this.lblCliente);
            this.pnlCont.Controls.Add(this.lblEstoque);
            this.pnlCont.Controls.Add(this.lblNumProdutos);
            this.pnlCont.Controls.Add(this.lblNumCliente);
            this.pnlCont.Controls.Add(this.lblNumEstoque);
            this.pnlCont.Controls.Add(this.lblFuncionario);
            this.pnlCont.Controls.Add(this.lblNumVendas);
            this.pnlCont.Controls.Add(this.lblNumFuncionario);
            resources.ApplyResources(this.pnlCont, "pnlCont");
            this.pnlCont.Name = "pnlCont";
            // 
            // lblProdutos
            // 
            this.lblProdutos.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblProdutos, "lblProdutos");
            this.lblProdutos.ForeColor = System.Drawing.Color.White;
            this.lblProdutos.Name = "lblProdutos";
            // 
            // lblVendas
            // 
            this.lblVendas.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblVendas, "lblVendas");
            this.lblVendas.ForeColor = System.Drawing.Color.White;
            this.lblVendas.Name = "lblVendas";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblCliente, "lblCliente");
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Name = "lblCliente";
            // 
            // lblEstoque
            // 
            this.lblEstoque.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblEstoque, "lblEstoque");
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Name = "lblEstoque";
            // 
            // lblNumProdutos
            // 
            this.lblNumProdutos.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblNumProdutos, "lblNumProdutos");
            this.lblNumProdutos.ForeColor = System.Drawing.Color.White;
            this.lblNumProdutos.Name = "lblNumProdutos";
            // 
            // lblNumCliente
            // 
            this.lblNumCliente.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblNumCliente, "lblNumCliente");
            this.lblNumCliente.ForeColor = System.Drawing.Color.White;
            this.lblNumCliente.Name = "lblNumCliente";
            // 
            // lblNumEstoque
            // 
            this.lblNumEstoque.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblNumEstoque, "lblNumEstoque");
            this.lblNumEstoque.ForeColor = System.Drawing.Color.White;
            this.lblNumEstoque.Name = "lblNumEstoque";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblFuncionario, "lblFuncionario");
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Name = "lblFuncionario";
            // 
            // lblNumVendas
            // 
            this.lblNumVendas.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblNumVendas, "lblNumVendas");
            this.lblNumVendas.ForeColor = System.Drawing.Color.White;
            this.lblNumVendas.Name = "lblNumVendas";
            // 
            // lblNumFuncionario
            // 
            this.lblNumFuncionario.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblNumFuncionario, "lblNumFuncionario");
            this.lblNumFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNumFuncionario.Name = "lblNumFuncionario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.dgvProdutosMaisVendidos);
            this.panel1.Controls.Add(this.pctFechar);
            this.panel1.Controls.Add(this.lblProdutosMaisVendidos);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Black;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar1;
            resources.ApplyResources(this.pctFechar, "pctFechar");
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // lblProdutosMaisVendidos
            // 
            this.lblProdutosMaisVendidos.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblProdutosMaisVendidos, "lblProdutosMaisVendidos");
            this.lblProdutosMaisVendidos.ForeColor = System.Drawing.Color.White;
            this.lblProdutosMaisVendidos.Name = "lblProdutosMaisVendidos";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.pnlUsuario.Controls.Add(this.dgvContato);
            this.pnlUsuario.Controls.Add(this.lblData);
            this.pnlUsuario.Controls.Add(this.lblHora);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            resources.ApplyResources(this.pnlUsuario, "pnlUsuario");
            this.pnlUsuario.Name = "pnlUsuario";
            // 
            // dgvContato
            // 
            this.dgvContato.BackgroundColor = System.Drawing.Color.Black;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvContato, "dgvContato");
            this.dgvContato.Name = "dgvContato";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Name = "lblData";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Name = "lblHora";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnCliente
            // 
            resources.ApplyResources(this.btnCliente, "btnCliente");
            this.btnCliente.Image = global::Adega_Irmandade.Properties.Resources.cliente;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            resources.ApplyResources(this.btnEmail, "btnEmail");
            this.btnEmail.Image = global::Adega_Irmandade.Properties.Resources.emails;
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            resources.ApplyResources(this.btnEstoque, "btnEstoque");
            this.btnEstoque.Image = global::Adega_Irmandade.Properties.Resources.estoque;
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            resources.ApplyResources(this.btnProdutos, "btnProdutos");
            this.btnProdutos.Image = global::Adega_Irmandade.Properties.Resources.produtos;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            resources.ApplyResources(this.btnVendas, "btnVendas");
            this.btnVendas.Image = global::Adega_Irmandade.Properties.Resources.vendas;
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            resources.ApplyResources(this.btnRelatorio, "btnRelatorio");
            this.btnRelatorio.Image = global::Adega_Irmandade.Properties.Resources.relatorio;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnAjuda
            // 
            resources.ApplyResources(this.btnAjuda, "btnAjuda");
            this.btnAjuda.Image = global::Adega_Irmandade.Properties.Resources.ajudaesuporte;
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // time1
            // 
            this.time1.Tick += new System.EventHandler(this.time1_Tick);
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
            this.dgvProdutosMaisVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlCont.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosMaisVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNumFuncionario;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Label lblNumProdutos;
        private System.Windows.Forms.Label lblNumVendas;
        private System.Windows.Forms.Label lblNumCliente;
        private System.Windows.Forms.Label lblNumEstoque;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProdutosMaisVendidos;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Timer time1;
        private System.Windows.Forms.DataGridView dgvProdutosMaisVendidos;
    }
}