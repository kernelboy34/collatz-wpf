using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;

namespace conjeturadecolltz
{
    public class secuencia
    {
        public double sec { get; set; }
        public double deri { get; set; }
        //definimos la variable de recepcion
        public void collatz_sec(double numeros)
        {

            this.sec = numeros;
            //especificamos que es la parte numeros
            double iterador = 2;
            for (int i = 0; i < numeros; i++)
            {
                double wi = numeros;
                 //usamos un for para que encaso de usar una lista el contador recorra cada posicion
                while (wi != 1 && wi != 2 && wi != 4)
                {

                    if (wi % 2 == 0)
                    {
                        //hay que definir dentro del if orque si no existe un margen de error por que la variable wi no guarda su valor
                        wi = wi / iterador;
                        StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Downloads\\archivoos.txt");
                        sw.Write(wi);
                        string sd = Convert.ToString(wi);
                        MessageBox.Show(sd);
                        sw.Close();

                    }

                    if (wi % 2 == 1)
                    {
                        wi = (wi * 3) + 1;
                        StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Downloads\\archivoss.txt");
                        sw.Write(wi);
                        string sd = Convert.ToString(wi);
                        MessageBox.Show(sd);
                        sw.Close ();
                    }
                    if (wi == 1 || wi == 4 || wi == 2)
                    {
                        MessageBox.Show("bucle collatz");
                        //finalizamos el bucle de collatz es optable usar un close();
                        
                    }
                }
                break;


            }


        }
        public virtual double derivadas(double d)
        {
            this.deri = d;
            double r = (d * d) + (2 * d) + 1* sec;
            string s = r.ToString();
            MessageBox.Show(s+" de rivada parcial punto predecible mas alto");
            double j = (d / d) - (d - 2) * 3/sec;
            string s2 = j.ToString();
            MessageBox.Show("punto mas bajo predecile" + s2);
            return d;
        }

      //hecho por kernelboy34
    }
}
