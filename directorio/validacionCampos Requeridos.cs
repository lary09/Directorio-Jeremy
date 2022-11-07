using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directorio
{
    public class validacionCampos_Requeridos
    {
       public  void  validarNombre (string  ele)
        {
            

            
            

                Console.WriteLine("\n");

                foreach (var c in ele)
                {
                    while (!char.IsWhiteSpace(c) && !char.IsLetter(c))
                    {
                        cambiarNombre(ele);

                    }
                }

            
        }
        public void cambiarNombre(string name)
        {
            
            Console.WriteLine("Ingrese nombre nuevamente! ");
            name = Console.ReadLine();
            
            validarNombre(name);
        }
       public void changeValidation(bool val)
        {
            if(val == true)
            {
                val = false;
            }
        }
    }
}
