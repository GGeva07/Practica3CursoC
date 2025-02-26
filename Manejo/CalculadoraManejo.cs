using Logica;

namespace Manejo
{
    public class CalculadoraManejo
    {
        public static void Sumar()
        {
            int numeros, suma = 0;
            Console.WriteLine("Ingrese los numeros que va a sumar e ingrese 0 para parar la suma");
            do
            {
                numeros = Convert.ToInt32(Console.ReadLine());
                suma += CalculadoraLogica.Sumar(numeros);

            } while (numeros != 0);
            Console.WriteLine($"La suma es {suma}");
            Console.ReadKey();
        }

        public static void Restar()
        {
            Console.WriteLine("Ingrese 2 numeros para restarlos");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resta = 0;
            resta = CalculadoraLogica.Restar(num1, num2);
            Console.WriteLine($"La resta es {resta}");
            Console.ReadKey();
        }

        public static void Multiplicar()
        {
            Console.WriteLine("Ingrese 2 numeros para restarlos");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int mul = 0;
            mul = CalculadoraLogica.Multiplicar(num1, num2);
            Console.WriteLine($"La multiplicacion es {mul}");
            Console.ReadKey();
        }

        public static void Dividir()
        {
            Console.WriteLine("Ingrese 2 numeros para restarlos");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int div;
            div = CalculadoraLogica.Dividir(num1, num2);
            Console.WriteLine($"La division es {div}");
            Console.ReadKey();
        }
        public static void Potenciar()
        {
            Console.WriteLine("Ingrese 2 numeros para la base y la potencia");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int pot = 0;
            pot = CalculadoraLogica.Potenciar(num1, num2);

            Console.WriteLine($"La base elevado a la potencia es: {pot}");
            Console.ReadKey();
        }
    }
}
