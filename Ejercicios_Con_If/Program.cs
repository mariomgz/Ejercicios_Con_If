using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Con_If
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que indique si es mayor de edad, 
            puede entrar a un bar y si compra una botella de ron o de guaro, 
            entra a zona VIP, Ojo tiene que tener cedula, no contraseña. 
            Ademas si compra 2 de guaro o ron le encima la media. 
            Debe estar impreso bien bonito como lo hizo el Instru en clase.*/

            int edad, compra;
            double cedula;
            compra = 0;
            cedula = 0;

            Console.WriteLine("Digite su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            
            if (edad >= 18)
            {
                Console.WriteLine("Tiene cédula?\n"+
                    "En caso afirmativo escriba su Número de Cédula, sino escriba 0");
                cedula = Convert.ToDouble((Console.ReadLine()));

                if (cedula >0)

                {
                    Console.WriteLine("¿Cuantas botellas de guaro o ron van a comprar?:");
                    compra = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (compra >= 2)
                    {
                        Console.WriteLine("-----Bienvenido al BAR CORONA-----\n" +
                          "\n" +
                            "Usted ahora es un cliente VIP\n" +
                          "\n" +
                          "EN HORA BUENA!!\n" +
                          "Por haber comprado " + compra + " unidades,\n" +
                          "le hemos obsequiado *MEDIA BOTELLA* de ron o guaro.\n");

                    }
                    else if (compra < 2)
                    {
                        Console.WriteLine("-----Bienvenido al BAR CORONA-----\n" +
                           "\n" +
                           "Usted ahora es un cliente VIP\n");

                    }


                }
                else
                {
                    Console.WriteLine("*Para ingresar al BAR CORONA usted debe tener Cédula*");
                }

                
            }
            
            else
            {
                Console.WriteLine("*Para ingresar al BAR CORONA usted debe ser mayor de edad*");
            }
               

            Console.ReadKey();
        }
    }
}
