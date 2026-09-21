using System;
using System.Collections.Generic;
using System.Text;

namespace problema_guerradelchaco
{
    public class GuerradelChaco_ejercicio
    {
        public static void Main(string[] args)
        {

            int agua = 100;
            int soldados = 10;
            int dia = 1;
            int opcion;

            Console.WriteLine("==========================================");
            Console.WriteLine("     GUERRA DEL CHACO - BOQUERÓN 1932");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Eres responsable de un pequeño grupo");
            Console.WriteLine("de soldados bolivianos dentro de Boquerón.");
            Console.WriteLine("El fortín está rodeado y los suministros");
            Console.WriteLine("son cada vez más escasos.");
            Console.WriteLine();

            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("DÍA " + dia);
                Console.WriteLine("Soldados: " + soldados);
                Console.WriteLine("Agua disponible: " + agua + "%");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("¿Qué decisión quieres tomar?");
                Console.WriteLine("1. Repartir agua normalmente");
                Console.WriteLine("2. Racionar el agua");
                Console.WriteLine("3. Intentar conseguir agua");
                Console.WriteLine("4. Esperar dentro del fortín");
                Console.WriteLine("5. Salir de la simulación");
                Console.Write("Opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    agua -= 30;

                    Console.WriteLine();
                    Console.WriteLine("Los soldados reciben una ración normal.");

                    if (agua <= 0)
                    {
                        agua = 0;
                        Console.WriteLine("¡Se terminó el agua!");
                    }
                    else if (agua <= 30)
                    {
                        Console.WriteLine("ADVERTENCIA: queda muy poca agua.");
                    }
                    else
                    {
                        Console.WriteLine("Todavía existe una reserva de agua.");
                    }
                }
                else if (opcion == 2)
                {
                    agua -= 10;

                    Console.WriteLine();
                    Console.WriteLine("Se reduce la cantidad de agua entregada.");
                    Console.WriteLine("Los soldados deben soportar la sed.");

                    if (agua <= 20)
                    {
                        Console.WriteLine("La situación comienza a ser crítica.");
                    }
                    else
                    {
                        Console.WriteLine("La reserva puede durar un poco más.");
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Un grupo intenta buscar agua.");

                    Random aleatorio = new Random();
                    int resultado = aleatorio.Next(1, 101);

                    if (resultado <= 30)
                    {
                        agua += 25;

                        if (agua > 100)
                        {
                            agua = 100;
                        }

                        Console.WriteLine("¡Encontraron una pequeña fuente de agua!");
                        Console.WriteLine("La reserva aumenta.");
                    }
                    else if (resultado <= 70)
                    {
                        agua -= 5;
                        Console.WriteLine("No encontraron agua.");
                        Console.WriteLine("El grupo regresó agotado.");
                    }
                    else
                    {
                        agua -= 15;
                        soldados -= 1;

                        Console.WriteLine("La búsqueda fue peligrosa.");
                        Console.WriteLine("Un soldado no pudo regresar.");
                    }
                }
                else if (opcion == 4)
                {
                    agua -= 15;

                    Console.WriteLine();
                    Console.WriteLine("Los soldados permanecen en sus posiciones.");
                    Console.WriteLine("La reserva de agua continúa disminuyendo.");

                    if (agua <= 25)
                    {
                        Console.WriteLine("¡La falta de agua es crítica!");
                    }
                }
                else if (opcion == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Has terminado la simulación.");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                // Evitamos valores negativos
                if (agua < 0)
                {
                    agua = 0;
                }

                // Si quedan pocos soldados
                if (soldados <= 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("La unidad está gravemente debilitada.");
                }

                // Condición de derrota
                if (agua == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("        SITUACIÓN CRÍTICA");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("La unidad se ha quedado sin agua.");
                    Console.WriteLine("La supervivencia se vuelve extremadamente");
                    Console.WriteLine("difícil debido al cerco.");
                    break;
                }

                dia++;

                // Simulación de varios días
                if (dia > 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Han pasado demasiados días.");
                    Console.WriteLine("La situación del fortín se vuelve insostenible.");
                    break;
                }

            } while (agua > 0 && soldados > 0);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("             FIN DEL PROGRAMA");
            Console.WriteLine("==========================================");
            Console.WriteLine("Días simulados: " + dia);
            Console.WriteLine("Agua restante: " + agua + "%");
            Console.WriteLine("Soldados restantes: " + soldados);

            Console.WriteLine();
            Console.WriteLine("La escena está inspirada en las condiciones");
            Console.WriteLine("de escasez sufridas durante el sitio de");
            Console.WriteLine("Boquerón en la Guerra del Chaco.");

            Console.ReadKey();
        }
    } 
}






