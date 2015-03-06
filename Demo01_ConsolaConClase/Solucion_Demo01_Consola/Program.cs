using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Solucion_Demo01_Consola
{
    class Program
    {

        public enum ModoEntrada
        { 
            Guardar=1 ,
            Cancelar=2
        }
        static void Main(string[] args)
        {

            string strMensaje = "Software de Prueba";
            Console.WriteLine(strMensaje);
            string strPrefijo = new string('-', strMensaje.Length);
            Console.WriteLine(strPrefijo);
            Console.WriteLine();
            Console.Write("Nombre:");
            string strNombre = Console.ReadLine();
            Console.Write("Correo:");
            string strCorreo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Opciones Grabar[1] Cancelar[2] ");
            int opcion =  int.Parse(Console.ReadLine());
            ModoEntrada me = (ModoEntrada)opcion;
            switch(me)
            {
                case ModoEntrada.Guardar:
                     Empleado emp = new Empleado(strNombre, strCorreo,5000);
                    emp.Guardar();
                    Console.WriteLine(emp.obtenerMensaje());
                       break;
                case ModoEntrada.Cancelar:
                        break; 
                default:
                        break;
            }


            Console.ReadKey();
        }


    }
}

public class Cliente
{
    public string Nombre { get; set; }
    public string Correo { get; set; }

    public Cliente(string nombre, string correo)
    {
        Nombre = nombre;
        Correo = correo;
    }

    public void Guardar()
    { 
    FileStream fs = new FileStream("..\\Clientes.txt", FileMode.Append);
     StreamWriter sw = new StreamWriter(fs);
    sw.WriteLine(Nombre+"\t"+Correo);
    sw.Close();
    fs.Close();
    }

    public virtual string obtenerMensaje()
    { 
     return  string.Format("El cliente {0} con correo {1} fue registrado ok",Nombre,Correo);
    }

}

public class Empleado : Cliente
{
    public double Sueldo { get; set; }
    public Empleado(string nombre, string correo, double sueldo):base(nombre,correo) /*reutilizacion de codigo*/
    {
        Sueldo = sueldo;
    }

    public override string obtenerMensaje()
    {
        return string.Format("El Empleado {0} con correo {1} fue registrado ok", Nombre, Correo);
    }
}

