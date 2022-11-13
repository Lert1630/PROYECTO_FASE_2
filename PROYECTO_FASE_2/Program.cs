using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FASE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Yellow;

            string usuario;
            Console.WriteLine("Ingrese el usuario que entrara al sistema");
            usuario = Console.ReadLine();
        menu:
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("       Bienvenido al sistema " + usuario);
            Console.WriteLine("       Ingrese entre las opciones");
            Console.WriteLine("       1. Ventilacion");
            Console.WriteLine("       2. Calefaccion");
            Console.WriteLine("       3. Iluminacion");
            Console.WriteLine("       4. Panel de Control");
            Console.WriteLine("       5. Salir ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.WriteLine("Esta opcion esta desabilitada");
                    Console.WriteLine("Precione enter para continuar");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    goto menu;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.WriteLine("Esta opcion esta desabilitada");
                    Console.WriteLine("Precione enter para continuar");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    goto menu;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.WriteLine("Esta opcion esta desabilitada");
                    Console.WriteLine("Precione enter para continuar");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    goto menu;
                    break;


                case 4:
                    int control = 0;
                Menus:
                    Console.Clear();
                    Console.WriteLine("       Bienvenido al panel de control");
                    Console.WriteLine("       1. Sistema de ventilacion");
                    Console.WriteLine("       2. Configuracion de temperatura");
                    Console.WriteLine("       3. Promedio de las temperaturas");
                    Console.WriteLine("       4. Regresar al menu principal");



                    control = int.Parse(Console.ReadLine());

                    switch (control)
                    {
                        case 1:
                            int encendido, apagado, temperatura, hora, calculo;
                            Console.Clear();
                            Console.WriteLine("Programar horas de encendido y de apagado");
                            Console.WriteLine("Ingresar solo las horas");
                            Console.WriteLine("Ingresar horas de encendido");
                            encendido= Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresar horas de apagado");
                            apagado= Int32.Parse(Console.ReadLine());
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingrese la hora");
                            hora = Int32.Parse(Console.ReadLine());
                            Random rdm = new Random();
                            temperatura = rdm.Next(1,100);
                            calculo = temperatura - 70;

                            Console.ReadKey();
                            if (hora <= apagado)
                            {
                                if (temperatura == 70)
                                {
                                    Console.ReadKey();
                                    Console.WriteLine("La temperatura del exterior es: " + temperatura);
                                    Console.WriteLine("la temperatura esta en su nivel optimo");

                                }
                                else
                                {
                                    if (temperatura >= 70)
                                    {
                                        Console.ReadKey();
                                        Console.WriteLine("La temperatura del exterior es: " + temperatura);
                                        Console.WriteLine("La temperatura esta a " + calculo + " arriba de los niveles optimos");
                                        Console.WriteLine("la temperatura exterior esta alta de la optima");
                                        Console.WriteLine("la temperatura se bajara al 70%");
                                    }
                                    else
                                    {
                                        if (temperatura <= 70)
                                        {
                                            Console.ReadKey();
                                            Console.WriteLine("La temperatura del exterior es: " + temperatura);
                                            Console.WriteLine("La temperatura esta a " + calculo + " abajo de los niveles optimos");
                                            Console.WriteLine("la temperatura exterior esta baja de la optima");
                                            Console.WriteLine("la temperatura se subira al 70%");
                                        }
                                    }
                                }
                            }
                            else
                            { 

                            if (hora >= apagado)
                            {
                                    Console.WriteLine("A esta hora la ventilacion esta apagada ");
                                    Console.ReadKey();

                                }
                            }
                            Console.ReadKey();
                            goto Menus;
                            break;
                        case 2:
                            int grados;
                            string habitacion;
                            Console.Clear();
                            Console.WriteLine("Configuracion de temperaturas maximas y minimas");
                            Console.WriteLine("Temperatura maxima es 22");
                            Console.WriteLine("Temperatura minima es 18");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Bienvenido al sistema de calefaccion");
                            Console.WriteLine("En que habitacion se encuentra");
                            habitacion = Console.ReadLine();

                            Random random = new Random();
                            grados = random.Next(1, 100);
                            
                            int menu;
                            Console.Clear();
                            Console.WriteLine("       Entrara a la " + habitacion);
                            Console.WriteLine("       1. Si");
                            Console.WriteLine("       2. No");

                            menu = int.Parse(Console.ReadLine());

                            switch (menu)
                            {
                                case 1:
                                    if (grados == 22)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("La habitacion es encendida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Los grados de la habitacion son " + grados);
                                        Console.WriteLine("la temperatura es la deseada");
                                    }
                                    if (grados == 18)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("La habitacion es encendida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Los grados de la habitacion son " + grados);
                                        Console.WriteLine("la temperatura es la deseada");
                                    }
                                    if (grados > 22)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("La habitacion es encendida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Los grados de la habitacion son " + grados);
                                        Console.WriteLine("la temperatura esta alta, no es la otima");
                                        Console.WriteLine("La temperatura maxima deseada es 22");
                                        
                                    }
                                    if (grados < 18)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("La habitacion es encendida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Los grados de la habitacion son " + grados);
                                        Console.WriteLine("la temperatura esta muy baja, no es la optima");
                                        Console.WriteLine("La temperatura minima deseada es 18");
                                    }

                                        break;

                                case 2:
                                    Console.WriteLine("El radiador de la " + habitacion + " esta apagada");

                                    break;
                            }

                            Console.ReadKey();
                            goto menu;

                            break;
                        case 3:
                            int sumama,sumami, f,n, promedioma,promediomi, maxi,mini;
                            sumama = 0;
                            sumami = 0;
                            string cuarto;
                            Console.Clear();
                            Console.WriteLine("Cuantas habitaciones configurar: ");
                            n = Int32.Parse(Console.ReadLine());
                            for (f = 1; f <= n; f++)
                            {
                                Console.WriteLine("Ingrese la habitacion que desea configurar");
                                cuarto = Console.ReadLine();
                                Console.WriteLine("Temperaturas maximas");
                                Random random1= new Random();
                                maxi = random1.Next(19, 22);
                                Console.WriteLine("La temperatura es: "+maxi); 
                                sumama = sumama + maxi;
                                Console.WriteLine("Temperaturas minimas");
                                Random random2 = new Random();
                                mini = random1.Next(1, 18);
                                Console.WriteLine("La temperatura es: " + mini);
                                sumami = sumami + mini;
                                Console.ReadKey();
                            }
                            promediomi = sumami / n;
                            promedioma = sumama / n;
                            Console.WriteLine("El promedio de las temperaturas maximas es : "+promedioma);
                            Console.WriteLine("El promedio de las temperaturas minima es : " + promediomi);
                            Console.ReadKey();
                            goto Menus;

                            break;
                        case 4:
                            goto menu;
                            break;


                    }
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ingrese una opción entre 1 a 5");
                    break;
            }

            Console.ReadKey();
        }
    }
}
