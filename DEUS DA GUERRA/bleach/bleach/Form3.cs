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
    public partial class frm_shinigamis : Form
    {
        public frm_shinigamis()
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
            MessageBox.Show("Os Shinigamis (Ceifeiros de Almas) são entidades espirituais militares que residem na Soul Society. Eles atuam como guardiões da balança cósmica, tendo como missão principal regular o fluxo de almas entre o mundo dos vivos e o pós-morte.\r\nA base do seu trabalho consiste em duas funções essenciais: guiar as almas perdidas para o além e combater os Hollows. Ao contrário dos Quincys, que destroem os monstros, os Shinigamis usam espadas especiais chamadas Zanpakutous para purificar os Hollows. Esse processo limpa os pecados da criatura e permite que a alma reentre no ciclo de reencarnações, garantindo que o universo não entre em colapso por falta ou excesso de energia espiritual.\r\nEm suma, os Shinigamis representam a ordem e o ciclo natural da vida e da morte. Organizados no exército do Gotei 13, eles usam técnicas que vão desde artes marciais e feitiços (Kido) até liberações de poder como a Shikai e a Bankai, sacrificando as próprias vidas para que o sistema espiritual continue funcionando.", "Shinigami", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
