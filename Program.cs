/*
 * Created by SharpDevelop.
 * User: EQUIPO
 * Date: 1/03/2021
 * Time: 1:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2_de_programación_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// TODO: Implement Functionality Here
			
			
			// TODO: Implement Functionality Here
			
			// En este programa se les pide a los clientes que ingresen su Edad sino cuenta con la edad apropiada no pueden 
			// Ingersar al parque de diversiones, pero si, si cuentan con la edad pueden ingresar sin problemas, tambien se 
			// les pide la estatura para ver si cuenta la la estatura adecuada para algunas atracciones del parque
	        // por ultimo les pedimos cuantas entradas desean comparar.
			// Le pediremos su peso para decirle a que puede subirse y a cual no.
			// Y por ultimo le daremos una factura. 
			// Y hasta los kilometros de distancia le damos.
			// Con respecto a los kilometros será un aproximado.
			// Esta es la segunda evluación de programación 1
			
		
			Console.WriteLine("¡¡Bienvenido al Parque Tú Diversióin!!");

			// TODO:Implement Functionality Here

            string parque ="";
            double edad= 0.0;
            double altura = 0.0;
            double peso=0.0;
            double kilometros=0.0;
            double entradaspagar=0.0;
            double precioentra=0.0;
            double totalpagar=0.0;
            double elección=0;



       Console.WriteLine("¡Hola, Por favor ingrese su edad!");
                parque = Console.ReadLine();
                edad = Convert.ToInt32
                	(parque);

                if(edad <18)
                {
                	Console.WriteLine("Dilcupe usted no cuenta con la edad apropiada para este parque.");

                }
                else
                {
                    Console.WriteLine("¡¡¡Usted puede ingresar al parque de diversiones!!!"); 

            Console.WriteLine("Por favor ingrese su estatura, que sea en metros por favor");

               parque= Console.ReadLine();

                altura = Convert.ToDouble(parque);


                if(altura < 1.7)
                {
                Console.WriteLine("Puedes subirte a los carritos chocones, el gusanito, el gira gira y el trompo");    
                }
                else
                {
                    Console.WriteLine("Puedes subirte a la montaña rusa, el martillo, el Barco y otros más");

                }
                  Console.WriteLine("¡Por favor ingrese su peso!");

               parque= Console.ReadLine();

                peso = Convert.ToDouble(parque);


                if(peso >=150)
                {
                Console.WriteLine("Usted no cuenta con el peso adecudo para subir al gira gira y los carros chocones");    
                }
                else
                {
                    Console.WriteLine("Usted puede subirse a todas las atracciones");

                }
                Console.WriteLine("¡Por favor ingrese los km de distancia en la cual se encuentra!");
                Console.WriteLine("Aquí le daremos un aproximado");

               parque= Console.ReadLine();

                kilometros = Convert.ToDouble(parque);


                if(kilometros >=200)
                {
                Console.WriteLine("Usted se encuentra a 2 o más horas del parque de diversiones");    
                }
                else
                {
                    Console.WriteLine("Usted se encuentra a menos de 2 horas del parque delegate diversiones");

                }




            Console.WriteLine("Por favor, Ingrese el número de entradas que usted desea comprar");

            Console.WriteLine("Si su compra es de 4 o más le regalamos una entrada más...");

            parque= Console.ReadLine();

            entradaspagar= Convert.ToDouble(parque);

            if(entradaspagar <4)
            {
                Console.WriteLine("¡Gracias por su compra!");
            }
            else
            {
                Console.WriteLine("¡Gracias por su compra usted se ha ganado una entrada más!");
            }

            Console.WriteLine("Ingrese el numero de entradas para realizar su factura");

            parque= Console.ReadLine();

            entradaspagar= Convert.ToDouble(parque);


            Console.WriteLine("El precio de la entrada es de 30$");

            Console.WriteLine("Si cuenta con un adulto mayor a 54 años todas las entradas le saldran a 25$, seleccione por favor.");

            parque= Console.ReadLine();

            precioentra= Convert.ToDouble(parque);

            Console.WriteLine("1= ¡selecione el número 1 y tenda el total a pagar!");

            parque= Console.ReadLine();

            elección= Convert.ToDouble(parque);

            if(elección==1){
                totalpagar=entradaspagar * precioentra;
		     Console.WriteLine("El total a pagar es de {0}", totalpagar);


            }





              Console.WriteLine("¡¡Esperemos que disfrute el parque de diversiones!!");
              
              Console.WriteLine("¡Siganos en instagram como parque @TúDiversión!");
              



                //
            }




            Console.ReadKey();

        }
    }
}    