using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bleach
{
    public partial class frm_hollow : Form
    {
        public frm_hollow()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_bleach bleach = new frm_bleach(); // instanciando (criando) um objeto
            bleach.Show();// chamando a tela renomeada como "bleach"
            Hide();// fecha a tela anterior 
        }

        private void frm_bleach_FormsClosed(object sender, EventArgs e)
        {
            Application.Exit();// serve para fechar a tela anterior
        }

        private void btn_quem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Os Hollows são almas de humanos mortos que não conseguiram fazer a passagem para o além e acabaram corrompidas pelo arrependimento ou pelo desespero. Ao perderem o coração, eles se tornam monstros devoradores de almas, marcados por uma máscara branca e um buraco no peito (que representa o vazio de sua humanidade).\r\nO grande perigo surge quando esses monstros começam a se devorar no deserto do Hueco Mundo, evoluindo para classes superiores de poder. Sob o comando do ex-capitão shinigami Sosuke Aizen, os Hollows mais fortes conseguiram quebrar suas máscaras e ganhar poderes de Shinigami, tornando-se os chamados Arrancars. A elite máxima desse exército é o grupo dos Espadas, dez guerreiros numerados de 0 a 10 com base na sua força monstruosa e que representam diferentes aspectos da morte (como a solidão, o desespero ou a destruição).\r\nEm suma, os Hollows representam a tragédia e a fúria das almas esquecidas. Enquanto os monstros comuns atacam por instinto selvagem na Terra, os Espadas — como Ulquiorra Cifer e Grimmjow Jaegerjaquez — agem com inteligência e um poder devastador capaz de rivalizar e superar os capitães shinigamis mais experientes.", "Hollows", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
