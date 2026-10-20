namespace bleach
{
    partial class frm_hollow
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_quem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(403, 462);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(156, 59);
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_quem
            // 
            this.btn_quem.BackColor = System.Drawing.Color.Transparent;
            this.btn_quem.FlatAppearance.BorderSize = 0;
            this.btn_quem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quem.Font = new System.Drawing.Font("Baskerville Old Face", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quem.ForeColor = System.Drawing.Color.White;
            this.btn_quem.Location = new System.Drawing.Point(307, 37);
            this.btn_quem.Name = "btn_quem";
            this.btn_quem.Size = new System.Drawing.Size(381, 68);
            this.btn_quem.TabIndex = 1;
            this.btn_quem.Text = "Quem são eles?";
            this.btn_quem.UseVisualStyleBackColor = false;
            // 
            // frm_hollow
            // 
            this.BackgroundImage = global::bleach.Properties.Resources.ESPADAS__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 696);
            this.Controls.Add(this.btn_quem);
            this.Controls.Add(this.btn_voltar);
            this.MaximumSize = new System.Drawing.Size(1076, 735);
            this.MinimumSize = new System.Drawing.Size(968, 735);
            this.Name = "frm_hollow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOLLOW";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_quem;
    }
}