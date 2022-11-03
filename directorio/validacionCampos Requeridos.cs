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
       public void validarTel(long ele)
        {
            Usuarios usuario = new Usuarios();
            while(ele == 0 || ele == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Digite el numero correctamente");
                long.TryParse(Console.ReadLine(), out ele);
            }
            
        }
        
    }
}
