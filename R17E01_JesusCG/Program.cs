namespace R17E01_JesusCG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RECURSOS - VARIABLES
            Examen prueba;
            Examen ControlMatematicas;
            // INICIALIZACIÓN
            prueba = new Examen();
            ControlMatematicas = new Examen("Matematicas");
            ControlMatematicas = new Examen("Matematicas", 5.5f);
            

            // PRUEBA 1 - Capturar errores
            try
            {
                prueba.Asignatura = "";

                Console.WriteLine(prueba.Asignatura);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            // PRUEBA 2 - Asignatura es válida
            try
            {
                prueba.Asignatura = "Programación";

                Console.WriteLine(prueba.Asignatura);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
