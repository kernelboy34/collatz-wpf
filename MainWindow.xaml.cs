using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using LiveCharts.Wpf;
using LiveCharts;
using System.Security.Policy;
using System.Reflection.Emit;

namespace conjeturadecolltz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            this.Cartesian();


        }
        public void Cartesian()
        {
            SeriesCollection = new SeriesCollection {
             new LineSeries
                {
                    Title = "collatz numbers",
                    Values = new ChartValues<double> { 10, 31, 94, 283 ,850,2551,7654,22963,22963,68890,206671,620014,1860043, 5580130 , 16740391 , 50221174, 150663523 }

                },
            new LineSeries
            {
                Title = "columna",
                Values = new ChartValues<double> { 1, 56, 63, 78,4 },
                PointGeometry = null
            },

            new LineSeries
            {
                Title = "na",
                Values = new ChartValues<double> {1,2, 4, 78,5 },
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15
            },
               
                };
            Labels = new[] { "tablas", "char", "jaja" };
            yFormatter = value => value.ToString("c");
            SeriesCollection.Add(new LineSeries { Title = "comprobacion", Values = new ChartValues<double> { 442, 453, 444 }, LineSmoothness = 0, PointGeometry = Geometry.Parse("m.26 70 56555 94 38 -3 -7 -3"), PointForeground = Brushes.Red });
            SeriesCollection[3].Values.Add(5d);
            DataContext = this;


        }

        public Func<double, string> yFormatter { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] numeros = { 20, 43, 5 };


            for (int i = 0; i < numeros.Length; i++)
            {

                int iterador = 2;

                int xd = numeros[i] % 2;
               

                while (xd != 1 && xd < 1000000000)
                {
                    if (xd == 0)
                    {
                        
                        xd = numeros[i] / iterador;
                        StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Downloads\\archivoos.txt");
                        sw.Write(xd++);
                        sw.Close();

                    }

                    else
                    {
                        xd = xd * 3 + 1;
                        StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Downloads\\archivoss.txt");
                        sw.Write(xd++);
                        sw.Close();

                    }

                    string sd = Convert.ToString(xd);
                    MessageBox.Show(sd);





                }


            }



        }
    }
}
