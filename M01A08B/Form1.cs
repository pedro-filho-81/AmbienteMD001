using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // cria a variável nome
            string nome = txtNome.Text;
            // adiciona a string a propriedade Texto do lblMsg
            lblMsg.Text = "Muito prazer em te conhecer, " + nome + "!";
            // coloca a caixa lblMsg. Visible visível
            lblMsg.Visible = true;
        }
    }
}
