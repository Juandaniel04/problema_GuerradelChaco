using System;
using System.Collections.Generic;
using System.Text;

namespace problema_guerradelchaco
{
    public class  programa_GuerradelChaco
    {
        public static void Main(string[] args)
        {
            int agua = 100;
            int soldados = 10;
            int dia = 1;
            int opcion;

            Console.WriteLine("================================================");
            Console.WriteLine("     GUERRA DEL CHACO - BOQUERON 1932");
            Console.WriteLine("================================================");
            Console.WriteLine();
            Console.WriteLine("Eres responsable de un pequeño grupo");
            Console.WriteLine("de soldados bolivianos dentro del boqueron");
            Console.WriteLine("El fortin esta rodeado y los suministros");
            Console.WriteLine("son cada ves mas escasos");
            Console.WriteLine();

            do
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("DIA" + dia);
                Console.WriteLine("Soldados" + soldados);
                Console.WriteLine("Agua disponible:" + agua);
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("¿Que decicion quieres tomar?");
                Console.WriteLine("1. Repartir agua normalmente");
                Console.WriteLine("2. Racionar el agua");
                Console.WriteLine("3. Intentar consegir agua");
                Console.WriteLine("4. Esperar dentro del fortin");
                Console.WriteLine("5. Salir de la simulacion");
                Console.Write("Opcion");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    agua -= 20;

                    Console.WriteLine("Los soldados reciben una racion normal");

                    if (agua <= 0)
                    {
                        agua = 0;
                        Console.WriteLine("¡Se termino el agua¡");
                    }
                    else if (agua <= 30)
                    {
                        Console.WriteLine("ADVERTENCIA: queda muy poca agua");
                    }
                    else
                    {
                        Console.WriteLine("Todavia existe una reserva de agua");
                    }
                }
                else if (opcion == 2)
                {
                    agua -= 10;

                    Console.WriteLine("Se reduce la cantidad de agua entregada");
                    Console.WriteLine("Los soldados deben soportar la sed");

                    if (agua <= 20)
                    {
                        Console.WriteLine("La situacion comienza a ser critica");
                    }
                    else
                    {
                        Console.WriteLine("La reserva puede durar un poco mas");
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Un grupo intenta coseguir agua");

                    Random aleatorio = new Random();
                    int resultados = aleatorio.Next(1, 101);

                    if (resultados <= 30)
                    {
                        agua += 25;

                        if (agua <= 100)
                        {
                            agua = 100;
                        }

                        Console.WriteLine("¡Encontraron una pequeña fuente de agua¡");
                        Console.WriteLine("La reserva aumenta");

                    }
                    else if (resultados <= 70)
                    {
                        agua -= 5;

                        Console.WriteLine("No se encontraron agua");
                        Console.WriteLine("El grupo regreso agotado");
                    }
                    else
                    {
                        agua -= 15;
                        soldados -= 1;

                        Console.WriteLine("La busqueda fue peligrosa.");
                        Console.WriteLine("Un soldado no pudo regresar");


                    }

                }
                else if (opcion == 4)
                {
                    agua -= 15;

                    Console.WriteLine("Los soldados permanecen de sus posiciones");
                    Console.WriteLine("La reserva de agua continua disminuyendo");

                    if (agua <= 25)
                    {
                        Console.WriteLine("¡La flta de agua es critica¡");
                    }

                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Has terminado la simulacion");
                    break;
                }
                    
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opcion no valida");
                    continue;
                }
                if (agua < 0)
                {
                    agua = 0;
                }
                if (soldados <= 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("la unidad esta grabemente devilitada");
                }
                if (agua == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("          SITUACION CRITICA");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("La unidad se a quedado sin agua");
                    Console.WriteLine("La supervivencia se vuelve extremadamente");
                    Console.WriteLine("dificil debido al cerco");
                    break;
                }
                dia++;

                if (dia > 10)
                {
                    Console.WriteLine("Han pasado demacidos dias");
                    Console.WriteLine("La situacion del fortin se vuelve insostenible");
                    break;
                }

            } while(agua > 0 && soldados > 0);

            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("                 FIN DEL PROGRAMA");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Dias simulados:" + dia);
            Console.WriteLine("Agua restante:" + agua + "%");
            Console.WriteLine("Soldados restantes:" + soldados);

            Console.WriteLine();
            Console.WriteLine("La esena esta inspirada en las condicione");
            Console.WriteLine("de escases sufridas durante el sitio de");
            Console.WriteLine("Boqueron en la guerra del chaco.");


        }
    }
}
