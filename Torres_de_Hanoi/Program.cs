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


            // Introducimos el metodo para la resolución
            Console.WriteLine("Introduzca 1 para la solución iterativa, 2 para la recursiva");
            String opcion;
            opcion=Console.ReadLine();
            int numopcion;

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

            // Comprobamos si el numero es valido
            try
            {
                if(!int.TryParse(opcion, out numopcion)){
                
                    numero = false;
                    throw new ArgumentException("Opcion introducida no valida.");
                
                }
            }
            catch (ArgumentException erroropcion)
            {
                Console.WriteLine("Opcion introducida no valida, pulse cualquier tecla para cerrar el programa.");
            }

            
            // Si el numero es valido empezamos las operaciones
            if(numero){
            
                n = int.Parse(texto);
                numopcion = int.Parse(opcion);

                if(n<=0){
                    Console.WriteLine("Introduce un numero mayor que 0, pulse cualquier tecla para cerrar el programa");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("El numero introducido es: " + n.ToString());

                List<Disco> discos = new List<Disco>();

                for(int i = 0; i < n; i++){
                 discos.Add(new Disco(n-i));
                }
                Console.WriteLine("Discos creados: " + discos.Count.ToString());

                // Creamos la primera pila
                Pila primera = new Pila(discos.Count, discos[discos.Count-1].Valor, discos, "Ini");
                // Creamos la segunda pila
                Pila segunda = new Pila("Aux");
                // Creamos la tercera pila
                Pila tercera = new Pila("Fin");

                if(numopcion == 1){
                    Console.WriteLine("Opcion iterativa");

                     int moves = Hanoi.iterativo(n,primera,segunda,tercera);
                     if(moves != (Math.Pow(2,n)-1)){
                    
                        Console.WriteLine("Movimientos solución iterativa: " + moves.ToString() + " solución incorrecta");

                     }else{

                        Console.WriteLine("Movimientos solución iterativa: " + moves.ToString() + " solución en el minimo numero de movimientos");

                     }
                }
                else{
                    Console.WriteLine("Opcion recursiva");

                    int moves = Hanoi.recursivo(n,primera,segunda,tercera);
                
                    if(moves != (Math.Pow(2,n)-1)){
                    
                        Console.WriteLine("Movimientos solución recursiva: " + moves.ToString() + " solución incorrecta");

                    }else{

                        Console.WriteLine("Movimientos solución recursiva: " + moves.ToString() + " solución en el minimo numero de movimientos");

                    }
                }
                
            }
            Console.WriteLine("Fin.");
            Console.ReadKey();
        }
    }
}
