using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // cria variável que recebe a conversão
            int num1 = Convert.ToInt32(txtNum.Text);
            // tenta a conversão do que é digitado para inteiro
            int.TryParse(txtNum.Text, out num1);
            // cria outra variável que recebe o dobro de num1
            int num2 = num1 * 2;
            // lblMsg.text recebe a string
            lblMsg.Text = $"O número digitado é {num1}\nO dobro é {num2}";
            // torna visível o lblMsg desativado no design
            lblMsg.Visible = true;
        }
    }
}
