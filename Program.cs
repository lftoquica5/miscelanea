using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscenlanea
{
    class Program
    {

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

                        7. Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y
                            el área (pi*r)^2 del círculo inscrito

                        8. Calcular el promedio de tres (3) números

                        ");

                        string submenu = Console.ReadLine();
                        Console.Clear();
                        int switch_submenu = int.Parse(submenu);

                        int numero1;
                        int numero2;
                        int numero3;

                        switch (switch_submenu)
                        {
                            case 1:

                                Console.WriteLine("Escriba numeros enteros: ");
                                Console.WriteLine("Ingresar la base del triangulo: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingresar la altura del triangulo: ");
                                numero2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El area del triangulo es: " + (numero1 * numero2) / 2);
                                break;

                            case 2:
                                Console.WriteLine("Escriba numeros enteros: ");
                                Console.WriteLine("Ingrese el primer entero: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo entero: ");
                                numero2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("La suma es: " + (numero1 + numero2));
                                break;

                            case 3:
                                Console.WriteLine("Escriba numeros enteros: ");
                                Console.WriteLine("Ingrese el numero que quiere elevar al cuadrado: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("el numero " + numero1 + " elevado al cuadrado es: " + (numero1 * 2));

                                break;

                            case 4:
                                Console.WriteLine("Ingrese la cantidad en Euros que desea convertir a dolares: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(numero1 + " Euros equivalen a: " + (numero1 * 1.06) + " dolares ");
                                break;

                            case 5:
                                Console.WriteLine("Escriba numeros enteros: ");
                                Console.WriteLine("Ingresar el lado del cuadrado: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El area del cuadrado es: " + (numero1 * numero1) + " cm2");
                                Console.WriteLine("El perimetro del cuadrado es: " + (numero1 * 4));
                                break;

                            case 6:
                                Console.WriteLine("Escriba numeros enteros: ");
                                Console.WriteLine("Ingresar el radio del cilindro: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingresar la altura del cilindro: ");
                                numero2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El area del cilindro es: " + (2 * Math.PI * numero1 * numero2));
                                Console.WriteLine("El Volumen del cilindro es: " + (Math.PI * numero1 * numero1 * numero2));
                                break;

                            case 7:
                                Console.WriteLine("Ingresar el diametro de la circunferencia: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El radio de la circunferencia es: " + (numero1 / 2));
                                Console.WriteLine("La longitud de la circunferencia es: " + (Math.PI * numero1));
                                Console.WriteLine("El area de la circunferencia es: " + (Math.PI * (numero1 * 2)));
                                break;

                            case 8:
                                Console.WriteLine("Escriba numeros enteros: ");
                                Console.WriteLine("Ingresar el primer numero: ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingresar el segundo numero ");
                                numero2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingresar el tercer numero ");
                                numero3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El promedio de los 3 numeros ingresados es: " + (numero1 + numero2 + numero3) / 3);
                                break;
                        }
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine(@"Condicionales");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(@"Ciclos");
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