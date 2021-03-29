using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        // Una pila tiene que darme los siguientes datos, cuantos discos tiene, que disco esta arriba, cada disco en detalle y cual es su nombre
        private int discos;
        private int arriba;
        private List<Disco> elementos;
        private string nombre;


        public int Size { 
            get{  
                return this.discos;
            } 
            
            set{
               this.discos = value;
            } 
        }

        public string Nombre { 
            get{  
                return this.nombre;
            } 
            
            set{
               this.nombre = value;
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

        // Constructor con todos los datos
        public Pila(int discos, int arriba, List<Disco> elementos, string nombre)
        {
            this.discos = discos;
            this.arriba = arriba;
            this.elementos = elementos;
            this.nombre = nombre;
        }
        
        // Constructor solo con el nombre
        public Pila(string nombre)
        {
            this.discos = 0;
            this.arriba = -1;
            this.elementos = new List<Disco>();
            this.nombre = nombre;
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
            Disco Dpop =  this.elementos.Last(); 
            this.elementos.RemoveAt(this.elementos.Count-1);
            this.discos--;
            if(this.discos>0){
                this.arriba = this.elementos.Last().Valor;
            }else{
                this.arriba=0;
            }

            return Dpop;

        }                
        
        // Comprobamos si la lista esta vacia
        public bool isEmpty()
        {
            if(this.discos == 0){
                return true;
            }
            return false;
        }

    }
}
