using miscelanea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscenlanea
{
    class Program
    {
        string menu = " ";
        static void Main(string[] args)
        {
            while (true)
            {
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

                        double numero1 = 0.0;
                        double numero2 = 0.0;
                        double numero3 = 0.0;
                        double suma = 0.0;

                        Ejercicios ejercicios = new Ejercicios();

                        switch (switch_submenu)
                        {
                            case 1:

                                ejercicios.AreaTriangulo(numero1, numero2);
                                break;

                            case 2:
                                ejercicios.SumarDosNumeros(numero1, numero2);
                                break;

                            case 3:
                                ejercicios.ElevadoCuadrado(numero1, numero2);
                                break;

                            case 4:
                                ejercicios.CambioMoneda(numero1, numero2);
                                break;

                            case 5:
                                ejercicios.AreaPerimetroCuadrado(numero1, numero2);
                                break;

                            case 6:
                                ejercicios.AreaVolumenCilindro(numero1, numero2);
                                break;

                            case 7:
                                ejercicios.Circunferencia(numero1, numero2);
                                break;

                            case 8:
                                ejercicios.Promedio(numero1, numero2);
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

                        switch (switch_submenu2)
                        {
                            case 1:

                                Console.WriteLine("Ingresa un numero");
                                numero1 = int.Parse(Console.ReadLine());

                                if (numero1 == 0)

                                {
                                    Console.WriteLine("El numero es cero ");

                                }
                                else if (numero1 >= 1)
                                {
                                    Console.WriteLine("El numero es positivo ");
                                }
                                else if (numero1 <= 1)
                                {
                                    Console.WriteLine("El numero es negativo ");
                                }
                                break;

                            case 2:
                                Console.WriteLine("Ingresa el primer numero");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el segundo numero");
                                numero2 = int.Parse(Console.ReadLine());

                                if (numero1 == numero2)

                                {
                                    Console.WriteLine("los numeros son iguales ");

                                }
                                else if (numero1 >= numero2)
                                {
                                    Console.WriteLine("El numero " + numero1 + " es mayor que el numero " + numero2);
                                }

                                else if (numero1 <= numero2)
                                {
                                    Console.WriteLine("El numero " + numero2 + " es mayor que el numero " + numero1);
                                }
                                break;

                            case 3:

                                Console.WriteLine("Ingresa el primer numero");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el segundo numero");
                                numero2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el tercer numero");
                                numero3 = int.Parse(Console.ReadLine());

                                if (numero1 < numero2)
                                {
                                    if (numero2 < numero3)
                                    {
                                        Console.WriteLine("el numero " + numero3 + " es mayor y el numero " + numero1 + " es menor");
                                    }
                                    else
                                        Console.WriteLine("el numero " + numero2 + " es mayor y el numero " + numero1 + " es menor");
                                }
                                else if (numero1 > numero2)
                                {
                                    if (numero1 > numero3)
                                    {
                                        Console.WriteLine("el numero " + numero1 + " es mayor y el numero " + numero3 + " es menor");
                                    }
                                    else
                                        Console.WriteLine("el numero " + numero2 + " es mayor y el numero " + numero3 + " es menor");
                                }
                                Console.ReadKey();
                                break;

                            case 4:
                                Console.WriteLine("Ingresa el primer numero");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el segundo numero");
                                numero2 = int.Parse(Console.ReadLine());

                                if (numero1 == numero2)

                                {
                                    Console.WriteLine("no se puede realizar ninguna operacion porque los numeros son iguales");

                                }
                                else if (numero1 < numero2)
                                {
                                    Console.WriteLine("La suma de los numeros es " + (numero1 + numero2));
                                }
                                else if (numero1 > numero2)
                                {
                                    Console.WriteLine("La resta de los numeros es " + (numero1 - numero2));
                                }
                                break;

                            case 5:
                                Console.WriteLine("Ingresa el dividendo");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el divisor");
                                numero2 = int.Parse(Console.ReadLine());

                                if (numero2 == 0)

                                {
                                    Console.WriteLine("no se puede realizar la division ");

                                }
                                else if (numero2 >= 1)
                                {
                                    Console.WriteLine("El cosiente es " + (numero1 / numero2));
                                }
                                break;

                            case 6:
                                Console.WriteLine("Ingresa el primer numero");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el segundo numero");
                                numero2 = int.Parse(Console.ReadLine());

                                if (numero1 >= 1)
                                {
                                    if (numero2 >= 1)
                                    {
                                        Console.WriteLine("la respuesta es " + (numero1 * numero2));
                                    }
                                    else
                                        Console.WriteLine("la resuesta es " + (numero1 + numero2));
                                }
                                else if (numero1 < 0)
                                {
                                    if (numero2 < 0)
                                    {
                                        Console.WriteLine("la resuesta es " + (numero1 + numero2));
                                    }
                                    else
                                        Console.WriteLine("la resuesta es " + (numero1 + numero2));

                                }
                                Console.ReadKey();
                                break;

                            case 7:
                                Console.WriteLine("Escriba el año que quiere saber si es bisiesto o no");
                                string añoB = Console.ReadLine();

                                if (Convert.ToInt32(añoB) % 4 == 0 && Convert.ToInt32(añoB) % 100 != 0 || Convert.ToInt32(añoB) % 400 == 0)
                                {
                                    Console.WriteLine("El año " + añoB + " es un año bisiesto");
                                }
                                else
                                {
                                    Console.WriteLine("El año " + añoB + " no es un año bisiesto ");
                                }
                                Console.ReadKey();
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

                        suma = 0;

                        switch (switch_submenu3)

                        {
                            case 1:
                                Console.WriteLine("los múltiplos de 3 que hay entre 1 y 100 son: ");

                                for (int i = 3; i <= 100; i += 3)
                                {
                                    Console.WriteLine(i);
                                }
                                break;
                                Console.ReadKey();

                            case 2:
                                Console.WriteLine("los números impares que hay entre 0 y 100 son: ");

                                for (int i = 3; i <= 100; i += 2)
                                {
                                    Console.WriteLine(i);
                                }
                                break;
                                Console.ReadKey();

                            case 3:
                                Console.WriteLine("los números pares que hay entre 1 y 100 son: ");

                                for (int i = 2; i <= 100; i += 2)
                                {
                                    Console.WriteLine(i) ;
                                }
                                break;
                                Console.ReadKey();

                            case 4:
                                Console.WriteLine("los cuadrados de los números del 1 al 30: ");

                                for (numero1 = 1; numero1 <= 30; numero1++)
                                {
                                    Console.WriteLine(Math.Pow(numero1, 2));
                                }
                                break;
                                Console.ReadKey();

                            case 5:

                                Console.WriteLine("la suma de los cuadrados de los cien primeros números naturales es: ");
                                for (numero1 = 1; numero1 <= 100; numero1++)
                                {
                                    suma = suma + numero1 * numero1;
                                }
                                Console.WriteLine(+ suma);
                                break;
                                Console.ReadKey();

                            case 6:

                                Console.WriteLine("números comprendidos entre ellos en secuencia ascendente: ");
                                Console.WriteLine("Ingresa el primer numero, tenga en cuenta que debe ser menor que el segundo numero a ingresar: ");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el segundo numero");
                                numero2 = int.Parse(Console.ReadLine());

                                if (numero1 > numero2)
                                {
                                    Console.WriteLine("No se puede realizar la operacion");
                                }
                                else
                                {
                                    Console.WriteLine("los numeros de  " + numero1 + " al " + numero2 + " son: ");
                                }

                                for (double i = numero1 + 1; i < numero2; i++)

                                {
                                    Console.WriteLine(i);

                                }
                                break;
                                Console.ReadKey();

                            case 7:
                                suma = 0;
                                numero1 = 0;
                                Console.Write("Recuerde que la suma de los numeros finalizara al escribir '0'");
                                Console.WriteLine();

                                do
                                {
                                    Console.Write("Ingrese numero a sumar :");
                                    numero2 = int.Parse(Console.ReadLine());

                                    suma = suma + numero2;
                                    numero1++;
                                }
                                while (numero2 != 0);
                                Console.Write("La suma de los numeros ingresados es : " + suma);
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