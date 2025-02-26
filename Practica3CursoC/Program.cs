using Manejo;

namespace Practica3CursoC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
        }

        public static string Calculadora()
        {
            bool parar = true;

            while (parar)
            {
                Console.Clear();
                Console.WriteLine("Calculadora menu: " +
                "\n1. Sumar" +
                "\n2. Restar" +
                "\n3. Multiplicar" +
                "\n4. Dividir" +
                "\n5. Potenciar" +
                "\n6. Salir");
                int? opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == null)
                {
                    return "Ingrese una opcion valida";
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            CalculadoraManejo.Sumar();
                            break;

                        case 2:
                            CalculadoraManejo.Restar();
                            break;

                        case 3:
                            CalculadoraManejo.Multiplicar();
                            break;

                        case 4:
                            CalculadoraManejo.Dividir();
                            break;

                        case 5:
                            CalculadoraManejo.Potenciar();
                            break;

                        case 6:
                            parar = false;
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida por favor");
                            Console.ReadKey();
                            break;
                    }
                }

            }
            return "Menu";
        }
    }
}

