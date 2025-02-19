using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17E01_JesusCG
{
    /// <summary>
    /// Herramientas para permitir la comunicacion entre el modelo y las vistas
    /// Secuencia las acciones a realizar 
    /// </summary>
    public static  class Controlador
    {
        /// <summary>
        /// Punto de arranque del componente 
        /// </summary>
        public static void IniciarApp()
        {
            Examen actividadEvaluacion = null; 
            //RECURSOS

            //INICIALIAZION 
            
            //ENTRADA - LLamadas a los metodos de la IU 
            //1.-Leer los datos 
            actividadEvaluacion =Interfazusuario.LeerDatos();
            //PROCESO

            //SALIDA - Llamadas a los metodos de la IU  
            //2.-Mostrar los datos 
            Interfazusuario.MostrarDatos(actividadEvaluacion) ;
        }
    }
}
