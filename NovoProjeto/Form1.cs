using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoProjeto
{
    public partial class Form1 : Form
    {
        decimal saldoAtual = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal addSaldo;

            addSaldo = Convert.ToDecimal(textBox1.Text);            
            saldoAtual = saldoAtual + addSaldo;

            label3.Text = "R$ " + Convert.ToString(saldoAtual) + ".00";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal transfSaldo;

            transfSaldo = Convert.ToDecimal(textBox3.Text);

            if (saldoAtual < transfSaldo)
            {
                label11.Text = "* Saldo insuficiente!";
                label12.Text = "";
            }
            else
            {
                saldoAtual = saldoAtual - transfSaldo;

                label3.Text = "R$ " + Convert.ToString(saldoAtual) + ".00";
                label12.Text = "Transferência feita com sucesso!";
                label11.Text = "";               

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
