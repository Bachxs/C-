using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class FrmProdutocs : Form
    {
        public FrmProdutocs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutocs_Load(object sender, EventArgs e)
        {

        }








        private void button1_Click(object sender, EventArgs e)
        {
            Converter Converter = new Converter();
            Converter.dolar = Convert.ToInt32(textBox1.Text);
            Converter.nome = (textBox3.Text);
            Converter.endereço = (textBox2.Text);
            MessageBox.Show(Converter.converterD());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Converter Converter = new Converter();
            Converter.libra = Convert.ToInt32(textBox1.Text);
            Converter.nome = (textBox3.Text);
            Converter.endereço = (textBox2.Text);
            MessageBox.Show(Converter.converterL());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Converter Converter = new Converter();
            Converter.euro = Convert.ToInt32(textBox1.Text);
            Converter.nome = textBox3.Text;
            Converter.endereço = textBox2.Text;
            MessageBox.Show(Converter.converterE());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não estamos trabalhando com outras moedas.");
        }
    }
}
