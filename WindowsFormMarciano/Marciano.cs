using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormMarciano
{
    public class Marciano : Arvore
    {
        public string acertou = "Fui atingido!";
        public string fim = "Vou te pegar!";
        public string orientacao1 = "Estou mais a direita!", orientacao2 = "Estou mais a esquerda!";
        public int posicao = 0;
    }
}