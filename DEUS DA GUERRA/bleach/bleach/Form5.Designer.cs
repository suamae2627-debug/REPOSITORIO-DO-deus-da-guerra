namespace bleach
{
    partial class frm_quincy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_quincy));
            this.btn_quem = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quem
            // 
            this.btn_quem.BackColor = System.Drawing.Color.Transparent;
            this.btn_quem.FlatAppearance.BorderSize = 0;
            this.btn_quem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quem.Font = new System.Drawing.Font("Baskerville Old Face", 44.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quem.ForeColor = System.Drawing.Color.Black;
            this.btn_quem.Location = new System.Drawing.Point(519, 52);
            this.btn_quem.Name = "btn_quem";
            this.btn_quem.Size = new System.Drawing.Size(421, 89);
            this.btn_quem.TabIndex = 0;
            this.btn_quem.Text = "Quem são eles?";
            this.btn_quem.UseVisualStyleBackColor = false;
            this.btn_quem.Click += new System.EventHandler(this.btn_quem_Click_1);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(118, 197);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(50, 343);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Vol\r\nt\r\na\r\nr\r\n\r\n";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_quincy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bleach.Properties.Resources.Quincy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 696);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_quem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_quincy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUINCYS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quem;
        private System.Windows.Forms.Button btn_voltar;
    }
}