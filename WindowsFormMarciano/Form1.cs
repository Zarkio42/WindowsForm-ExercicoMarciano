using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormMarciano
{
    public partial class Form1 : Form
    {
        Arvore arvore = new Arvore();
        Marciano marciano = new Marciano();
        Cacador cacador = new Cacador();
        int contadorCliques;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            FormWin win = new FormWin();
            int valorUpdown = (int)numericUpDown1.Value;
            
            if (valorUpdown == marciano.posicao)
            {
                win.Show();
                MessageBox.Show(marciano.acertou);
            }
            else
            {
                MessageBox.Show("Errou amigão!");
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            marciano.posicao = random.Next(1, 10);            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void clickbtn(object sender, MouseEventArgs e)
        {
            

            Form2 form2 = new Form2();
            cacador.bala--;

            if (cacador.bala == 0)
            {
                form2.Show();
                MessageBox.Show("Vou te pegar!");
            }
            
        }
    }
}
