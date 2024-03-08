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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblNumEmails = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblNumProdutos = new System.Windows.Forms.Label();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblNumFuncionario = new System.Windows.Forms.Label();
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
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.btnVends.Click += new System.EventHandler(this.btnVends_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Adega_Irmandade.Properties.Resources.cliente;
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.TabStop = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = global::Adega_Irmandade.Properties.Resources.relatorio;
            resources.ApplyResources(this.btnRelatorio, "btnRelatorio");
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.TabStop = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnEmails
            // 
            this.btnEmails.Image = global::Adega_Irmandade.Properties.Resources.emails;
            resources.ApplyResources(this.btnEmails, "btnEmails");
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.TabStop = false;
            this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
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
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = global::Adega_Irmandade.Properties.Resources.produto;
            resources.ApplyResources(this.btnProdutos, "btnProdutos");
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.TabStop = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Image = global::Adega_Irmandade.Properties.Resources.ajuda;
            resources.ApplyResources(this.btnAjuda, "btnAjuda");
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.TabStop = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Image = global::Adega_Irmandade.Properties.Resources.funcionarios;
            resources.ApplyResources(this.btnFuncionario, "btnFuncionario");
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.TabStop = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
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
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosMaisVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            resources.ApplyResources(this.dgvProdutosMaisVendidos, "dgvProdutosMaisVendidos");
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutosMaisVendidos.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvProdutosMaisVendidos.EnableHeadersVisualStyles = false;
            this.dgvProdutosMaisVendidos.GridColor = System.Drawing.Color.White;
            this.dgvProdutosMaisVendidos.MultiSelect = false;
            this.dgvProdutosMaisVendidos.Name = "dgvProdutosMaisVendidos";
            this.dgvProdutosMaisVendidos.ReadOnly = true;
            this.dgvProdutosMaisVendidos.RowHeadersVisible = false;
            this.dgvProdutosMaisVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosMaisVendidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProdutosMaisVendidos_CellFormatting);
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
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            resources.ApplyResources(this.pctFechar, "pctFechar");
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // lblProdutosMaisVendidos
            // 
            this.lblProdutosMaisVendidos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutosMaisVendidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.pnlUsuario.Controls.Add(this.lblNumEmails);
            this.pnlUsuario.Controls.Add(this.lblVendas);
            this.pnlUsuario.Controls.Add(this.lblProdutos);
            this.pnlUsuario.Controls.Add(this.lblNumProdutos);
            this.pnlUsuario.Controls.Add(this.dgvContato);
            this.pnlUsuario.Controls.Add(this.lblFuncionario);
            this.pnlUsuario.Controls.Add(this.lblNumFuncionario);
            this.pnlUsuario.Controls.Add(this.lblNumVendas);
            resources.ApplyResources(this.pnlUsuario, "pnlUsuario");
            this.pnlUsuario.Name = "pnlUsuario";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Name = "lblEmail";
            // 
            // lblNumEmails
            // 
            this.lblNumEmails.BackColor = System.Drawing.Color.Transparent;
            this.lblNumEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumEmails, "lblNumEmails");
            this.lblNumEmails.ForeColor = System.Drawing.Color.White;
            this.lblNumEmails.Name = "lblNumEmails";
            // 
            // lblVendas
            // 
            this.lblVendas.BackColor = System.Drawing.Color.Transparent;
            this.lblVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblVendas, "lblVendas");
            this.lblVendas.ForeColor = System.Drawing.Color.White;
            this.lblVendas.Name = "lblVendas";
            // 
            // lblProdutos
            // 
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblProdutos, "lblProdutos");
            this.lblProdutos.ForeColor = System.Drawing.Color.White;
            this.lblProdutos.Name = "lblProdutos";
            // 
            // lblNumProdutos
            // 
            this.lblNumProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblNumProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumProdutos, "lblNumProdutos");
            this.lblNumProdutos.ForeColor = System.Drawing.Color.White;
            this.lblNumProdutos.Name = "lblNumProdutos";
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToResizeColumns = false;
            this.dgvContato.AllowUserToResizeRows = false;
            this.dgvContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContato.BackgroundColor = System.Drawing.Color.Black;
            this.dgvContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContato.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvContato.EnableHeadersVisualStyles = false;
            this.dgvContato.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dgvContato, "dgvContato");
            this.dgvContato.MultiSelect = false;
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvContato.RowHeadersVisible = false;
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContato_CellContentDoubleClick);
            this.dgvContato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContato_CellFormatting);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblFuncionario, "lblFuncionario");
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Name = "lblFuncionario";
            // 
            // lblNumFuncionario
            // 
            this.lblNumFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNumFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblNumFuncionario, "lblNumFuncionario");
            this.lblNumFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNumFuncionario.Name = "lblNumFuncionario";
            // 
            // lblNumVendas
            // 
            this.lblNumVendas.BackColor = System.Drawing.Color.Transparent;
            this.lblNumVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label lblNumFuncionario;
        private System.Windows.Forms.Label lblNumProdutos;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumEmails;
    }
}