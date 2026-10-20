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
    public partial class frm_humanos : Form
    {
        public frm_humanos()
        {
            InitializeComponent();
        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os Humanos comuns vivem na Terra de forma alheia ao mundo espiritual, sendo incapazes de ver espíritos ou monstros. No entanto, uma pequena parcela dessa população possui uma alta energia espiritual e consegue interagir com esse lado oculto, servindo muitas vezes como o elo de conexão entre o mundo físico e o espiritual.\r\nO ápice do poder humano se manifesta nos Fullbringers, um grupo de humanos cujas mães sobreviveram a ataques de Hollows antes deles nascerem. Esse contato genético com os monstros deixou vestígios de energia em seus corpos, permitindo que eles manipulem a \"alma\" de objetos físicos. Através dessa técnica, chamada Fullbring, eles transformam itens de grande valor sentimental em armas ou habilidades de combate — como Yasutora Sado (Chad), que transforma sua própria pele em uma armadura de batalha, e Orihime Inoue, que usa suas presilhas de cabelo para rejeitar eventos passados.\r\nEm suma, os humanos espiritualmente ativos provam que o poder não pertence apenas aos mortos. Organizados em sociedades secretas como a Xcution, liderada por Kūgo Ginjō, os Fullbringers utilizam uma força de origem trágica e sombria, mostrando que a própria humanidade possui ferramentas para se defender das ameaças sobrenaturais.", "Humanos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
