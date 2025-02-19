using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace R17E01_JesusCG
{
    /// <summary>
    /// Herramientas que permitiranla interaccion con el usuario 
    /// </summary>
    public static class Interfazusuario
    {
        #region METODOS ASOCIADOS A LA ENTRADA DE DATOS 
        public static Examen LeerDatos()
        {
            //RECURSOS 
            Examen control = null;
            string asignatura = "";
            float nota = 0;
            bool datosValidos = true;

            do
            {
                //Inicializacion del Estado y la Interfaz
                datosValidos = true;
                Console.Clear();    
            //1.-Solicitar Asignatura 
            Console.Write("Introduzca la asignatura a evaluar");
            asignatura = Console.ReadLine();
            //2.-Solicitar Nota 
            Console.WriteLine("Introduzca la nota: ");
            try
            {
                nota = Convert.ToSingle(Console.ReadLine());
                //3.-Construir el objeto examen 
                control = new Examen(asignatura, nota);
            }
            catch (Exception error)
            {
                    datosValidos = false;
                Console.WriteLine(error.Message);
                Console.WriteLine("Pulse enter para continuar...");
                Console.ReadLine();
            }
        } while (!datosValidos);
            //SALIDA-Metodo
            return control; 
        }
        #endregion
        #region METODOS ASOCIADOS A LA SALIDA DE DATOS 
        public  static void MostrarDatos(Examen actividadEvaluacion)
        {
            //TODO: Implementar la comprobacion de la entrada del metodo 

            //1.- Mostrar las asignaturas 
            Console.WriteLine($"Asignatura:  {actividadEvaluacion.Asignatura}");
            //2.- Mostrar la nota cuantitativa 
            Console.WriteLine($"Nota: {actividadEvaluacion.Nota}");

            //3.-Mostrar la nota cualitativa 
            Console.WriteLine($"Calificacion: {actividadEvaluacion.Calificacion}");

        }
        #endregion
    }
}
