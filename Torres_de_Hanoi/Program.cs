using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducimos el numero de discos
            Console.WriteLine("Introduzca un numero");
            String texto;
            texto=Console.ReadLine();
            int n;
            bool numero = false;

            // Comprobamos si el numero es valido
            try
            {
                if(!int.TryParse(texto, out n)){
                
                    throw new ArgumentException("Numero introducido no valido.");
                
                }
                numero = true;
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Numero introducido no valido, pulse cualquier tecla para cerrar el programa.");
            }
            
            // Si el numero es valido empezamos las operaciones
            if(numero){
            
                n = int.Parse(texto);

                if(n<=0){
                    Console.WriteLine("Introduce un numero mayor que 0, pulse cualquier tecla para cerrar el programa");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("El numero introducido es: " + n.ToString());

                List<Disco> discos = new List<Disco>();
                List<Disco> discosRecursivos = new List<Disco>();

                for(int i = 0; i < n; i++){
                 discos.Add(new Disco(n-i));
                 discosRecursivos.Add(new Disco(n-i));
                }
                Console.WriteLine("Discos creados: " + discos.Count.ToString());

                // Creamos la primera pila
                Pila primera = new Pila(discos.Count, discos[discos.Count-1].Valor, discos, "Ini");
                // Creamos la segunda pila
                Pila segunda = new Pila("Aux");
                // Creamos la tercera pila
                Pila tercera = new Pila("Fin");

                // Creamos la primera pila recursiva
                Pila primeraRecursiva = new Pila(discosRecursivos.Count, discosRecursivos[discosRecursivos.Count-1].Valor, discosRecursivos, "Ini");
                // Creamos la segunda pila recursiva
                Pila segundaRecursiva = new Pila("Aux");
                // Creamos la tercera pila recursiva
                Pila terceraRecursiva = new Pila("Fin");

                Console.WriteLine("Resolución iterativa: ");

                int moves = Hanoi.iterativo(n,primera,segunda,tercera);
                Console.WriteLine("Movimientos solución iterativa: " + moves.ToString());
                
                // Reseteamos la variable movimientos de Hanoi a su valor original
                Hanoi.movimientos=0;

                Console.WriteLine("Resolución recursiva: ");
                
                int movesRecursivos = Hanoi.recursivo(n,primeraRecursiva,segundaRecursiva,terceraRecursiva);
                Console.WriteLine("Movimientos solución recursiva: " + movesRecursivos.ToString());
            }

            Console.WriteLine("Fin.");
            Console.ReadKey();
        }
    }
}
