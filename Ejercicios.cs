using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscelanea
{

    class Ejercicios
    {
        double numero1 = 0.0;
        double numero2 = 0.0;
        double numero3 = 0.0;
        double suma = 0.0;

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
        public double Promedio(double numero1, double numero2)
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
    }
}
