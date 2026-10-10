using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validacao
{
    public partial class frm_validacao : Form
    {
        public frm_validacao()
        {
            InitializeComponent();
        }

        private void lbl_ValCPF_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SÓ PERMITE LETRAS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (e.KeyChar==13)
            {
                if (txt_nome.Text != "")
                {
                    txt_idade.Focus();

                }

                 else

                {
                    MessageBox.Show("O NOME NÃO FOI DIGITADO...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SÓ PERMITE NUMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (e.KeyChar == (char)13)
            {
                if (txt_idade.Text.Trim() != "")
                {
                    txt_cpf.Focus();

                }

                else

                {
                    MessageBox.Show("A IDADE NÃO FOI DIGITADO...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SÓ PERMITE NUMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (e.KeyChar == (char)13)
            {
                if (txt_cpf.Text.Trim() != "")
                {
                    lbl_nome.Focus();

                }

                else

                {
                    MessageBox.Show("O CPF NÃO FOI DIGITADO...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                  
                   this.txt_cpf = CharacterRange.

            }
        }
    }
}
