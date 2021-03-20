using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // cria variável que recebe 
            int num1 = Convert.ToInt32(txtNum.Text);
            // cria num2 que recebe o dobro de num1
            int num2 = num1 * 2;

            // atribui string a propriedade Text do lblMsg
            lblMsg.Text = $"Você digitou o número: {num1}\no dobro é {num2}";

            // ativa a propriedade Visible inativa no Design
            lblMsg.Visible = true;
        }
    }
}

