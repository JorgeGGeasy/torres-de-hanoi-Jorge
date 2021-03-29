using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public static int movimientos = 0;

        public static void mover_disco(Pila a, Pila b)
        {

            Disco discoMover;

            // Compruebo si las dos pilas estan vacias
            if(a.isEmpty() && b.isEmpty()){
                return;
            }

            // Compruebo si b esta vacia o si b tiene un disco de mayor tamaño que a (todas estas condiciones requieren que a no este vacia)
            else if (b.isEmpty() || b.Top > a.Top && a.isEmpty() == false ){
                
                discoMover = a.pop();
                Console.WriteLine("Moviendo disco de tamaño " + discoMover.Valor.ToString() + " de " + a.Nombre + " a " + b.Nombre);
                if (discoMover.Valor != 0) {
                    b.push(discoMover);
                }
                return;
            }

            // Compruebo si a esta vacia o si a tiene un disco de mayor tamaño que b (todas estas condiciones requieren que b no este vacia)
            else if (a.isEmpty() || a.Top > b.Top && b.isEmpty() == false ){

                discoMover = b.pop();
                Console.WriteLine("Moviendo disco de tamaño " + discoMover.Valor.ToString() + " de " + b.Nombre + " a " + a.Nombre);
                if (discoMover.Valor != 0){
                    a.push(discoMover);
                }
                return;
            }
        }

        public static int iterativo(int n, Pila ini, Pila aux, Pila fin)
        {
            // Si tenemos un numero de discos par
            while(n%2==0){
                
                mover_disco(ini,aux);
                movimientos++;
                if(fin.Size==n){
                    return movimientos;
                }
                
                mover_disco(ini,fin);
                movimientos++;
                if(fin.Size==n){
                    return movimientos;
                }

                mover_disco(aux,fin);
                movimientos++;
                if(fin.Size==n){
                    return movimientos;
                }
            }
            // Si tenemos un numero de discos impar
            while(n%2!=0){
            
                mover_disco(ini,fin);
                movimientos++;
                if(fin.Size==n){
                    return movimientos;
                }
                
                mover_disco(ini,aux);
                movimientos++;
                if(fin.Size==n){
                    return movimientos;
                }

                mover_disco(aux,fin);
                movimientos++;
                if(fin.Size==n){
                    return movimientos;
                }                
            }
            return movimientos;
        }
        
        public static int recursivo(int n, Pila ini, Pila aux, Pila fin)
        {
            // Si n es igual a 1
            if(n==1){
                
                mover_disco(ini,fin);
                movimientos++;
                return movimientos;
            }

            // Si n es mayor que 1
            else{

                movimientos = recursivo(n-1,ini,fin,aux);
                mover_disco(ini,fin);

                movimientos++;
                movimientos = recursivo(n-1,aux,ini,fin);

            }
            return movimientos;
        }

    }
}
