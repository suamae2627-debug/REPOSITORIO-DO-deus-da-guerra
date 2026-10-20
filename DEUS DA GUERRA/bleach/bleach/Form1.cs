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
    public partial class frm_bleach : Form
    {
        public frm_bleach()
        {
            InitializeComponent();
        }

        private void btn_humano_Click(object sender, EventArgs e)
        {
            frm_humanos humanos = new frm_humanos(); // instanciando (criando) um objeto
            humanos.Show();// chamando a tela renomeada como "humanos"
            Hide();// fecha a tela anterior 

        }
        
        private void frm_bleach_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();// serve para fechar a tela anterior


        }

        private void btn_shinigami_Click(object sender, EventArgs e)
        {
            frm_shinigamis shinigamis = new frm_shinigamis(); // instanciando (criando) um objeto
            shinigamis.Show();// chamando a tela renomeada como "shinigamis"
            Hide();// fecha a tela anterior 
        }

        private void btn_hollow_Click(object sender, EventArgs e)
        {
            frm_hollow hollow = new frm_hollow(); // instanciando (criando) um objeto
            hollow.Show();// chamando a tela renomeada como "hollow"
            Hide();// fecha a tela anterior 
        }

        private void btn_quincy_Click(object sender, EventArgs e)
        {
            frm_quincy quincy = new frm_quincy(); // instanciando (criando) um objeto
            quincy.Show();// chamando a tela renomeada como "bleach"
            Hide();// fecha a tela anterior
        }

           

    }

}

