using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using conjeturadecolltz;
using System.Windows.Controls;
//aplicamos derivadas y frecuencias y usamos a secuencia como herencia
namespace conjeturadecolltz
{
    class escritura:secuencia
    {
        protected double predice;
        public double[] list { get; set; }
        public void es()
        {
            double[] lista = { 346, 173, 520, 260, 130, 65, 196, 98, 49, 148, 74, 37, 112, 56, 28, 14, 7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 };
            this.list = lista;
           
            for (int i = 0; i < lista.Length; i++)
            {

                for (int h = 3; i < lista.Length; i++)
                {
                    lista[i] = lista[i] * 1 / h;
                    string a = Convert.ToString(lista[i]);
                    MessageBox.Show("frecuencia de numero es " + a);

                }



            }


        }
        public override double derivadas(double predice)
        {
            this.deri = predice;
            predice = list[29]/predice*10000;
            string g = predice.ToString();
            MessageBox.Show(g+" numero de predicion frecunecial");
           
            return predice;   
        }
       //hecho por kernelboy34
    }
   
}
