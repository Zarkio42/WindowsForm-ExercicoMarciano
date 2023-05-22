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
                MessageBox.Show(win, marciano.acertou);
            }
            else if (valorUpdown < marciano.posicao)
            {
                MessageBox.Show(this, marciano.orientacao1);
            }
            else
            {
                MessageBox.Show(this, marciano.orientacao2);
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
            int valorUpdown = (int)numericUpDown1.Value;
            cacador.bala--;

            if (cacador.bala == 0 && valorUpdown != marciano.posicao)
            {
                form2.Show();
                MessageBox.Show(form2, marciano.gameOver);
            }
            
        }
    }
}
