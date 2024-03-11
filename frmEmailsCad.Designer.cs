namespace Adega_Irmandade
{
    partial class frmEmailsCad
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
            this.mkdCadDataContato = new System.Windows.Forms.MaskedTextBox();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mkdCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCadMensagem = new System.Windows.Forms.TextBox();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadMensagem = new System.Windows.Forms.Label();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadTelefone = new System.Windows.Forms.Label();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.lblCadDataContato = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.lblCadCep = new System.Windows.Forms.Label();
            this.mkdCadHora = new System.Windows.Forms.MaskedTextBox();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdCadDataContato
            // 
            this.mkdCadDataContato.Enabled = false;
            this.mkdCadDataContato.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadDataContato.Location = new System.Drawing.Point(668, 316);
            this.mkdCadDataContato.Mask = "00/00/0000";
            this.mkdCadDataContato.Name = "mkdCadDataContato";
            this.mkdCadDataContato.Size = new System.Drawing.Size(131, 34);
            this.mkdCadDataContato.TabIndex = 106;
            this.mkdCadDataContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadDataContato.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnCadSalvar.Location = new System.Drawing.Point(103, 589);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(220, 54);
            this.btnCadSalvar.TabIndex = 105;
            this.btnCadSalvar.Text = "SALVAR";
            this.btnCadSalvar.UseVisualStyleBackColor = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            this.pctLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctLogo.Location = new System.Drawing.Point(869, 54);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(349, 324);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 104;
            this.pctLogo.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(514, 589);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(220, 54);
            this.btnLimpar.TabIndex = 103;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // mkdCadTelefone
            // 
            this.mkdCadTelefone.Enabled = false;
            this.mkdCadTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadTelefone.Location = new System.Drawing.Point(633, 195);
            this.mkdCadTelefone.Mask = "(99)90000-0000";
            this.mkdCadTelefone.Name = "mkdCadTelefone";
            this.mkdCadTelefone.Size = new System.Drawing.Size(166, 26);
            this.mkdCadTelefone.TabIndex = 98;
            this.mkdCadTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCadMensagem
            // 
            this.txtCadMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCadMensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadMensagem.Enabled = false;
            this.txtCadMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadMensagem.Location = new System.Drawing.Point(46, 324);
            this.txtCadMensagem.Name = "txtCadMensagem";
            this.txtCadMensagem.Size = new System.Drawing.Size(277, 26);
            this.txtCadMensagem.TabIndex = 97;
            // 
            // cmbCadStatus
            // 
            this.cmbCadStatus.Enabled = false;
            this.cmbCadStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadStatus.FormattingEnabled = true;
            this.cmbCadStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbCadStatus.Location = new System.Drawing.Point(46, 468);
            this.cmbCadStatus.Name = "cmbCadStatus";
            this.cmbCadStatus.Size = new System.Drawing.Size(204, 26);
            this.cmbCadStatus.TabIndex = 96;
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCadEmail.Enabled = false;
            this.txtCadEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadEmail.Location = new System.Drawing.Point(46, 195);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(435, 26);
            this.txtCadEmail.TabIndex = 93;
            // 
            // txtCadNome
            // 
            this.txtCadNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(46, 105);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(753, 26);
            this.txtCadNome.TabIndex = 91;
            // 
            // lblCadMensagem
            // 
            this.lblCadMensagem.AutoSize = true;
            this.lblCadMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMensagem.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMensagem.ForeColor = System.Drawing.Color.White;
            this.lblCadMensagem.Location = new System.Drawing.Point(41, 294);
            this.lblCadMensagem.Name = "lblCadMensagem";
            this.lblCadMensagem.Size = new System.Drawing.Size(143, 27);
            this.lblCadMensagem.TabIndex = 86;
            this.lblCadMensagem.Text = "MENSAGEM:";
          
            // 
            // lblCadStatus
            // 
            this.lblCadStatus.AutoSize = true;
            this.lblCadStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCadStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadStatus.ForeColor = System.Drawing.Color.White;
            this.lblCadStatus.Location = new System.Drawing.Point(41, 432);
            this.lblCadStatus.Name = "lblCadStatus";
            this.lblCadStatus.Size = new System.Drawing.Size(103, 27);
            this.lblCadStatus.TabIndex = 82;
            this.lblCadStatus.Text = "STATUS:";
            // 
            // lblCadTelefone
            // 
            this.lblCadTelefone.AutoSize = true;
            this.lblCadTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblCadTelefone.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadTelefone.ForeColor = System.Drawing.Color.White;
            this.lblCadTelefone.Location = new System.Drawing.Point(667, 165);
            this.lblCadTelefone.Name = "lblCadTelefone";
            this.lblCadTelefone.Size = new System.Drawing.Size(132, 27);
            this.lblCadTelefone.TabIndex = 80;
            this.lblCadTelefone.Text = "TELEFONE:";
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadEmail.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmail.ForeColor = System.Drawing.Color.White;
            this.lblCadEmail.Location = new System.Drawing.Point(41, 165);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(85, 27);
            this.lblCadEmail.TabIndex = 77;
            this.lblCadEmail.Text = "EMAIL:";
            // 
            // lblCadDataContato
            // 
            this.lblCadDataContato.AutoSize = true;
            this.lblCadDataContato.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDataContato.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDataContato.ForeColor = System.Drawing.Color.White;
            this.lblCadDataContato.Location = new System.Drawing.Point(678, 259);
            this.lblCadDataContato.Name = "lblCadDataContato";
            this.lblCadDataContato.Size = new System.Drawing.Size(121, 54);
            this.lblCadDataContato.TabIndex = 75;
            this.lblCadDataContato.Text = "DATA \r\nCONTATO:";
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNome.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNome.ForeColor = System.Drawing.Color.White;
            this.lblCadNome.Location = new System.Drawing.Point(41, 75);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(82, 27);
            this.lblCadNome.TabIndex = 74;
            this.lblCadNome.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "DE     E-MAILS\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadCadastrar
            // 
            this.lblCadCadastrar.AllowDrop = true;
            this.lblCadCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCadastrar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadCadastrar.Location = new System.Drawing.Point(23, 27);
            this.lblCadCadastrar.Name = "lblCadCadastrar";
            this.lblCadCadastrar.Size = new System.Drawing.Size(178, 40);
            this.lblCadCadastrar.TabIndex = 72;
            this.lblCadCadastrar.Text = "CADASTRO";
            this.lblCadCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadCep
            // 
            this.lblCadCep.AutoSize = true;
            this.lblCadCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCep.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCep.ForeColor = System.Drawing.Color.White;
            this.lblCadCep.Location = new System.Drawing.Point(678, 413);
            this.lblCadCep.Name = "lblCadCep";
            this.lblCadCep.Size = new System.Drawing.Size(121, 54);
            this.lblCadCep.TabIndex = 87;
            this.lblCadCep.Text = "HORA \r\nCONTATO:";
            // 
            // mkdCadHora
            // 
            this.mkdCadHora.Enabled = false;
            this.mkdCadHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadHora.Location = new System.Drawing.Point(645, 470);
            this.mkdCadHora.Mask = "00:00";
            this.mkdCadHora.Name = "mkdCadHora";
            this.mkdCadHora.Size = new System.Drawing.Size(154, 26);
            this.mkdCadHora.TabIndex = 99;
            this.mkdCadHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadHora.ValidatingType = typeof(System.DateTime);
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            this.pctFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctFechar.Location = new System.Drawing.Point(1179, 12);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(39, 30);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFechar.TabIndex = 107;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // frmEmailsCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.mkdCadDataContato);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mkdCadHora);
            this.Controls.Add(this.mkdCadTelefone);
            this.Controls.Add(this.txtCadMensagem);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadCep);
            this.Controls.Add(this.lblCadMensagem);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadTelefone);
            this.Controls.Add(this.lblCadEmail);
            this.Controls.Add(this.lblCadDataContato);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmailsCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmailsCad";
            this.Load += new System.EventHandler(this.frmEmailsCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkdCadDataContato;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mkdCadTelefone;
        private System.Windows.Forms.TextBox txtCadMensagem;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.TextBox txtCadEmail;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadMensagem;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadTelefone;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.Label lblCadDataContato;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.Label lblCadCep;
        private System.Windows.Forms.MaskedTextBox mkdCadHora;
        private System.Windows.Forms.PictureBox pctFechar;
    }
}