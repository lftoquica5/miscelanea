using miscelanea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscenlanea
{
    class miscelanea
    {
        static void Main(string[] args)

        {
            while (true)

            {
                double numero1 = 0.0;
                double numero2 = 0.0;
                double numero3 = 0.0;
                double resultado = 0.0;

                Console.WriteLine(@"MENÚ PRINCIPAL 

                        1. Operadores.

                        2. Condicionales.

                        3. Ciclos.

                        4. Arreglos.

                        0. Salir.

                        ");

                string menu = Console.ReadLine();
                Console.Clear();
                int switch_menu = int.Parse(menu);

                switch (switch_menu)
                {
                    case 1:
                        Console.WriteLine(@"Operadores
                        

                        1. Calcular el área de un triángulo..

                        2. Suma de dos numeros.

                        3. Elevar un numero al cuadrado.

                        4. Conversor de Euros a dólares.

                        5. Calculador Area y Perimetro de un cuadrado.

                        6. Area y el volúmen de un cilindro

                        7. Radio, Longitud y area de una circunferencia

                        8. Calcular el promedio de tres (3) números

                        ");

                        string submenu = Console.ReadLine();
                        Console.Clear();
                        int switch_submenu = int.Parse(submenu);

                         Validaciones validar = new Validaciones();

                        switch (switch_submenu)
                        {
                            case 1:

                                validar.AreaTriangulo(numero1, numero2);
                                break;

                            case 2:
                                validar.SumarDosNumeros(numero1, numero2);
                                break;

                            case 3:
                                validar.ElevadoCuadrado(numero1, numero2);
                                break;

                            case 4:
                                validar.CambioMoneda(numero1, numero2);
                                break;

                            case 5:
                                validar.AreaPerimetroCuadrado(numero1, numero2);
                                break;

                            case 6:
                                validar.AreaVolumenCilindro(numero1, numero2);
                                break;

                            case 7:
                                validar.Circunferencia(numero1, numero2);
                                break;

                            case 8:
                                validar.Promedio(numero1, numero2, numero3);
                                break;
                        }
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine(@"Condicionales
                        

                        1. el número ingresado por teclado es positivo o negativo.

                        2. dos numeros mayor y menor

                        3. tres numeros mayor y menor

                        4. sumarlos si A es menor que B o sino restarlos.

                        5. encontrar el cociente entre A y B /mensaje division por 0 no existe.

                        6. s A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.

                        7. Escribir un algoritmo que determine si un año es bisiesto o no.

                        ");

                        string submenu2 = Console.ReadLine();
                        Console.Clear();
                        int switch_submenu2 = int.Parse(submenu2);

                        Validaciones validar2 = new Validaciones();

                        switch (switch_submenu2)
                        {
                            case 1:

                                validar2.PosNeg(numero1, numero2);
                                break;

                            case 2:
                                validar2.MayorMenor(numero1, numero2);
                                break;

                            case 3:

                                validar2.TresMayorMenor(numero1, numero2, numero3);
                                break;

                            case 4:
                                validar2.SumaResta(numero1, numero2);
                                break;

                            case 5:
                                validar2.Cosiente(numero1, numero2);
                                break;

                            case 6:
                                validar2.MultiSum(numero1, numero2);
                                break;

                            case 7:
                                validar2.Bisiesto(resultado);
                                break;
                        }

                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine(@"Ciclos
                        

                        1. Múltiplos de 3 que hay entre 1 y 100.

                        2. Números impares entre 0 y 100

                        3. Números pares del 1 al 100

                        4. Cuadrados de los números del 1 al 30.

                        5. sume los cuadrados de los cien primeros números naturales.

                        6. Números comprendidos entre ellos en secuencia ascendente.

                        7. Sumar todos los números que se digitan por teclado mientras no sea cero.

                        ");

                        string submenu3 = Console.ReadLine();
                        Console.Clear();
                        int switch_submenu3 = int.Parse(submenu3);

                        Validaciones validar3 = new Validaciones();

                        switch (switch_submenu3)

                        {
                            case 1:
                                validar3.MultiplosTres(resultado);
                                break;
                                Console.ReadKey();

                            case 2:
                                validar3.Impares(resultado);
                                break;
                                Console.ReadKey();

                            case 3:

                                break;

                            case 4:
                                validar3.Pares(resultado);
                                break;
                                Console.ReadKey();

                            case 5:

                                validar3.Cuadrados(resultado);
                                break;
                                Console.ReadKey();

                            case 6:

                                validar3.SecuenciaAscendente(resultado);
                                break;
                                Console.ReadKey();

                            case 7:

                                validar3.SumaCero(resultado);
                                break;

                        }
                        Console.WriteLine();
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine(@"Arreglos");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Gracias");
                        Environment.Exit(0);
                        break;


                }
                Console.Clear();
            }
        }
    }
}

