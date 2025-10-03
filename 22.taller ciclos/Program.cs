namespace _22.taller_ciclos
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Promedio de calificaciones");
                Console.WriteLine("2. Divisores de un número");
                Console.WriteLine("3. Potenciación");
                Console.WriteLine("4. Prueba de 5km");
                Console.WriteLine("5. Encuesta servicio militar");
                Console.WriteLine("6. Clasificación de 40 números");
                Console.WriteLine("7. Clasificación por edades");
                Console.WriteLine("8. Calcomanía por placa");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        double suma = 0;
                        int contador = 0;
                        string entrada;

                        do
                        {
                            Console.Write("Ingrese una nota (n para salir): ");
                            entrada = Console.ReadLine();
                            if (entrada != "n")
                            {
                                double nota = double.Parse(entrada);
                                suma += nota;
                                contador++;
                            }
                        } while (entrada != "n");

                        if (contador > 0)
                            Console.WriteLine("Promedio: " + (suma / contador));
                        else
                            Console.WriteLine("No se ingresaron notas.");
                        break;

                    case 2:
                        Console.Write("Ingrese un número: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Divisores:");
                        for (int i = 1; i <= num; i++)
                            if (num % i == 0)
                                Console.WriteLine(i);
                        break;

                    case 3:
                        string salir = "";
                        while (salir != "n")
                        {
                            Console.Write("Base: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("Exponente: ");
                            int e = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + Math.Pow(b, e));
                            Console.Write("¿Desea continuar? (n para salir): ");
                            salir = Console.ReadLine();
                        }
                        break;

                    case 4:
                        double[] tiempos = new double[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Tiempo #" + (i + 1) + ": ");
                            tiempos[i] = double.Parse(Console.ReadLine());
                        }
                        bool menor20 = true;
                        bool unoMenor15 = false;
                        double prom = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            if (tiempos[i] > 20)
                                menor20 = false;
                            if (tiempos[i] < 15)
                                unoMenor15 = true;
                            prom += tiempos[i];
                        }
                        prom = prom / 3;
                        if (menor20 && unoMenor15 && prom < 18)
                            Console.WriteLine("Apto");
                        else
                            Console.WriteLine("No apto");
                        break;

                    case 5:
                        int aFavor = 0, enContra = 0, noResponde = 0;
                        Console.Write("¿Cuántos encuestados?: ");
                        int total = int.Parse(Console.ReadLine());

                        for (int i = 0; i < total; i++)
                        {
                            Console.Write("Respuesta #" + (i + 1) + " (a favor / en contra / no responde): ");
                            string resp = Console.ReadLine().ToLower();

                            if (resp == "a favor")
                                aFavor++;
                            else if (resp == "en contra")
                                enContra++;
                            else if (resp == "no responde")
                                noResponde++;
                            else
                            {
                                Console.WriteLine("Respuesta no válida.");
                                i--;
                            }
                        }

                        Console.WriteLine("A favor: " + ((aFavor * 100.0) / total) + "%");
                        Console.WriteLine("En contra: " + ((enContra * 100.0) / total) + "%");
                        Console.WriteLine("No responde: " + ((noResponde * 100.0) / total) + "%");
                        break;

                    case 6:
                        int pos = 0, neg = 0, neutros = 0, sumaPos = 0, sumaNeg = 0;
                        for (int i = 0; i < 40; i++)
                        {
                            Console.Write("Número #" + (i + 1) + ": ");
                            int n = int.Parse(Console.ReadLine());
                            if (n > 0)
                            {
                                pos++;
                                sumaPos += n;
                            }
                            else if (n < 0)
                            {
                                neg++;
                                sumaNeg += n;
                            }
                            else
                                neutros++;
                        }

                        Console.WriteLine("Positivos: " + pos);
                        Console.WriteLine("Negativos: " + neg);
                        Console.WriteLine("Neutros: " + neutros);
                        Console.WriteLine("Suma positivos: " + sumaPos);
                        Console.WriteLine("Suma negativos: " + sumaNeg);
                        break;

                    case 7:
                        int ninos = 0, jovenes = 0, adultos = 0, viejos = 0;
                        for (int i = 0; i < 70; i++)
                        {
                            Console.Write("Edad #" + (i + 1) + ": ");
                            int edad = int.Parse(Console.ReadLine());

                            if (edad >= 0 && edad <= 13)
                                ninos++;
                            else if (edad <= 30)
                                jovenes++;
                            else if (edad <= 60)
                                adultos++;
                            else
                                viejos++;
                        }

                        Console.WriteLine("Niños: " + ninos);
                        Console.WriteLine("Jóvenes: " + jovenes);
                        Console.WriteLine("Adultos: " + adultos);
                        Console.WriteLine("Viejos: " + viejos);
                        break;

                    case 8:
                        int amarilla = 0, rosa = 0, roja = 0, verde = 0, azul = 0;
                        Console.Write("Cantidad de autos: ");
                        int cant = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cant; i++)
                        {
                            Console.Write("Último dígito del auto #" + (i + 1) + ": ");
                            int d = int.Parse(Console.ReadLine());

                            if (d == 1 || d == 2) amarilla++;
                            else if (d == 3 || d == 4) rosa++;
                            else if (d == 5 || d == 6) roja++;
                            else if (d == 7 || d == 8) verde++;
                            else if (d == 9 || d == 0) azul++;
                            else Console.WriteLine("Dígito inválido.");
                        }

                        Console.WriteLine("Amarilla: " + amarilla);
                        Console.WriteLine("Rosa: " + rosa);
                        Console.WriteLine("Roja: " + roja);
                        Console.WriteLine("Verde: " + verde);
                        Console.WriteLine("Azul: " + azul);
                        break;

                    case 0:
                        Console.WriteLine("Adiós.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}
