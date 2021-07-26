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
    }
}
