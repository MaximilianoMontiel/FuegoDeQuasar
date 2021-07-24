using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionQuasar
{
    class Interceptador
    {
        public CoordenadasNave GetLocation(DistanciasSatelites distanciasSatelites)
        {
            double xNave;
            double yNave;
            double a;
            double b;
            double c;
            double d;
            double e;
            double f;

            CoordenadasSatelites coordenadasSatelites = new CoordenadasSatelites(-500, -200, 100, -100, 500, 100);

            a = -2 * coordenadasSatelites.xKenobi + 2 * coordenadasSatelites.xSkywalker;
            b = -2 * coordenadasSatelites.yKenobi + 2 * coordenadasSatelites.ySkywalker;
            c = Math.Pow(distanciasSatelites.distanciaKenobi, 2) - Math.Pow(distanciasSatelites.distanciaSkywalker, 2) - Math.Pow(coordenadasSatelites.xKenobi, 2) + Math.Pow(coordenadasSatelites.xSkywalker, 2) - Math.Pow(coordenadasSatelites.yKenobi, 2) + Math.Pow(coordenadasSatelites.ySkywalker, 2);
            d = -2 * coordenadasSatelites.xSkywalker + 2 * coordenadasSatelites.xSato;
            e = -2 * coordenadasSatelites.ySkywalker + 2 * coordenadasSatelites.ySato;
            f = Math.Pow(distanciasSatelites.distanciaSkywalker, 2) - Math.Pow(distanciasSatelites.distanciaSato, 2) - Math.Pow(coordenadasSatelites.xSkywalker, 2) + Math.Pow(coordenadasSatelites.xSato, 2) - Math.Pow(coordenadasSatelites.ySkywalker, 2) + Math.Pow(coordenadasSatelites.ySato, 2);
            xNave = (c * e - f * b) / (e * a - b * d);
            yNave = (c * d - a * f) / (b * d - a * e);

            //(e*a - b*d) nunca es cero debido a que cada variable utiliza solo las coordendas de los satelites y es un valor fijo     
            //(e*a - b*d) nunca es cero debido a que cada variable utiliza solo las coordendas de los satelites y es un valor fijo

            CoordenadasNave coordenadasNave = new CoordenadasNave();
            coordenadasNave.xNave = xNave;
            coordenadasNave.yNave = yNave;

            return coordenadasNave;
        }

        public Mensajes GetMessage(Mensajes mensajes)
        {
            //Obtengo el largo de un array considerando que todos los arrays tienen el mismo largo
            //debido a que todos tienen el mismo mensaje
            int maximo = mensajes.msgKenobi.Length;

            //Rercorro los arrays
            for (int i = 0; i< maximo; i++)
            {
                //Si la palabra puede ser determinada en el satelite Kenobi entro al if
                if (mensajes.msgKenobi[i] != "")

                    mensajes.msgEmisor[i]= mensajes.msgKenobi[i];

                //Si la palabra no puede ser determinada en este satelite
                else
                {

                    //Si la palabra puede ser determinada en el satelite Skywalker entro al if
                    if (mensajes.msgSkywalker[i] != "")
                    {
                        mensajes.msgEmisor[i] = mensajes.msgSkywalker[i];
                    }

                    //Si la palabra no puede ser determinada en este satelite
                    else
                    {

                        //Si la palabra puede ser determinada en el satelite Sato entro al if
                        if (mensajes.msgSato[i] != "")
                        {
                            mensajes.msgEmisor[i] = mensajes.msgSato[i];
                        }

                        //Si la palabra no puede ser determinada en ningun satelite
                        else
                            mensajes.msgEmisor[i] = "";
                    }
                }
                    
            }

            return mensajes;
        }
        
    }
}
