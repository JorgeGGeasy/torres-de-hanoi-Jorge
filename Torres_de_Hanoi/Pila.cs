using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private int discos;
        private int arriba;
        private List<Disco> elementos;



        public int Size { 
            get{  
                return this.discos;
            } 
            
            set{
               this.discos = value;
            } 
        }

        public int Top{
            get{
                return this.arriba;
            } 
            set{
                this.arriba = value;
            }
        }

        public List<Disco> Elementos {
            get{
                return this.elementos;
            } 
            set{
                this.elementos = value;
            }
        }

        public Pila(int discos, int arriba, List<Disco> elementos)
        {
            this.discos = discos;
            this.arriba = arriba;
            this.elementos = elementos;
        }

        public Pila()
        {
            this.discos = 0;
            this.arriba = -1;
            this.elementos = new List<Disco>();
        }

        // Añadimos el disco a la pila
        public void push(Disco d)
        {
                this.elementos.Add(d);
                this.discos++;
                this.arriba = d.Valor;

        }
        
        // Elimina el disco de la pila
        public Disco pop()
        {
            Disco Dpop = this.elementos[this.elementos.Count-1]; 
            this.elementos.RemoveAt(this.elementos.Count-1);
            this.Size--;
            this.Top = this.elementos[this.elementos.Count-1].Valor;
            return Dpop;
        }                
        
        // Comprobamos si la lista esta vacia
        public bool isEmpty()
        {
            if(elementos.Count == 0){
                return true;
            }
            return false;
        }

    }
}
