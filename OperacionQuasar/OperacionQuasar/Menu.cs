using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionQuasar
{
    class Menu
    {
        public void Seleccionador()
        {
            int x = 9;
            string respuesta = "S";
            string opcion;

            // While usuario quiera seguir en el programa
            while (respuesta == "s" || respuesta == "S")
            {
                // Consulto opcion para continuar
                Console.WriteLine("Por favor, ingrese una de las siguientes opciones:");
                Console.WriteLine("1 - Para obtener la ubicacion de la Nave a la deriva");
                Console.WriteLine("2 - Para obtener el mensaje de auxilio");
                Console.WriteLine("0 - Para salir del programa");
                opcion = Console.ReadLine();

                //Si ingreso una opcion incorrecta se vuelve a solicitar que ingrese una opcion hasta que sea correcta
                while (opcion != "1" && opcion != "2" && opcion != "0")
                {
                    Console.WriteLine("Por favor, ingrese una opcion valida");
                    opcion = Console.ReadLine();
                }

                //Parseo a int la opcion
                x = Int32.Parse(opcion);

                //Si selecciono 1, ingreso a obtener la ubicacion de la nave a la deriva
                if (x == 1)
                {
                    //Inicializo variables
                    string dKe;
                    string dSky;
                    string dSa;
                    double dKenobi = 0;
                    double dSkywalker = 0;
                    double dSato = 0;

                    //La distancia no puede ser menor o igual a cero. La vuelvo a solicitar hasta que sea correcta
                    while (dKenobi <= 0)
                    {
                        Console.WriteLine("Por favor ingrese las distancia al satelite de Kenobi:");
                        dKe = Console.ReadLine();
                        dKenobi = Convert.ToDouble(dKe);
                        if (dKenobi <= 0)
                        {
                            Console.WriteLine("La distancia no puede ser menor o igual a cero");
                        }

                    }

                    //La distancia no puede ser menor o igual a cero. La vuelvo a solicitar hasta que sea correcta
                    while (dSkywalker <= 0)
                    {
                        Console.WriteLine("Por favor ingrese las distancia al satelite de Skywalker:");
                        dSky = Console.ReadLine();
                        dSkywalker = Convert.ToDouble(dSky);
                        if (dSkywalker <= 0)
                        {
                            Console.WriteLine("La distancia no puede ser menor o igual a cero");
                        }
                    }

                    //La distancia no puede ser menor o igual a cero. La vuelvo a solicitar hasta que sea correcta
                    while (dSato <= 0)
                    {
                        Console.WriteLine("Por favor ingrese las distancia al satelite de Sato:");
                        dSa = Console.ReadLine();
                        dSato = Convert.ToDouble(dSa);
                        if (dSato <= 0)
                        {
                            Console.WriteLine("La distancia no puede ser menor o igual a cero");
                        }
                    }

                    //Si el valor de la distancia es permitida, continuo

                    //Instancio el objeto distanciasSatelites, en donde se consulta las distancias de la nave barada a los satelitas
                    DistanciasSatelites distanciasSatelites = new DistanciasSatelites(dKenobi, dSkywalker, dSato);
                    
                    //Instancio los objetos interceptador y coordenadasNave
                    Console.WriteLine("Calculando ubicacion de la nave portacarga");
                    Interceptador interceptador = new Interceptador();
                    CoordenadasNave coordenadasNave = new CoordenadasNave();

                    //Llamo al metodo GetLocation para obtener las coordenadas de la nave
                    coordenadasNave = interceptador.GetLocation(distanciasSatelites);

                    //Muestro el resultado
                    Console.WriteLine("Coordenada x de la nave: {0:N2}", coordenadasNave.xNave);
                    Console.WriteLine("Coordenada y de la nave: {0:N2}", coordenadasNave.yNave);
                    Console.WriteLine("");
                    Console.WriteLine("¿Desea realizar otra operación? presione 's' o 'S' para Si, cualquier otra tecla para No");
                    respuesta = Console.ReadLine();

                }
                else
                {
                    //Si selecciono la opcion 2, obtener el mensaje de auxilio
                    if (x == 2)
                    {
                        Console.WriteLine("Obteniendo mensaje...");
                        Console.WriteLine("");

                        //Instancio los objetos mensajes e interceptador
                        Mensajes mensajes = new Mensajes();
                        Interceptador interceptador = new Interceptador();

                        //Llamo al metodo GetMessage
                        interceptador.GetMessage(mensajes);

                        //Muestro el resultado
                        Console.WriteLine("El mensaje de la nave emisora es el siguiente:");
                        Console.WriteLine(mensajes.msgEmisor[0] + " " + mensajes.msgEmisor[1] + " " + mensajes.msgEmisor[2] + " " + mensajes.msgEmisor[3] + " " + mensajes.msgEmisor[4]);
                        Console.WriteLine("");
                        Console.WriteLine("¿Desea realizar otra operación? presione 's' o 'S' para Si, cualquier otra tecla para No");
                        respuesta = Console.ReadLine();
                    }
                    else
                    {
                        //Si eligio la opcion 0, salir del programa
                        if (x == 0)
                        {
                            Console.WriteLine("Gracias por utilizar el programa de intercepcion");
                            
                            //Cambio la respuesta a "no" para que no vuelva a entrar en el loop de respuesta
                            respuesta = "n";
                        }
                        
                    }
                }
            }

            // solo muestro esta opcion si la persona ingreso a las opciones 1 o 2 y luego quiere salir del programa
            if (x != 0)
            {
                Console.WriteLine("Gracias por utilizar el programa de intercepcion");
            }
            
        }
    }
}
