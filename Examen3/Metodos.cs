using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
   public class Metodos
    {
        List<Tareas> l;
        Tareas t;
        Principal pr = new Principal();
        /*instacion la clae tareas y creo una 
         lista de tareas en metodos*/
        public Metodos()
        {
            l = new List<Tareas>();
            t = new Tareas();
        }
        public List<Tareas> Crear(List<Tareas> lis)
        {
            Console.WriteLine("Ingrese El Nombre De La Persona Que Asignara");
            t.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese La Actividad A Realizar");
            t.Tarea = Console.ReadLine();
            Console.WriteLine("Ingrese La Fecha usando el formato 00/00/00");
            t.Fecha = Console.ReadLine();
            Console.WriteLine("Ingrese La Hora");
            t.Hora = Console.ReadLine();
            Console.WriteLine("Ingrese El Estatus");
            t.Estatus = Console.ReadLine();
            l.Add(t);
            return lis;
        }
        public List<Tareas> MostrarTareas(List<Tareas> lis)
        {
            foreach (var tarea in lis)
            {
                Console.WriteLine(tarea.Tarea);
            }
            return lis;
        }
        public void Detalles(List<Tareas> list)
        {
            Console.Clear();
            Console.WriteLine("Ingrese Nombre De La Actividad");
            string opc = Console.ReadLine();
            Console.WriteLine("Detalles de La Actividad");
            foreach (var q in list)
            {
                if (q.Tarea == opc)
                {
                    Console.WriteLine(q.Tarea+"\n"+ q.Nombre+ "\n"+q.Fecha+"\n"+q.Hora+"\n"+q.Estatus);
                }
            }
        }
        public void MostrarEstatus(List<Tareas> list)
        {
            foreach (var q in list)
            {
                Console.WriteLine("El Estatus De La Actividad {0} Es {1}",q.Tarea,q.Estatus);
            }
        }
        public void CambiarEstatus(List<Tareas>list)
        {
            Console.WriteLine("INGRESE EL NOMBRE DE LA TAREA");
            string x = Console.ReadLine();
            Console.WriteLine("INGRESE EL NUEVO ESTATUS");
            foreach (var z in list)
            {
                if (z.Estatus == x)
                {
                    z.Estatus = Console.ReadLine();
                }
            }

        }
        public void Menu2()
        {
            Console.WriteLine("1-CREAR UNA NUEVA TAREA");
            Console.WriteLine("2-MOSTRAR TAREAS");
            Console.WriteLine("3-DETALLES");
            Console.WriteLine("4-MOSTRAR ESTATUS");
            Console.WriteLine("5-CAMBIAR ESTATUS");
            Console.WriteLine("ELIGA UNA OPCION");
            switch (Console.ReadLine())
            {
                case "1":
                    Crear(l);
                    Menu2();
                    break;
                case "2":
                    MostrarTareas(l);
                    Menu2();
                    break;
                case "3":
                    Detalles(l);
                    Menu2();
                    break;
                case "4":
                    MostrarEstatus(l);
                    Menu2();
                    break;
                case "5":
                    CambiarEstatus(l);
                    Menu2();
                    break;
                default:
                    Console.WriteLine("OPCION NO VALIDAD");
                    Menu2();
                    break;
            }
        }
    }
}
