using System;

namespace Practica_Desarrollo
{
    class Program
    {
        static void Main(string[] args)
        {

            string linea;

            Console.WriteLine("Introduce el número de filas de la primera matriz");
            linea = Console.ReadLine();
            int fila1 = int.Parse(linea);
            Console.WriteLine("Introduce el número de columnas de la primera matriz");
            linea = Console.ReadLine();
            int columna1 = int.Parse(linea);


            //Array Matriz1
            int[,] matriz1 = new int[fila1, columna1];

            // Datos Matriz1
            for (int f=0; f<matriz1.GetLength(0); f++)
            {
                for(int c=0; c<matriz1.GetLength(1); c++)
                {

                    Console.WriteLine("Introduce los valores de la primera matriz");
                    linea = Console.ReadLine();
                    //leemos convertimos y asignamos
                    matriz1[f, c] = int.Parse(linea);

                }

            }

            //pedimos al usuario los datos de la segunda matriz
            Console.WriteLine("Introduce el número de filas de la segunda matriz");
            linea = Console.ReadLine();
            int fila2 = int.Parse(linea);
            Console.WriteLine("Introduce el número de columnas de la segunda matriz");
            linea = Console.ReadLine();
            int columna2 = int.Parse(linea);

            //Array segunda matriz
            int[,] matriz2 = new int[fila2, columna2];

            //Leer datos y guardarlos en la matriz2
            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for(int c=0; c<matriz2.GetLength(1); c++)
                {
                    Console.WriteLine("Introduce los valores de la segunda matriz");
                    linea = Console.ReadLine();

                    //Leemos, convertimos y asignamos
                    matriz2[f, c] = int.Parse(linea);
                }
            }

            //Imprimir en consola la Matriz1
            Console.WriteLine("La matriz 1 tiene los siguientes valores:");
            for(int f= 0; f<matriz1.GetLength(0); f++)
            {
                for(int c=0; c<matriz1.GetLength(1); c++)
                {
                    Console.Write(matriz1[f, c]);
                }
                Console.WriteLine();
            }
            //Imprimir en consola la Matriz2
            Console.WriteLine("La matriz 2 tiene los siguientes valores:");
            for(int f=0; f<matriz2.GetLength(0); f++)
            {
                for(int c=0; c<matriz2.GetLength(1); c++)
                {
                    Console.Write(matriz2[f, c]);
                }
                Console.WriteLine();
            }

            //Pasamos a comparar las dos matrices

            bool iguales = true;
            
            if (fila1 == fila2 && columna1 == columna2)
            {
                Console.WriteLine("Las matrices pueden ser comparadas");
                Console.WriteLine();
                for (int j = 0; j < fila1; j++)
                {
                    for (int i = 0; i<columna1; i++)
                    {
                        if (matriz1[j, i] != matriz2[j, i])
                        {
                    Console.WriteLine("La matriz 1 tiene en {0} {1}: {2} y la matriz 2 tiene en {0} {1}: {3}" , j, i,matriz1[j,i], matriz2[j,i]);
                            iguales = false;
                            break;
                        
                        }
                    }
                 }
                Console.WriteLine();
                if (iguales)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales");
                }
            
            }
            else Console.WriteLine("Las matrices no pueden ser comparadas");
        
        }
    }
}
