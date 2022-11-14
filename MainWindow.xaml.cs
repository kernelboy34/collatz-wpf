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
                    Values = new ChartValues<double> {120,346,173,520,260,130,65,196,98,49,148,74,37,112,56,28,14,7,22,11,34,17,52,26,13,40,20,10,5,16,8,4,2,1},
                    PointForeground=Brushes.Cyan,
                   
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
            double[] numeros = { 120, 143, 115 };
            double iterador = 2;

            for (int i = 0; i < numeros.Length; i++)
            {
                double wi = numeros[1];

                while ( wi != 1 && wi != 2 && wi!=4)
                {
               
                    if (wi % 2 == 0)
                    {
                        wi= wi / iterador;
                        StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Downloads\\archivoos.txt");
                        sw.Write(wi);
                        sw.Close();
                        string sd = Convert.ToString(wi);
                        MessageBox.Show(sd);

                    }

                   if(wi % 2 == 1)
                    {
                        wi=( wi * 3 )+ 1;  
                        StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Downloads\\archivoss.txt");
                        sw.Write(wi);
                        sw.Close();
                        string sd = Convert.ToString(wi);
                        MessageBox.Show(sd);
                    }
                   if( wi == 1 ||wi == 4 ||wi == 2)
                    {
                        MessageBox.Show("bucle collatz");
                        Close();
                    } 
                }
                break;
              

            }



        }
    }
}
