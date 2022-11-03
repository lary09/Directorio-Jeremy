using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directorio
{
    public class Menu : Modificaciones
    {
        string opcionMenu = "";
        public void iniciar()
        {
            do
            {
                encabezado();

            } while (opcionMenu != "0");
        }
        public void encabezado()
        {
            Console.WriteLine("-------------------Bienvenidos a mi directorio-------------");
            Console.WriteLine("\n");
            Console.WriteLine("-------------------Menu Principal--------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("1.[Crear usuario]      |  2.[Lista de usuario]");
            Console.WriteLine("3.[Modificar usuario]  |  4.[Eliminar usuario]");
            Console.WriteLine("5.[Buscar usuario]     |  0.[Salir");
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione una opcion.");
            opcionMenu = Console.ReadLine();
            opcionesMenu(opcionMenu);


        }
        public void opcionesMenu(string opciones)
        {
            if (opciones == "")
                return;
            switch (opciones)
            {
                case "1":
                    Console.Clear();
                    crearUsuario();
                    RetornarMenu();
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    mostrarUsuiario();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    modificar();
                    RetornarMenu();
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    Eliminar();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Buscar();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "0":
                    Console.Clear();
                    salir();
                    Console.ReadKey();
                    break;
                case "r":
                    Console.Clear();
                    encabezado();
                    Console.ReadKey();
                    break;
                default:

                    Console.Write("Seleccion invalida ");
                    Console.WriteLine("\n");
                    RetornarMenu();
                    break;
            }

        }
        public void RetornarMenu()
        {
            string opcion;
            Console.WriteLine("Presione r para retornar al menu principal");
            opcion = Console.ReadLine();
            while(opcion != "r")
            {
                Console.WriteLine("Presione r para retornar al menu principal");
                opcion = Console.ReadLine();
                
                
            }
             
            opcionesMenu(opcion);
        }

    }
}
