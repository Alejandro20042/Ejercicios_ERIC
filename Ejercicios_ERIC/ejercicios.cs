using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Ejercicios_ERIC
    {
    
            class Ejercicios
            {
                public void MostrarArreglo(int[] arreglo)
                {
                    Console.WriteLine("Elementos del arreglo:");
                    foreach (int num in arreglo)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }

                public int[] LeerArreglo()
                {
                    int[] arreglo = new int[5];
                    Console.WriteLine("Introduce 5 valores para el arreglo:");
                    for (int i = 0; i < 5; i++)
                    {
                        arreglo[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    return arreglo;
                }

                public double CalcularMedia(int[] arreglo)
                {
                    int suma = 0;
                    foreach (int num in arreglo)
                    {
                        suma += num;
                    }
                    return (double)suma / arreglo.Length;
                }

                public int LeerTamaño()
                {
                    Console.WriteLine("Introduce el tamaño del arreglo:");
                    return Convert.ToInt32(Console.ReadLine());
                }

                public int LeerNumero()
                {
                    Console.WriteLine("Introduce el número para calcular los múltiplos:");
                    return Convert.ToInt32(Console.ReadLine());
                }

                public int[] CrearArregloMultiplos(int tamaño, int numero)
                {
                    int[] arreglo = new int[tamaño];
                    for (int i = 0; i < tamaño; i++)
                    {
                        arreglo[i] = (i + 1) * numero;
                    }
                    return arreglo;
                }

                public string[] LeerNombres(int tamaño)
                {
                    string[] nombres = new string[tamaño];
                    Console.WriteLine("Introduce los nombres:");
                    for (int i = 0; i < tamaño; i++)
                    {
                        nombres[i] = Console.ReadLine();
                    }
                    return nombres;
                }

                public int[] CalcularLongitudes(string[] nombres)
                {
                    int[] longitudes = new int[nombres.Length];
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        longitudes[i] = nombres[i].Length;
                    }
                    return longitudes;
                }

                public void MostrarNombresYLongitudes(string[] nombres, int[] longitudes)
                {
                    Console.WriteLine("Nombres y sus longitudes:");
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        Console.WriteLine(nombres[i] + ": " + longitudes[i]);
                    }
                }
            }
    
    }
