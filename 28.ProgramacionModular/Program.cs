namespace _28.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensaje("soy Emmanuel");
            MostrarMensaje("tengo 17 años");
            MostrarMensaje($"tengo {calcularEdad()} años");
            MostrarMensaje($"tengo {calcularEdad(2025, 2008)} años");
        }

        //modulo 1 - procedimiento sin parametros 
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la programacion modular");
        }

        //modulo 2 - procedimiento con parametros
        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //modulo 3 - funcion sin parametros

        static int calcularEdad()
        {
            int edad = 2025 - 2008;
            return edad;

        }

        //modulo 4 - funcion con parametros

        static int calcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
            



    }
}
