using System;

namespace TPFinal_Lange
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP FINAL CURSO LOGICA PROGRAMACION CON C#

            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa
            // un cero. A partir de dichos datos informar:

            //     a. El mayor de los números pares.
            //     b. La cantidad de números impares.
            //     c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva
            // true o false según corresponda.

            int n, mayorPar = 0, contadorImpar = 0, menorPrimo = 0;

            Console.WriteLine("Ingrese un numero..");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                //Punto A
                if (par(n)){
                    if(n >= mayorPar){
                        mayorPar = n;
                    }
                }
                //Punto B
                if (!par(n)){
                    contadorImpar ++;
                }
                //Punto C
                if (primo(n)){
                    if (menorPrimo == 0){
                        menorPrimo = n;
                    }else if (n < menorPrimo){
                        menorPrimo = n;
                    }
                }

                Console.WriteLine("Ingrese un numero..");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El mayor de los numeros pares es: " + mayorPar);
            Console.WriteLine("La cantidad de numeros impares es: " + contadorImpar);
            Console.WriteLine("El menor de los numeros primos es: " + menorPrimo);
        }

        static bool par(int numero){
            if (numero % 2 == 0){
                return true;
            }else{
                return false;
            }
        }

        static bool primo(int numero){
            int contador = 0;
            for (int x = 1; x <= numero; x++)
            {
                if (numero % x == 0){
                    contador ++;
                }
            }
            if (contador == 2){
                return true;
            }else{
                return false;
            }
        }

    }
}
