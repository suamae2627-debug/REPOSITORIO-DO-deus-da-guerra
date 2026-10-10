namespace validacao
{
    partial class frm_validacao
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ValCPF = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ValCPF
            // 
            this.lbl_ValCPF.AutoSize = true;
            this.lbl_ValCPF.Location = new System.Drawing.Point(301, 27);
            this.lbl_ValCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValCPF.Name = "lbl_ValCPF";
            this.lbl_ValCPF.Size = new System.Drawing.Size(103, 14);
            this.lbl_ValCPF.TabIndex = 0;
            this.lbl_ValCPF.Text = "Validação do CPF";
            this.lbl_ValCPF.Click += new System.EventHandler(this.lbl_ValCPF_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(70, 116);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 14);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome ";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(71, 182);
            this.lbl_idade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(38, 14);
            this.lbl_idade.TabIndex = 2;
            this.lbl_idade.Text = "Idade";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(70, 237);
            this.lbl_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(31, 14);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(135, 116);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(306, 22);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(135, 174);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(116, 22);
            this.txt_idade.TabIndex = 5;
            this.txt_idade.TextChanged += new System.EventHandler(this.txt_idade_TextChanged);
            this.txt_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_KeyPress);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(135, 229);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(191, 22);
            this.txt_cpf.TabIndex = 6;
            this.txt_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_KeyPress);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(355, 174);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(88, 25);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbl_ValCPF);
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 67);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::validacao.Properties.Resources.ichigo_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(74, 283);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 151);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::validacao.Properties.Resources.ichigo_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(486, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 348);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frm_validacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(754, 447);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_validacao";
            this.Text = "Validação";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ValCPF;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

