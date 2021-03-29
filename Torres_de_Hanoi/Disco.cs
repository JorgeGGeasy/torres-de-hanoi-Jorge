using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        // Disco solo tiene un dato que me interese, el tamaño
        private int tamanyo;

        public int Valor {
            get
            {
                return this.tamanyo;
            } 
            
            set
            { 
                this.tamanyo = value;

            }
        }

        public Disco(int tamanyo){
            this.tamanyo = tamanyo;
        }

    }
}
