    namespace Ejercicios_ERIC
    {
        using System;

        class Program
        {
            static void Main()
            {
                Ejercicios ejercicios = new Ejercicios();

                // Ejercicio 1
                int[] arreglo1 = { 1, 2, 3, 4, 5 };
                ejercicios.MostrarArreglo(arreglo1);

                // Ejercicio 2
                int[] arreglo2 = ejercicios.LeerArreglo();
                ejercicios.MostrarArreglo(arreglo2);

                // Ejercicio 3
                int[] arreglo3 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
                double media = ejercicios.CalcularMedia(arreglo3);
                Console.WriteLine("La media de los valores del arreglo es: " + media);

                // Ejercicio 4
                int tamaño = ejercicios.LeerTamaño();
                int numero = ejercicios.LeerNumero();
                int[] arreglo4 = ejercicios.CrearArregloMultiplos(tamaño, numero);
                ejercicios.MostrarArreglo(arreglo4);

                // Ejercicio 5
                string[] nombres = ejercicios.LeerNombres(tamaño);
                int[] longitudes = ejercicios.CalcularLongitudes(nombres);
                ejercicios.MostrarNombresYLongitudes(nombres, longitudes);
            }
        }

   
    }