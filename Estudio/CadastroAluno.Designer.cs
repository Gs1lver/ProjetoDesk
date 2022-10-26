namespace Estudio
{
    partial class CadastroAluno
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
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxCep = new System.Windows.Forms.MaskedTextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFoto = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.btnCadastrar);
            this.grpDados.Controls.Add(this.txtNumero);
            this.grpDados.Controls.Add(this.txtComplemento);
            this.grpDados.Controls.Add(this.txtEstado);
            this.grpDados.Controls.Add(this.txtEmail);
            this.grpDados.Controls.Add(this.mtxCep);
            this.grpDados.Controls.Add(this.mtxTelefone);
            this.grpDados.Controls.Add(this.mtxCpf);
            this.grpDados.Controls.Add(this.txtCidade);
            this.grpDados.Controls.Add(this.txtBairro);
            this.grpDados.Controls.Add(this.textBox3);
            this.grpDados.Controls.Add(this.txtEndereco);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.label11);
            this.grpDados.Controls.Add(this.label10);
            this.grpDados.Controls.Add(this.label9);
            this.grpDados.Controls.Add(this.label8);
            this.grpDados.Controls.Add(this.label7);
            this.grpDados.Controls.Add(this.label6);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.label4);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Controls.Add(this.label1);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(549, 391);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados Cadastrais";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(398, 338);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(134, 35);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(457, 138);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(65, 22);
            this.txtNumero.TabIndex = 4;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(457, 191);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(73, 22);
            this.txtComplemento.TabIndex = 6;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(457, 238);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(73, 22);
            this.txtEstado.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(326, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // mtxCep
            // 
            this.mtxCep.Location = new System.Drawing.Point(86, 238);
            this.mtxCep.Mask = "99.999-999";
            this.mtxCep.Name = "mtxCep";
            this.mtxCep.Size = new System.Drawing.Size(112, 22);
            this.mtxCep.TabIndex = 7;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(87, 295);
            this.mtxTelefone.Mask = "(99)99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(171, 22);
            this.mtxTelefone.TabIndex = 10;
            // 
            // mtxCpf
            // 
            this.mtxCpf.Location = new System.Drawing.Point(89, 46);
            this.mtxCpf.Mask = "999.999.999-99";
            this.mtxCpf.Name = "mtxCpf";
            this.mtxCpf.Size = new System.Drawing.Size(141, 22);
            this.mtxCpf.TabIndex = 1;
            this.mtxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxCpf_KeyPress);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(263, 238);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(126, 22);
            this.txtCidade.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(89, 191);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(251, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 22);
            this.textBox3.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(89, 135);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(322, 22);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 22);
            this.txtNome.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "nº:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Complemento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF: ";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(637, 350);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(163, 35);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "Escolher Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(608, 18);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(217, 311);
            this.picFoto.TabIndex = 2;
            this.picFoto.TabStop = false;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(862, 415);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.grpDados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxCep;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCpf;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox picFoto;
    }
}