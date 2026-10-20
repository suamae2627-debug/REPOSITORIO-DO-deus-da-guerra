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
    public partial class frm_quincy : Form
    {
        public frm_quincy()
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
            // Exibe a caixinha de mensagem ao clicar no botão btn_quem
            MessageBox.Show("Olá! Esta é a mensagem de texto do botão Quem.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_quem_Click_1(object sender, EventArgs e)
        {
            // Exibe a caixinha de mensagem ao clicar no botão btn_quem
            MessageBox.Show("Os Quincys são humanos vivos com alta capacidade espiritual que decidiram caçar os Hollows (monstros que devoram almas) para proteger a humanidade.\r\nO grande problema é o método que eles usam: ao contrário dos Shinigamis, que purificam e salvam as almas, os Quincys as destroem completamente. Eles fazem isso manipulando a energia do ambiente (Reishi) para criar armas de luz. Essa destruição total quebra o ciclo de reencarnações e ameaça colapsar o universo, o que gerou uma guerra milenar e o quase extermínio da raça pelo exército dos Shinigamis.\r\nEm suma, os Quincys representam o perigo da justiça extrema. Liderados pelo imperador Yhwach e escondidos no império Wandenreich, eles deixam de ser apenas caçadores para se tornarem a maior ameaça de vingança contra o mundo espiritual.", "Quincy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
