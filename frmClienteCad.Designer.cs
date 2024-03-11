namespace Adega_Irmandade
{
    partial class frmClienteCad
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
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadFoto = new System.Windows.Forms.Label();
            this.btnCadFoto = new System.Windows.Forms.Button();
            this.pctCadFoto = new System.Windows.Forms.PictureBox();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnCadSalvar.Location = new System.Drawing.Point(188, 598);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(214, 40);
            this.btnCadSalvar.TabIndex = 105;
            this.btnCadSalvar.Text = "SALVAR";
            this.btnCadSalvar.UseVisualStyleBackColor = false;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            this.pctLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctLogo.Location = new System.Drawing.Point(924, 35);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(294, 293);
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
            this.btnLimpar.Location = new System.Drawing.Point(503, 598);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(214, 40);
            this.btnLimpar.TabIndex = 103;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cmbCadStatus
            // 
            this.cmbCadStatus.Enabled = false;
            this.cmbCadStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadStatus.FormattingEnabled = true;
            this.cmbCadStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbCadStatus.Location = new System.Drawing.Point(137, 354);
            this.cmbCadStatus.Name = "cmbCadStatus";
            this.cmbCadStatus.Size = new System.Drawing.Size(204, 26);
            this.cmbCadStatus.TabIndex = 96;
            this.cmbCadStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCadStatus_KeyPress);
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Enabled = false;
            this.txtCadSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(137, 264);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(214, 26);
            this.txtCadSenha.TabIndex = 94;
            this.txtCadSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadSenha_KeyPress);
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCadEmail.Enabled = false;
            this.txtCadEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadEmail.Location = new System.Drawing.Point(137, 187);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(435, 26);
            this.txtCadEmail.TabIndex = 93;
            this.txtCadEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadEmail_KeyPress);
            // 
            // txtCadNome
            // 
            this.txtCadNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(137, 105);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(664, 26);
            this.txtCadNome.TabIndex = 91;
            this.txtCadNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadNome_KeyPress);
            // 
            // lblCadFoto
            // 
            this.lblCadFoto.AutoSize = true;
            this.lblCadFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblCadFoto.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFoto.ForeColor = System.Drawing.Color.White;
            this.lblCadFoto.Location = new System.Drawing.Point(864, 354);
            this.lblCadFoto.Name = "lblCadFoto";
            this.lblCadFoto.Size = new System.Drawing.Size(76, 27);
            this.lblCadFoto.TabIndex = 90;
            this.lblCadFoto.Text = "FOTO:";
            // 
            // btnCadFoto
            // 
            this.btnCadFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnCadFoto.Enabled = false;
            this.btnCadFoto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFoto.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.btnCadFoto.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadFoto.Location = new System.Drawing.Point(1079, 534);
            this.btnCadFoto.Name = "btnCadFoto";
            this.btnCadFoto.Size = new System.Drawing.Size(38, 36);
            this.btnCadFoto.TabIndex = 89;
            this.btnCadFoto.Text = "+";
            this.btnCadFoto.UseVisualStyleBackColor = false;
            this.btnCadFoto.Click += new System.EventHandler(this.btnCadFoto_Click);
            // 
            // pctCadFoto
            // 
            this.pctCadFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pctCadFoto.BackColor = System.Drawing.Color.Transparent;
            this.pctCadFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctCadFoto.Location = new System.Drawing.Point(946, 353);
            this.pctCadFoto.Name = "pctCadFoto";
            this.pctCadFoto.Size = new System.Drawing.Size(171, 217);
            this.pctCadFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCadFoto.TabIndex = 88;
            this.pctCadFoto.TabStop = false;
            this.pctCadFoto.Click += new System.EventHandler(this.pctCadFoto_Click);
            // 
            // lblCadStatus
            // 
            this.lblCadStatus.AutoSize = true;
            this.lblCadStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCadStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadStatus.ForeColor = System.Drawing.Color.White;
            this.lblCadStatus.Location = new System.Drawing.Point(39, 353);
            this.lblCadStatus.Name = "lblCadStatus";
            this.lblCadStatus.Size = new System.Drawing.Size(103, 27);
            this.lblCadStatus.TabIndex = 82;
            this.lblCadStatus.Text = "STATUS:";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblCadSenha.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.ForeColor = System.Drawing.Color.White;
            this.lblCadSenha.Location = new System.Drawing.Point(38, 261);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(93, 27);
            this.lblCadSenha.TabIndex = 78;
            this.lblCadSenha.Text = "SENHA:";
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadEmail.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmail.ForeColor = System.Drawing.Color.White;
            this.lblCadEmail.Location = new System.Drawing.Point(39, 186);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(85, 27);
            this.lblCadEmail.TabIndex = 77;
            this.lblCadEmail.Text = "EMAIL:";
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNome.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNome.ForeColor = System.Drawing.Color.White;
            this.lblCadNome.Location = new System.Drawing.Point(38, 102);
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
            this.label2.Location = new System.Drawing.Point(205, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "CLIENTES\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadCadastrar
            // 
            this.lblCadCadastrar.AllowDrop = true;
            this.lblCadCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCadastrar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadCadastrar.Location = new System.Drawing.Point(27, 35);
            this.lblCadCadastrar.Name = "lblCadCadastrar";
            this.lblCadCadastrar.Size = new System.Drawing.Size(178, 40);
            this.lblCadCadastrar.TabIndex = 72;
            this.lblCadCadastrar.Text = "CADASTRAR\r\n";
            this.lblCadCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.pctFechar.TabIndex = 106;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // frmClienteCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadFoto);
            this.Controls.Add(this.btnCadFoto);
            this.Controls.Add(this.pctCadFoto);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadEmail);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienteCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienteCad";
            this.Load += new System.EventHandler(this.frmClienteCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadEmail;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadFoto;
        private System.Windows.Forms.Button btnCadFoto;
        private System.Windows.Forms.PictureBox pctCadFoto;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.PictureBox pctFechar;
    }
}