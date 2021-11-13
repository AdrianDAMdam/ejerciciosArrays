using System;
using System.Text;

namespace ej9
{
    class Program
    {

        static char[] RecogeContraseña()
        {

            bool tecla = true;
            const int MAXIMOS_CARACTERES_CONTRASEÑA = 16;
            char[] contraseña = new char[MAXIMOS_CARACTERES_CONTRASEÑA];
            int i = 0;
            do
            {
                contraseña[i] = Console.ReadKey(true).KeyChar;
                if (contraseña[i] == (char)ConsoleKey.Enter || i == MAXIMOS_CARACTERES_CONTRASEÑA)
                    System.Console.Write("");

                else
                    System.Console.Write('*');
                if (contraseña[i] == (char)ConsoleKey.Enter)
                {
                    contraseña[i] = default;
                    tecla = false;
                }

                i++;

            } while (i < MAXIMOS_CARACTERES_CONTRASEÑA && tecla);

            return contraseña;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("1. Registrarse en el es sistema.\n2. Entrar al sistema.\n3. Salir del programa. ");

            int seleccion = int.Parse(Console.ReadLine());

            char[] contraseña;
            if (seleccion == 1)
            {
                System.Console.WriteLine("Registrate en el sistema:");
                System.Console.Write("    Contraseña: ");
                contraseña = RecogeContraseña();
                System.Console.Write("\n    Repita Contraseña:");
                char[] comporbacionContraseña = RecogeContraseña();
                bool sonIguales = true;
                for (int i = 0; i < contraseña.Length; i++)
                {
                    if (contraseña[i] != comporbacionContraseña[i])
                        sonIguales = false;

                }
                 System.Console.WriteLine("contraseña"+contraseña);
                if (sonIguales)
                {
                    char[] contaseñaComprobada = contraseña;
                }
               Console.Clear();
               System.Console.WriteLine("contraseña"+contraseña.ToString());
               System.Console.WriteLine("1. Registrarse en el es sistema.\n2. Entrar al sistema.\n3. Salir del programa. ");
               seleccion=int.Parse(Console.ReadLine());
                switch (seleccion)
                {
                    case 2:
                        System.Console.Write("Salida.\nIntroduce contraseña:");
                        StringBuilder contraseñaSalida = new StringBuilder(contraseña.Length);
                       
                        for (int i = 0; i < contraseña.Length; i++)
                        {
                            contraseñaSalida[i] = Console.ReadKey(true).KeyChar;
                            System.Console.Write("*");
                            if(contraseñaSalida[i]!=contraseña[i])
                            sonIguales=false;
                            
                        }
                        if (sonIguales==true)
                        System.Console.WriteLine("La contraseña es correcta.");
                        else
                        System.Console.WriteLine("La contraseña es incorrecta.");

                        break;
                    default:
                        break;
                }

            }

           



        }
    }
}
