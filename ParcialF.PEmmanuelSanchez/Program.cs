namespace ParcialF.PEmmanuelSanchez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipoPizza, opcion1, opcion2, opcion3;
            string ingrediente1 = "", ingrediente2 = "", ingrediente3 = "";
            string tipoSeleccionado = "";
            int precioBase = 0;
            double iva = 0, valorIva = 0, precioFinal = 0;

            
            Console.WriteLine("Seleccione el tipo de pizza:");
            Console.WriteLine("1. vegetariana");
            Console.WriteLine("2. no vegetariana");
            tipoPizza = int.Parse(Console.ReadLine());

            if (tipoPizza == 1)
            {
                tipoSeleccionado = "vegetariana";
                Console.WriteLine("\ningredientes disponibles (elige 3):");
                Console.WriteLine("1. pimiento");
                Console.WriteLine("2. tofu");
                Console.WriteLine("3. champiñones");
                Console.WriteLine("4. tomate");
                Console.WriteLine("5. lechuga");

                Console.Write("selecciona el ingrediente 1: ");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Write("selecciona el ingrediente 2: ");
                opcion2 = int.Parse(Console.ReadLine());
                Console.Write("selecciona el ingrediente 3: ");
                opcion3 = int.Parse(Console.ReadLine());

                
                ingrediente1 = ObtenerIngredienteVegetariano(opcion1);
                ingrediente2 = ObtenerIngredienteVegetariano(opcion2);
                ingrediente3 = ObtenerIngredienteVegetariano(opcion3);

                
                if (ingrediente1 == "pimiento" && ingrediente2 == "champiñones" && ingrediente3 == "lechuga" ||
                    ingrediente1 == "champiñones" && ingrediente2 == "lechuga" && ingrediente3 == "pimiento" ||
                    ingrediente1 == "lechuga" && ingrediente2 == "champiñones" && ingrediente3 == "pimiento")
                {
                    precioBase = 20000;
                    iva = 0.19;
                }
                else if ((ingrediente1 == "tofu" && ingrediente2 == "champiñones" && ingrediente3 == "lechuga") ||
                         (ingrediente1 == "champiñones" && ingrediente2 == "tofu" && ingrediente3 == "lechuga"))
                {
                    precioBase = 30000;
                    iva = 0.15;
                }
                else
                {
                    precioBase = 25000;
                    iva = 0.10;
                }
            }
            else
            {
                tipoSeleccionado = "no Vegetariana";
                Console.WriteLine("\ningredientes disponibles (elige 2):");
                Console.WriteLine("1. res");
                Console.WriteLine("2. chorizo");
                Console.WriteLine("3. pollo");
                Console.WriteLine("4. tocineta");
                Console.WriteLine("5. ceerdo");

                Console.Write("selecciona el ingrediente 1: ");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Write("selecciona el ingrediente 2: ");
                opcion2 = int.Parse(Console.ReadLine());

             
                ingrediente1 = ObtenerIngredienteNoVegetariano(opcion1);
                ingrediente2 = ObtenerIngredienteNoVegetariano(opcion2);

               
                if ((ingrediente1 == "res" && ingrediente2 == "pollo") || (ingrediente1 == "pollo" && ingrediente2 == "res"))
                {
                    precioBase = 10000;
                    iva = 0.19;
                }
                else if ((ingrediente1 == "res" && ingrediente2 == "tocineta") || (ingrediente1 == "tocineta" && ingrediente2 == "res"))
                {
                    precioBase = 15000;
                    iva = 0.17;
                }
                else if ((ingrediente1 == "chorizo" && ingrediente2 == "tocineta") || (ingrediente1 == "tocineta" && ingrediente2 == "chorizo"))
                {
                    precioBase = 25000;
                    iva = 0.09;
                }
                else
                {
                    precioBase = 22000;
                    iva = 0.10;
                }
            }

            valorIva = precioBase * iva;
            precioFinal = precioBase + valorIva;

            
            Console.WriteLine("\nfactura de la pizza");
            Console.WriteLine($"tipo de pizza: {tipoSeleccionado}");
            Console.WriteLine($"ingredientes: {ingrediente1}, {ingrediente2}" + (tipoPizza == 1 ? $", {ingrediente3}" : ""));
            Console.WriteLine($"Precio base: ${precioBase}");
            Console.WriteLine($"IVA aplicado: {iva * 100}% = ${valorIva}");
            Console.WriteLine($"precio final: ${precioFinal}");
        }

        
        static string ObtenerIngredienteVegetariano(int opcion)
        {
            if (opcion == 1) return "pimiento";
            if (opcion == 2) return "tofu";
            if (opcion == 3) return "champiñones";
            if (opcion == 4) return "tomate";
            if (opcion == 5) return "lechuga";
            return "";
        }

        static string ObtenerIngredienteNoVegetariano(int opcion)
        {
            if (opcion == 1) return "res";
            if (opcion == 2) return "chorizo";
            if (opcion == 3) return "pollo";
            if (opcion == 4) return "tocineta";
            if (opcion == 5) return "cerdo";
            return "";
        }
    }














}
    

