using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace directorio
{
    public class validacionCampos_Requeridos
    {
        public void ValidarNombre(string ele)
        {

            Console.WriteLine("\n");
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            while (!Val.IsMatch(ele))
            {
                Console.WriteLine("Error! intentelo nuevamente");
                ele = Console.ReadLine();
                ValidarNombre(ele);

            }

        }
        public void CambiarNombre(string name)
        {

            Console.WriteLine("Error! digite el nombre nuevamente");
            name.Trim();
            name = Console.ReadLine();
            ValidarNombre(name);
            
            
        }
       public void ChangeValidation(bool val)
        {
            if(val == true)
            {
                val = false;
            }
        }
    }
}
