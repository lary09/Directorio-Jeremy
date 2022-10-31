﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directorio
{
    public class Modificaciones
    {
        List<Usuarios> listUsuarios = new List<Usuarios>();
        string nombre;
        int ID;
        int telefono;
        string Email;
        string direccion;

        public void crearUsuario()
        {
            Console.WriteLine("---------Crear usuario--------------");
            Console.WriteLine("\n");
            Console.WriteLine("Los campos con * son obligatoios");
            Console.WriteLine("\n");

            Console.Write("Ingrese su nombre *");
            nombre = Console.ReadLine();
            if (nombre == "" || nombre == null)
            {
                Console.WriteLine("Este campo es obligatorio intentelo de nuevo");
                crearUsuario();
                Console.WriteLine("\n");
            }

            Console.Write("Ingrese su telefono *");
            telefono = int.Parse(Console.ReadLine());
            if (telefono == 0)
            {
                Console.WriteLine("Este campo es obligatorio intentelo de nuevo");
                crearUsuario();
                Console.WriteLine("\n");
            }

            Console.Write("Ingrese su correo electronico (Opcional)");
            Email = Console.ReadLine();
            Console.Write("Ingrese su direccion (Opcional)");
            direccion = Console.ReadLine();
            listUsuarios.Add(new Usuarios(ID, nombre, telefono, Email, direccion));
            Console.WriteLine("\n");

            Console.WriteLine("Usuario creado con exito");
            Console.WriteLine("\n");

        }
        public bool validarLista()
        {
            if (listUsuarios.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void mostrarUsuiario()
        {
            if (validarLista() == true)
            {
                Console.WriteLine("EL directorio esta vacio");
            }
            else
            {
                Console.WriteLine("Total de usuarios registrados " + listUsuarios.Count);
                Console.WriteLine("\n");
                Console.WriteLine("-------Lista de usuarios--------");
                foreach (Usuarios el in listUsuarios)
                {
                    impresionUsuarioPantalla(el);
                }
            }
            Console.WriteLine("\n");
        }
        public void impresionUsuarioPantalla(Usuarios ele)
        {

            Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
        }
        public void Eliminar()
        {
            string buscar;
            if (validarLista() == true)
            {
                Console.WriteLine("No hay elementos en la lista para eliminar");
            }
            else
            {
                Console.WriteLine("Ingrese el usuario que desea eliminar");
                buscar = Console.ReadLine();
                foreach (var ele in listUsuarios)
                {
                    if (buscar == ele.Nombre)
                    {
                        Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
                        listUsuarios.Remove(ele);
                        Console.WriteLine("\n");
                        Console.WriteLine("Usuario eliminado");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se encuentra el usuario");
                    }
                }

            }

        }
        public void modificar()
        {
            string buscar;
            if (validarLista() == true)
            {
                Console.WriteLine("No hay elementos en la lista para Modificar");
            }
            else
            {
                Usuarios usuario = new Usuarios();
                Console.WriteLine("Ingrese el usuario que desea Modificar: ");
                buscar = Console.ReadLine();
                
                foreach (Usuarios ele in listUsuarios)
                {
                    if (buscar == ele.Nombre)
                    {
                        Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
                        Console.WriteLine("------------------------------------------------");
                        Console.Write("Ingrese el nombreque desea modificar: ");
                        usuario.Nombre = Console.ReadLine();
                        ele.Nombre = usuario.Nombre; 
                        Console.Write("Ingrese el numero telefonico que desea modificar: ");
                        ele.Telefono = int.Parse(Console.ReadLine());
                        ele.Telefono = usuario.Telefono;
                        Console.Write("Ingrese el Email que desea modificar: ");
                        ele.Email = Console.ReadLine();
                        ele.Email = usuario.Email;
                        Console.Write("Ingrese la direccion que desea modificar: ");
                        ele.direccion = Console.ReadLine();
                        ele.direccion = usuario.direccion;
                        Console.WriteLine("\n");
                        Console.WriteLine("Los datos han sido modificados");

                    }
                }

            }
            Console.WriteLine("\n");
        }
        public void Buscar()
        {
            string buscar;
            if (validarLista() == true)
            {
                Console.WriteLine("No hay elementos en la lista para buscar");
            }
            else
            {
                Console.WriteLine("Ingrese el usuario que desea buscar");
                buscar = Console.ReadLine();
                foreach (var ele in listUsuarios)
                {
                    if (buscar == ele.Nombre)
                    {
                        Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
                        
                    }
                    else
                    {
                        Console.WriteLine("No se encuentra el usuario");
                    }
                }
            }
        }
        public void salir()
        {
            Console.WriteLine("Gracias por utilizar mi App");
            
        }
    }

}
