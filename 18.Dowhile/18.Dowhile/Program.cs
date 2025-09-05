namespace _18.Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int acomulador = 0;
            int saldo = 0;
            string nombre = " ";
            int numcuenta = 0;
            string respuesta = " ";
            do { 
                Console.WriteLine("ingrese nombre\nnumero de cuenta\nsaldo\n");
            nombre = Console.ReadLine();
            numcuenta = int.Parse(Console.ReadLine());
            saldo = int.Parse(Console.ReadLine());


            if (saldo > 3000000)
            {
                Console.WriteLine("es apto pra el credito");
            }
            else if (saldo < 3000000)
            {
                Console.WriteLine("no es apto para el credito");
            }
            Console.WriteLine("quiere ingresar otro usuario: s:si n:no");
            respuesta = Console.ReadLine().ToLower();


        }while (respuesta == "s") ;













        }
    }
}
