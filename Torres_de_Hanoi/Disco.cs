using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */

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
