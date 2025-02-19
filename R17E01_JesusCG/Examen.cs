using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17E01_JesusCG
{
    public class Examen
    {
        // MIEMBROS / CAMPOS
        // V1: Los datos carecen de seguridad y protección
        //public string Asignatura;
        //public float Nota;
        //public string Calificacion;

        // V2: Se modifica el acceso a los miembros de la clase
        private string _asignatura; // Oculta el miembro fuera de la clase (Protección)
        private float _nota;
        private string _calificacion;
        #region CONSTRUCTORES DE LA CLASE 
        /// <summary>
        /// Constructor por Defecto - Sobreescribe el constructor implicito de la clase 
        /// </summary>
        public Examen()
        {
            _asignatura = "DESCONOCIDA";
            _nota = -1; // Indica que la nota no se ha establecido 
            _calificacion = "DESCONOCIDA";
        }
        /// <summary>
        /// Constructor del objeto Examen introduciendo la asignatura a evaluar
        /// </summary>
        /// <param name="materia"> Asignatura a evaluar</param>
        public Examen(string materia )
        {
            //_asignatura = materia; Accion no segura para establecer el valor del miembro 
            Asignatura = materia; //Desencadena el set de la Propiedad y por tanto el mecanismo 
                                  //de Control de Errores 
            _nota = -1;
            _calificacion = "DESCONOCIDA";
        }
        public Examen(string materia , float puntuacion )º
        {
            Asignatura=materia;
            Nota = puntuacion;
           // _calificacion = "DESCONOCIDA";
        }
        #endregion  

        #region PROPIEDADES
        // Proporcionar Seguridad a los miembros de la clase

        /// <summary>
        /// Nombre de la Asignatura que se va a evaluar
        /// </summary>
        public string Asignatura
        {
            // Descriptor de Acceso get: Permite devolver datos contenidos en la clase
            get {
                return _asignatura;
            }
            // Descriptor de Acceso set: Permite establecer datos dentro de la clase
            set
            {
                // Validación de la Entrada
                ValidarAsignatura(value);

                // Salida - Establecimiento de la cadena al miembro / campo privado
                _asignatura = value;
            }
        }

      

        /// <summary>
        /// Nota numérica obtenida en la prueba de evaluación
        /// </summary>
        public float Nota
        {
            get 
            { 
                return _nota;
            }

            set
            {
                // Validación de la Entrada (value)
                // 1.- Si el valor es inferior al límite
                ValidarNota(value);
                //Actualizamos Calificacion
                ActualizarCalificacion(value);
                _nota = value;
                
            }
        }

    



        /// <summary>
        /// Nota cualitativa del examen
        /// </summary>
        public string Calificacion
        {
            get { return _calificacion; }
            set
            {
                // Validación del dato a establecer
                ValidadrCalificacion(value);

                // Establecimiento del dato
                _calificacion = value;
            }
        }

      
        #endregion

        #region METODOS PRIVADOS - INTERNOS DE LA CLASE 
        private static void ValidarAsignatura(string cadena)
        {
            if (String.IsNullOrEmpty(cadena))
            {
                //Console.WriteLine("ERROR: La asignatura no puede estar nula o vacía");
                throw new Exception("ERROR: La asignatura no puede estar nula o vacía");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="puntuacion"></param>
        /// <exception cref="Exception"></exception>
        private static void ValidarNota(float puntuacion)
        {
            if (puntuacion < 0)
            {
                throw new Exception("ERROR: La nota es inferior a 0");
            }

            // 2.- Si el valor es superior al límite
            if (puntuacion > 10)
            {
                throw new Exception("ERROR: La nota es superior a 10");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <exception cref="Exception"></exception>
        private static void ValidadrCalificacion(string cadena)
        {
            if (String.IsNullOrEmpty(cadena))
                throw new Exception("ERROR: Calificación no establecida");
            if (cadena.Length > 20)
                throw new Exception("ERROR: La cadena no puede ser superior a 20 caracteres");
        }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="nota"></param>
        private  void ActualizarCalificacion(float nota)
        {
            //VARIABLES / RECUROS 
            string NotaCualitativa = " ";
            int notaEntera =(int)Math.Truncate(nota);

            //PROCESO
            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                    NotaCualitativa = "Muy Deficiente ";
                    break;
                case 3:
                case 4:
                    NotaCualitativa = "Insuficiente";
                    break;
                case 5:
                    NotaCualitativa = "Suficiente";
                    break;
                case 6:
                    NotaCualitativa = "Bien";
                    break;
                case 7:
                    if(nota < 7.5)
                        NotaCualitativa = "Bien";
                    
                    else
                        NotaCualitativa = "Notable";
                    
                    break;
                case 8:
                    NotaCualitativa = " Notable ";
                    break;
                case 9:
                    NotaCualitativa = " Sobresaliente ";
                    break;
                case 10:
                    NotaCualitativa = " Matricula de Honor";
                    break;

            }


            // SALIDA - Metodo 
            _calificacion = NotaCualitativa;
        }
        private void ActualizarCalificacion()
        {
            //VARIABLES / RECUROS 
            string NotaCualitativa = " ";
            int notaEntera = (int)Math.Truncate(_nota);

            //PROCESO
            switch (notaEntera)
            {
                case 0:
                case 1:
                case 2:
                    NotaCualitativa = "Muy Deficiente ";
                    break;
                case 3:
                case 4:
                    NotaCualitativa = "Insuficiente";
                    break;
                case 5:
                    NotaCualitativa = "Suficiente";
                    break;
                case 6:
                    NotaCualitativa = "Bien";
                    break;
                case 7:
                    if (_nota < 7.5)
                        NotaCualitativa = "Bien";

                    else
                        NotaCualitativa = "Notable";

                    break;
                case 8:
                    NotaCualitativa = " Notable ";
                    break;
                case 9:
                    NotaCualitativa = " Sobresaliente ";
                    break;
                case 10:
                    NotaCualitativa = " Matricula de Honor";
                    break;

            }


            // SALIDA - Metodo 
            _calificacion = NotaCualitativa;
        }
        #endregion
    }
}
