using System;

namespace Logica
{
    public class CalculadoraLogica
    {
        public static int Sumar(int numeros)
        {
            int suma = 0;
            suma += numeros;
            return suma;
        }
        public static int Restar(int num1, int num2)
        {
            int resta = 0;
            resta = num1 - num2;
            return resta;
        }
        public static int Multiplicar(int num1, int num2)
        {
            int mul = 0;
            mul = num1 * num2;
            return mul;
        }

        public static int Dividir(int num1, int num2)
        {
            int div = 0;
            div = num1 / num2;
            return div;
        }
        public static int Potenciar(int num1, int num2)
        {
            int pot = num1;
            for (int i = 0; i < num2; i++)
            {
                pot *= num1;
            }
            return pot;
        }
    }
}
