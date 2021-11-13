using System;

namespace ej8
{
//     //EJ8
//     Implementa un programa en C#, que dado un número entero sin signo introducido por
// teclado, me diga si es capicúa. Un ejemplo de ejecución sería...
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                 System.Console.Write("Introduce numero: ");
            bool esCapicua=true;
            char[] numero = Console.ReadLine().ToCharArray();
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] != numero[numero.Length-1 - i])
                    esCapicua = false;
                    
                else
                    esCapicua = true;
                    
            }
            string texto=(esCapicua?"Es capicua.":"No es capicua.");
            System.Console.WriteLine(texto);
            } while (true);
           
        }
    }
}
