using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace directorio
{
    public class Modificaciones: validacionCampos_Requeridos
    {
        List<Usuarios> listUsuarios = new List<Usuarios>();
        string nombre;
        int ID;
        long telefono;
        string Email;
        string direccion;

        //Aqui creamos el usuario
        public void crearUsuario()
        {
            Console.WriteLine("---------Crear usuario--------------");
            Console.WriteLine("\n");
            Console.WriteLine("Los campos con * son obligatoios");
            Console.WriteLine("\n");

            Console.Write("Ingrese su nombre *");
            nombre = Console.ReadLine();
            //validar si el campo nombre contiene numeros o espacios
            while (!Regex.IsMatch(nombre, @"^[a-zA-Z-\s*]+$"))
            {
                
                Console.WriteLine("El nombre solo debe contener letras");
                nombre = Console.ReadLine();

            }

            Console.Write("Ingrese su telefono *");

            //validamos que sea solo numeros en caso contrario retorna 0 y vualve al bucle
            long.TryParse(Console.ReadLine(), out telefono);
            
            while (telefono <= 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Digite correctamente su numero telefonico! \n");

                Console.Write("Ingrese su telefono *");
                long.TryParse(Console.ReadLine(), out telefono);
            }
            

            Console.Write("Ingrese su correo electronico (Opcional): ");
            Email = Console.ReadLine();
            Console.Write("Ingrese su direccion (Opcional): ");
            direccion = Console.ReadLine();
            Console.WriteLine("\n");
            listUsuarios.Add(new Usuarios(ID, nombre, telefono, Email, direccion));
            Console.WriteLine("\n");

            Console.WriteLine("Usuario creado con exito");
            Console.WriteLine("\n");

        }
        //Validamos is la lista de usuario esta vacia al momento de la consulta 
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
        //Mostramos el usuario si la lista tiene alquno registrado
        public void mostrarUsuiario()
        {
            if (validarLista() )
            {
                Console.WriteLine("EL directorio esta vacio");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Total de usuarios registrados " + listUsuarios.Count);
                Console.WriteLine("\n");
                Console.WriteLine("-------Lista de usuarios--------");
                Console.WriteLine("\n");
                // Recorremos la lista de usuarios y los mostramos por pantalla en caso de existir alguno
                foreach (Usuarios el in listUsuarios)
                {
                    impresionUsuarioPantalla(el);
                }
            }
            Console.WriteLine("\n");
        }
        //metodo para imprimir captar los datos e imprimirlos por pantalla
        public void impresionUsuarioPantalla(Usuarios ele)
        {

            Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
            Console.WriteLine("\n");
        }
            //metodo para eliminar el usuario
        public void Eliminar()
        {
            //con la variable buscar accedemos al nombre del usuario que deseamos eliminar
            string buscar;
            if (validarLista() )
            {
                Console.WriteLine("No hay elementos en la lista para eliminar");
            }
            else
            {
                Console.WriteLine("Ingrese el usuario que desea eliminar");
                buscar = Console.ReadLine();
                //Recorremos la lista de usuarios ya creados para eliminarlos
                foreach (var ele in listUsuarios)
                {
                    if (buscar == ele.Nombre)
                    {
                        Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
                        listUsuarios.Remove(ele);
                        Console.WriteLine("\n");
                        Console.WriteLine("Usuario eliminado");
                        Console.WriteLine("\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se encuentra el usuario");
                    }
                }

            }

        }
        //Metodo para modificar los usuarios
        public void modificar()
        {
            string buscar;
            if (validarLista() == true)
            {
                Console.WriteLine("No hay elementos en la lista para Modificar");
                Console.WriteLine("\n");
            }
            else if (validarLista() == false)
            {
                
                Console.WriteLine("Ingrese el usuario que desea Modificar: ");
                buscar = Console.ReadLine();
                foreach (Usuarios ele in listUsuarios)
                {
                Usuarios usuario = new Usuarios();
                    if (buscar == ele.Nombre)
                    {
                        //aqui le damos el formato que deseamos para mostrar los usuarios
                        Console.Write("ID: {0} | Nombre: {1} | Telefono: {2} | Email: {3} | Direccion: {4} ", ele.ID, ele.Nombre, ele.Telefono, ele.Email, ele.direccion);
                        Console.WriteLine("\n");
                        Console.WriteLine("------------------------------------------------");
                            
                        Console.Write("Ingrese el nombre que desea modificar: ");
                        usuario.Nombre = Console.ReadLine();
                        string usu = usuario.Nombre;
                        //nueva mente validamos si es solo letras
                        while (!Regex.IsMatch(usu, @"^[a-zA-Z-\s*]+$"))
                        {

                            Console.WriteLine("El nombre solo debe contener letras");
                            usu= Console.ReadLine();

                        }

                        ele.Nombre = usu;





                        
                        Console.Write("Ingrese el numero telefonico que desea modificar: ");
                        long tel;
                        long.TryParse(Console.ReadLine(), out tel);
                        usuario.Telefono = tel;
                        while(usuario.Telefono <= 0)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Digite un numero de telefono valido");
                            long.TryParse(Console.ReadLine(), out tel);
                            usuario.Telefono = tel;

                        }
                        ele.Telefono = usuario.Telefono;
                        Console.Write("Ingrese el Email que desea modificar: ");
                        usuario.Email = Console.ReadLine();
                        ele.Email = usuario.Email;
                        Console.Write("Ingrese la direccion que desea modificar: ");
                        usuario.direccion = Console.ReadLine();
                        ele.direccion = usuario.direccion;
                        Console.WriteLine("\n");
                        Console.WriteLine("Los datos han sido modificados");

                    }
                    else 
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Usuario no encontrado");
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
                        Console.WriteLine("\n");
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
