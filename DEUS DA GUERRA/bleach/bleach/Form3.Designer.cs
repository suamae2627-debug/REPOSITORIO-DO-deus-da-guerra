namespace bleach
{
    partial class frm_shinigamis
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
            this.btn_quem = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quem
            // 
            this.btn_quem.BackColor = System.Drawing.Color.Transparent;
            this.btn_quem.FlatAppearance.BorderSize = 0;
            this.btn_quem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quem.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quem.ForeColor = System.Drawing.Color.White;
            this.btn_quem.Location = new System.Drawing.Point(951, 391);
            this.btn_quem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_quem.Name = "btn_quem";
            this.btn_quem.Size = new System.Drawing.Size(108, 116);
            this.btn_quem.TabIndex = 0;
            this.btn_quem.Text = "Quem são eles?";
            this.btn_quem.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Baskerville Old Face", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(69, 560);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(167, 67);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_shinigamis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bleach.Properties.Resources.pinterest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 666);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_quem);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1076, 705);
            this.MinimumSize = new System.Drawing.Size(1076, 705);
            this.Name = "frm_shinigamis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHINIGAMI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quem;
        private System.Windows.Forms.Button btn_voltar;
    }
}