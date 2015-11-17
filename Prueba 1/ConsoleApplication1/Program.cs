using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1-La primera prueba consiste en escribir una aplicación de consola en C# que pida por pantalla un texto y un número.
                
             * -El entero representa un número de columnas. 
                -La aplicación tiene que devolver el texto con saltos de líneas insertados, de forma que ninguna de las líneas sea más larga
                 (el número de caracteres, incluidos espacios) que el número de columnas que le hemos indicado.
                -Intenta que las líneas sean lo más largas posible, dentro del límite, y siempre que puedas, pon el salto de línea en el espacio entre palabras.
                -Igual que un procesador de texto, el salto de línea reemplaza el espacio entre palabras (es decir, ni la línea anterior ni la siguiente, terminan o empiezan con espacio).*/

            int numcolum = 0,contcar = 0,contn = 0;
            string texto = "";

            System.Console.WriteLine("Prueba 1\n");
            //Texto
            System.Console.WriteLine("Introduzca un texto");
            texto = Console.ReadLine();
            //Columnas
            System.Console.WriteLine("\nIntroduzca el numero de columnas");
            numcolum = Convert.ToInt32(Console.ReadLine());

            //Mostrar Texto original y columnas seleccionadas
            System.Console.WriteLine("\nTexto original\n"+texto+"\n");
            System.Console.WriteLine("Numero de columnas: " + numcolum + "\n");

            //Texto con saltos de lineas
            for (int i = 0; i < texto.Length;i++)
            {   
                //Si es espacio, saltamos de linea
                if(texto[i].Equals(' '))
                {
                    System.Console.Write("\n");
                    //Reseteamos el contador para la siguiente palabra
                    contcar = 0;
                    //Contamos los saltos de líneas para que cuando haya uno después del espacio y sea igual al numero x de columnas no ponga otro más
                    contn++;
                }
                else
                {
                    contcar++;
                    //Mostrar letra
                    System.Console.Write(texto[i]);

                    if (contcar == numcolum)
                    {
                        contn++;
                        if(contn <= 1)
                        {
                            System.Console.Write("\n");
                            //Reseteamos el contador para la siguiente palabra
                            contcar = 0;
                        }
                    }

                    //Reseteamos los saltos de líneas
                    contn = 0;
                }
            }

            System.Console.ReadKey();
        }
    }
}
