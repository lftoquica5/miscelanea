using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscelanea
{

    class Validaciones
    {
        double numero1 = 0.0;
        double numero2 = 0.0;
        double numero3 = 0.0;
        double resultado = 0.0;

        public double AreaTriangulo(double numero1, double numero2)
        {

            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar la base del triangulo: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar la altura del triangulo: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: " + (numero1 * numero2) / 2);
            return 0.0;
        }

        public double SumarDosNumeros(double numero1, double numero2)
        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingrese el primer entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (numero1 + numero2));
            return 0.0;
        }

        public double ElevadoCuadrado(double numero1, double numero2)
        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingrese el numero que quiere elevar al cuadrado: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el numero " + numero1 + " elevado al cuadrado es: " + (numero1 * numero1));
            return 0.0;
        }

        public double CambioMoneda(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese la cantidad en Euros que desea convertir a dolares: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero1 + " Euros equivalen a: " + (numero1 * 1.06) + " dolares ");
            return 0.0;
        }

        public double AreaPerimetroCuadrado(double numero1, double numero2)
        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar el lado del cuadrado: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es: " + (numero1 * numero1) + " cm2");
            Console.WriteLine("El perimetro del cuadrado es: " + (numero1 * 4));
            return 0.0;
        }

        public double AreaVolumenCilindro(double numero1, double numero2)
        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar el radio del cilindro: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar la altura del cilindro: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area del cilindro es: " + (2 * Math.PI * numero1 * numero2));
            Console.WriteLine("El Volumen del cilindro es: " + (Math.PI * numero1 * numero1 * numero2));
            return 0.0;
        }

        public double Circunferencia(double numero1, double numero2)
        {
            Console.WriteLine("Ingresar el diametro de la circunferencia: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El radio de la circunferencia es: " + (numero1 / 2));
            Console.WriteLine("La longitud de la circunferencia es: " + (Math.PI * numero1));
            Console.WriteLine("El area de la circunferencia es: " + (Math.PI * (numero1 * 2)));
            return 0.0;
        }
        public double Promedio(double numero1, double numero2, double numero3)
        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar el primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el tercer numero ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El promedio de los 3 numeros ingresados es: " + (numero1 + numero2 + numero3) / 3);
            return 0.0;
        }

        public double PosNeg(double numero1, double numero2)
        {
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
            return 0.0;
        }

        public double MayorMenor(double numero1, double numero2)
        {
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
            return 0.0;
        }

        public double TresMayorMenor(double numero1, double numero2, double numero3)
        {
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
            return 0.0;
        }

        public double SumaResta(double numero1, double numero2)
        {
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
            return 0.0;
        }

        public double Cosiente(double numero1, double numero2)
        {
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
            return 0.0;
        }

        public double MultiSum(double numero1, double numero2)
        {
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
            return 0.0;
        }

        public double Bisiesto(double resultado)
        {
            Console.WriteLine("Escriba el año que quiere saber si es bisiesto o no");
            string Resultado = Console.ReadLine();

            if (Convert.ToInt32(resultado) % 4 == 0 && Convert.ToInt32(resultado) % 100 != 0 || Convert.ToInt32(resultado) % 400 == 0)
            {
                Console.WriteLine("El año " + resultado + " es un año bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + resultado + " no es un año bisiesto ");
            }
            Console.ReadKey();
            return 0.0;
        }
        public double MultiplosTres(double resultado)
        {
            Console.WriteLine("los múltiplos de 3 que hay entre 1 y 100 son: ");

            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
            return 0.0;
        }

        public double Impares(double resultado)
        {
            Console.WriteLine("los números impares que hay entre 0 y 100 son: ");

            for (int i = 3; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            return 0.0;
        }
        public double Pares(double resultado)
        {

            Console.WriteLine("los números pares que hay entre 1 y 100 son: ");

            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
         
            return 0.0;
        }

        public double Cuadrados(double resultado)
        {
            Console.WriteLine("la suma de los cuadrados de los cien primeros números naturales es: ");
            for (numero1 = 1; numero1 <= 100; numero1++)
            {
                resultado = resultado + numero1 * numero1;
            }
            Console.WriteLine(+resultado);
            return 0.0;
        }

        public double SecuenciaAscendente(double resultado)
        {
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
            return 0.0;
        }

        public double SumaCero(double resultado)
        {
            Console.Write("Recuerde que la suma de los numeros finalizara al escribir '0'");
            Console.WriteLine();

            do
            {
                Console.Write("Ingrese numero a sumar :");
                numero2 = int.Parse(Console.ReadLine());

                resultado = resultado + numero2;
                numero1++;
            }
            while (numero2 != 0);
            Console.Write("La suma de los numeros ingresados es : " + resultado);
            return 0.0;
        }

        public double ValidarMenu(double resultado)
        {
            return 0.0;
        }
    }

}


