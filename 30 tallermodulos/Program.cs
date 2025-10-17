namespace _30_tallermodulos
{
    using System;

    class Programa
    {
        static List<string> tareas = new List<string>();
        static void Main()

        {

            /* Console.Write("Ingrese una palabra: ");
             string palabra = Console.ReadLine();


             char[] caracteres = palabra.ToCharArray();


             int vocales = 0;
             int consonantes = 0;

             foreach (char c in caracteres)
             {
                 if (char.IsLetter(c))
                 {
                     char letra = char.ToLower(c);
                     if ("aeiou".Contains(letra))
                         vocales++;
                     else
                         consonantes++;
                 }
             }


             Console.WriteLine($"Vocales: {vocales}");
             Console.WriteLine($"Consonantes: {consonantes}");*/








            int opcion;
            do
            {
                Console.WriteLine("\n1. Agregar tarea\n2. Eliminar tarea\n3. Mostrar tareas\n0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarTarea(); break;
                    case 2: EliminarTarea(); break;
                    case 3: MostrarTareas(); break;
                }

            } while (opcion != 0);
        }

        static void AgregarTarea()
        {
            Console.Write("Escribe la tarea: ");
            string tarea = Console.ReadLine();
            tareas.Add(tarea);
            Console.WriteLine("Tarea agregada.");
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            Console.Write("Número de la tarea a eliminar: ");
            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= tareas.Count)
            {
                tareas.RemoveAt(index - 1);
                Console.WriteLine("Tarea eliminada.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }
        }

        static void MostrarTareas()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas.");
                return;
            }

            Console.WriteLine("\nLista de tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }




    }
}






