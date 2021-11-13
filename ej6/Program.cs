using System;

namespace ej6
{
    //     EJ6
    //     Crea un array de 10 elementos, visualiza el elemento mayor de la serie y la posición que
    // ocupa. Si hay varios iguales, sólo el primero.
    class Program
    {
        static void Main(string[] args)
        {
            int[] elemetnos={1,2,9,4,5,6,9,9,8};
            
            int valorMaximo=int.MinValue;
            int posicionArray=0;
            for (int i = 0; i < elemetnos.Length; i++)
            {
                if(elemetnos[i]>valorMaximo)
                {
                valorMaximo=elemetnos[i];
                posicionArray=i;
                }
                
            }
            System.Console.WriteLine($"El valor maximo de esta array es {valorMaximo} y esta en la posicion {posicionArray} de la array");
        }
    }
}
