using System;
using System.Collections.Generic;
using System.Text;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcion que ejecuta codigo
            Saludo();

            //Funcion que regrsa un valor

            int res = 0;

            res = Suma();

            Console.WriteLine("El resultado de la suma es {0}", res);

            //Funcion que recibe parametros

            Console.WriteLine("Dame el primer numero");
           int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
           int x = Convert.ToInt32(Console.ReadLine());
          
            Multiplicacion(n,x);

            //Funcion que recibe parametros y regresa un valor

            Console.WriteLine("Dame el primer numero");
            float y = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            float z = Convert.ToSingle(Console.ReadLine());
            float resul = Division(y, z);

            Console.WriteLine("El resultado de la division es {0}", resul);





            Console.ReadKey();
        }

        static void Saludo()
        {
            string nombre = "";
            Console.WriteLine("Cual es tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}, un placer saludarte", nombre);
        }

        static int Suma()
        {
            int a = 0;
            int b = 0;
            int r = 0;
            Console.WriteLine("Dame el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            r = a + b;

            return r;
         }

        static void Multiplicacion(int a, int b)
        {
            int r = 0;
            r = a * b;
            Console.WriteLine("El resultado de la multiplicacion es {0}", r);

        }

        static float Division(float a, float b)
        {
            float r = 0.0f;

            if (b == 0)
            {
                Console.WriteLine("Division por cero");

                return 0.0f;
            }
            else 
            {
                r = a / b;

                return r;
            
            }
        
        
        }



    }
}
