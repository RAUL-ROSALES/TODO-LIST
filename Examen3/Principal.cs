using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
   public class Principal
    {
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido");
            Menu();
        }
        public void Menu()
        {
            Console.ReadKey();
            Console.Clear();
            Metodos m = new Metodos();
            m.Menu2();

        }
    }
}
