using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Demo01_Aplicacion_de_consola
{
    class Program
    {
        public enum ModoEntrada
        {
            Guardar = 1,
            Cancelar = 2
        }


        static void Main(string[] args)
        {

            string strmensaje = "Ejercicio de consola";
            Console.WriteLine(strmensaje);
            string strprefijo = new string('-', strmensaje.Length);
            Console.WriteLine(strprefijo);
            Console.WriteLine();
            Console.Write("Nombre: ");
            string strNombre = Console.ReadLine();
            Console.Write("Email: ");
            string strEmail = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Opciones Grabar[1] Cancelar[2]");
            int opcion = int.Parse(Console.ReadLine());
            ModoEntrada me = (ModoEntrada)opcion;
            switch (me)
            {
                case ModoEntrada.Guardar:
                    //Cliente cl = new Cliente(strNombre, strEmail);
                    //cl.guardar();
                    //Console.WriteLine(cl.obtenerMensaje());
                    Empleado emp = new Empleado(strNombre, strEmail, 50000);
                    emp.guardar();
                    Console.WriteLine(emp.obtenerMensaje());
                    Console.ReadLine();
                    break;
                case ModoEntrada.Cancelar:
                    break;
                default:
                    break;
            }
        }


    }
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Cliente(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
        public void guardar()
        {
            FileStream fs = new FileStream("..\\Clientes.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Nombre + "\t" + Email);
            sw.Close();
            fs.Close();
        }
        public virtual string obtenerMensaje()
    { 
    
        return string.Format("El Cliente {0} con Email {1} se ha registrado correctamente",Nombre,Email);
    }
    }

    public class Empleado : Cliente
    {
        public double Sueldo { get; set; }
        public Empleado(string nombre, string email, double sueldo) : base(nombre, email)
        {
            Sueldo = sueldo;
        }

        public override string obtenerMensaje()
        {
            return string.Format("El Empleado {0} con Email {1} se ha registrado correctamente", Nombre, Email);
        }
    }
}

