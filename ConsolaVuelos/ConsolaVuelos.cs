using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibVuelos;

namespace ConsolaVuelos
{
    class ConsolaVuelos
    {
        static void Main(string[] args)
        {
            IniciarMenu();
            Console.ReadLine();
        }
        static void IniciarMenu()
        {           
            ConsoleKeyInfo op;
            Console.Clear();

            //prueba de acceso a los ficheros
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\Datos\Vuelos.txt"))
                {
                    Console.WriteLine("Fichero de vuelos leído correctamente");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"No se ha encontrado el archivo: '{e}'");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"No se ha encontrado el directorio: '{e}'");
            }
            catch (IOException e)
            {
                Console.WriteLine($"No se ha podido abrir el archivo: '{e}'");
            }
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\Datos\Sectores.txt"))
                {
                    Console.WriteLine("Fichero de sectores leído correctamente");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"No se ha encontrado el archivo: '{e}'");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"No se ha encontrado el directorio: '{e}'");
            }
            catch (IOException e)
            {
                Console.WriteLine($"No se ha podido abrir el archivo: '{e}'");
            }

            Console.WriteLine();
            Console.WriteLine("MENU PRINCIPAL\n1 - Mostrar posición vuelos\n2 - Mostrar ocupación sector\n3 - Simulación\n4 - Guardar y Salir");
            do
            {
                ListaVuelos listaVuelo = new ListaVuelos();
                ListaVuelos cargar = new ListaVuelos();
                Sector sector = new Sector();
                ListaVuelos simulacion = new ListaVuelos();
                ListaVuelos guardar = new ListaVuelos();
                op = Console.ReadKey(true);

                //opciones del menú
                if (op.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    listaVuelo.MostrarVuelos();
                    IniciarMenu();
                }
                else if (op.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    sector.MostrarOcupacion();
                    IniciarMenu();
                }
                else if (op.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    simulacion.Simulacion();
                    IniciarMenu();
                }
                else if (op.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    guardar.Guardar();
                    Environment.Exit(0);
                }
                else if (op.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            } while (op.Key != ConsoleKey.Escape);
        }
    }
}